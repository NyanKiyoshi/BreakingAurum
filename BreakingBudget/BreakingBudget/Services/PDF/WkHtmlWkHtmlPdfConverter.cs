// Based on Codaxy.WkHtmlToPdf under the following license:
// --------------------------------------------------------
// The MIT License(MIT)
// 
// Copyright(c) 2016
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace BreakingBudget.Services.PDF
{
    public class MissingWkHtmlExecutable : Exception
    {
        public MissingWkHtmlExecutable() : base("The WkHtml's executable wasn't found into the resource files.") { }
    }

    public class WkHtmlPdfConverterException : Exception
    {
        public WkHtmlPdfConverterException(String msg) : base(msg) { }
    }

    public class WkHtmlPdfConverterTimeoutException : WkHtmlPdfConverterException
    {
        public WkHtmlPdfConverterTimeoutException() : base("HTML to PDF conversion process has not finished in the given period.") { }
    }

    public class PdfDocument
    {
        public String Html { get; set; }

        public String PageSize = "A4";

        public String HeaderLeft { get; set; }
        public String HeaderCenter { get; set; }
        public String HeaderRight { get; set; }

        public String FooterLeft { get; set; }
        public String FooterCenter { get; set; }
        public String FooterRight { get; set; }

        public object State { get; set; }

        public Dictionary<String, String> ExtraParams { get; set; }
    }

    public static class WkHtmlWkHtmlPdfConverter
    {
        public const string WKHTMLPDF_EXE_PATH = @"Resources\wkhtmltopdf\bin\wkhtmltopdf.exe";
        public const int TIMEOUT_MS = 60000;

        private static void CheckWkhtmlToPdfExeLocationOrThrow()
        {
            if (!File.Exists(WkHtmlWkHtmlPdfConverter.WKHTMLPDF_EXE_PATH))
            {
                throw new MissingWkHtmlExecutable();
            }
        }

        private static void ParsePdfParameters(PdfDocument document, ref String outputPdfFilePath, out StringBuilder paramsBuilder)
        {
            paramsBuilder = new StringBuilder();
            paramsBuilder.AppendFormat("--page-size \"{0}\" ", document.PageSize);

            if (!string.IsNullOrEmpty(document.HeaderLeft))
            {
                paramsBuilder.AppendFormat("--header-left \"{0}\" ", document.HeaderLeft);
            }

            if (!string.IsNullOrEmpty(document.HeaderCenter))
            {
                paramsBuilder.AppendFormat("--header-center \"{0}\" ", document.HeaderCenter);
            }

            if (!string.IsNullOrEmpty(document.HeaderRight))
            {
                paramsBuilder.AppendFormat("--header-right \"{0}\" ", document.HeaderRight);
            }

            if (!string.IsNullOrEmpty(document.FooterLeft))
            {
                paramsBuilder.AppendFormat("--footer-left \"{0}\" ", document.FooterLeft);
            }

            if (!string.IsNullOrEmpty(document.FooterCenter))
            {
                paramsBuilder.AppendFormat("--footer-center \"{0}\" ", document.FooterCenter);
            }

            if (!string.IsNullOrEmpty(document.FooterRight))
            {
                paramsBuilder.AppendFormat("--footer-right \"{0}\" ", document.FooterRight);
            }

            if (document.ExtraParams != null)
            {
                foreach (var extraParam in document.ExtraParams)
                {
                    paramsBuilder.AppendFormat("--{0} {1} ", extraParam.Key, extraParam.Value);
                }
            }

            // input file is "-" -> STDIN
            paramsBuilder.AppendFormat(" - \"{0}\" ", outputPdfFilePath);
        }

        public static void ConvertHtmlToPdf(PdfDocument document, String outputPdfFilePath)
        {
            WkHtmlWkHtmlPdfConverter.ConvertHtmlToPdf(document, outputPdfFilePath, null);
        }

        public static void ConvertHtmlToPdf(PdfDocument document, String outputPdfFilePath, Action<PdfDocument, byte[]> OutputCallback)
        {
            StringBuilder paramsBuilder;

            StringBuilder output = new StringBuilder();
            StringBuilder error = new StringBuilder();

            ParsePdfParameters(document, ref outputPdfFilePath, out paramsBuilder);

            using (Process process = new Process())
            {
                // create a new process of the WKHTMLPDF's executable
                process.StartInfo.FileName = WkHtmlWkHtmlPdfConverter.WKHTMLPDF_EXE_PATH;
                process.StartInfo.Arguments = paramsBuilder.ToString();

                // don't use the shell mode
                process.StartInfo.UseShellExecute = false;

                // tell the process to redirect the I/O to the application
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardInput = true;

                using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
                {
                    DataReceivedEventHandler outputHandler = (sender, e) =>
                    {
                        if (e.Data == null)
                        {
                            outputWaitHandle.Set();
                        }
                    };

                    DataReceivedEventHandler errorHandler = (sender, e) =>
                    {
                        if (e.Data == null)
                        {
                            errorWaitHandle.Set();
                        }
                        else
                        {
                            error.AppendLine(e.Data);
                        }
                    };

                    process.OutputDataReceived += outputHandler;
                    process.ErrorDataReceived += errorHandler;

                    try
                    {
                        // start the process in another thread
                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();

                        // write the HTML document to the standard input
                        using (var stream = process.StandardInput)
                        {
                            byte[] buffer = Encoding.UTF8.GetBytes(document.Html);
                            stream.BaseStream.Write(buffer, 0, buffer.Length);
                            stream.WriteLine();
                        }

                        // wait for the thread, for a minute (by default)
                        if (process.WaitForExit(WkHtmlWkHtmlPdfConverter.TIMEOUT_MS)
                            && outputWaitHandle.WaitOne(WkHtmlWkHtmlPdfConverter.TIMEOUT_MS)
                            && errorWaitHandle.WaitOne(WkHtmlWkHtmlPdfConverter.TIMEOUT_MS))
                        {
                            if (process.ExitCode != 0 && !File.Exists(outputPdfFilePath))
                            {
                                throw new WkHtmlPdfConverterException(
                                    String.Format("Html to PDF conversion failed. Wkhtmltopdf output:\n{0}", error)
                                );
                            }
                        }
                        else
                        {
                            // kill the process if it is still running in background
                            if (!process.HasExited)
                            {
                                process.Kill();
                            }

                            throw new WkHtmlPdfConverterTimeoutException();
                        }
                    }
                    finally
                    {
                        // unset the I/O handlers
                        process.OutputDataReceived -= outputHandler;
                        process.ErrorDataReceived -= errorHandler;
                    }
                }
            }

            // if the user gave a output callback, write the standard output to the callback Stream
            if (OutputCallback != null)
            {
                byte[] pdfFileBytes = File.ReadAllBytes(outputPdfFilePath);
                OutputCallback(document, pdfFileBytes);
            }
        }
    }
}
