using System.Linq;
using System.IO;
using System.Reflection;
using System.Data;
using System.Windows.Forms;

namespace BreakingBudget.Services.Lang
{
    public class LocalizationManager
    {
        private Assembly callingAssembly;
        readonly string LOCALIZATION_FOLDER;

        public const string DEFAULT_LANGUAGE = "fr";
        public const string TRANSLATION_RES_FILENAME = "{0}.{1}.{2}.xml";

        // current language translation data
        private DataSet languageDataset;

        private string _currentLanguage;
        public string currentLanguage
        {
            get
            {
                return this._currentLanguage;
            }

            set
            {
                this._currentLanguage = value;
            }
        }

        public LocalizationManager(string resourceName, string language)
        {
            // try to get the entry point's assembly
            this.callingAssembly = Assembly.GetEntryAssembly();

            // if we are unable to retrieve the entry point's assembly (shouldn't append)
            // we retrieve the caller's one
            if (this.callingAssembly == null)
            {
                this.callingAssembly = Assembly.GetCallingAssembly();
            }

            // set the localization folder using the callingAssembly's path to the folder "Localization"
            this.LOCALIZATION_FOLDER = string.Format("{0}.Localization", this.callingAssembly.GetName().Name);

            // set the current language to the given one (if there is one and if available to use)
            // otherwise, to the system one or the default one if not available
            this.currentLanguage = language != null && this.RetrieveAvailableLanguages().Contains(language)
                ? language
                : RetrieveCurrentLanguage();

            if (resourceName != null)
            {
                this.ImportResourceLocalization(resourceName);
            }
        }

        private string RetrieveCurrentLanguage()
        {
            // set the current language to system one if we support it
            if (this.RetrieveAvailableLanguages().Contains(Application.CurrentCulture.TwoLetterISOLanguageName))
            {
                return Application.CurrentCulture.TwoLetterISOLanguageName;
            }
            // otherwise, set it to the fallback one
            else
            {
                // set the currentLanguage to the default one
                return LocalizationManager.DEFAULT_LANGUAGE;
            }
        }

        private string GetResourceFilename(string language, string resourceName)
        {
            return string.Format(LocalizationManager.TRANSLATION_RES_FILENAME,
                this.LOCALIZATION_FOLDER, language, resourceName
            );
        }

        public void ImportResourceLocalization(string resourceName)
        {
            // will contain the resource's localization data
            DataSet resourceDataSet;

            // will be used to open a .xml localization file
            Stream xmlStream = null;

            // build the current language's localization file name
            string localizationFilename = GetResourceFilename(this.currentLanguage, resourceName);

            // ---
            // open the current language's localization file
            xmlStream = callingAssembly.GetManifestResourceStream(localizationFilename);

            // if we failed to retrieve the resource translation
            // using the current language: try the default one
            if (xmlStream == null)
            {
                localizationFilename = GetResourceFilename(LocalizationManager.DEFAULT_LANGUAGE, resourceName);
                xmlStream = callingAssembly.GetManifestResourceStream(localizationFilename);
            }

            // if a localization file was open successfully, retrieve the data and merge it
            if (xmlStream != null)
            {
                // if the instance has no localization data yet, init it
                if (this.languageDataset == null)
                {
                    this.languageDataset = new DataSet();
                }

                // import the resource's localization data from the .xml file
                resourceDataSet = new DataSet();
                resourceDataSet.ReadXml(xmlStream);

                // merge it to the instance data
                this.languageDataset.Merge(resourceDataSet);
                xmlStream.Close();
            }

            if (xmlStream == null)
            {
                System.Console.WriteLine("E :: Resource {0} not found!", resourceName);
            }
        }

        public string[] RetrieveAvailableLanguages()
        {
            return this.callingAssembly.GetManifestResourceNames()
                // get every resource in the localization folder ending with `.xml`
                .Where(resName => resName.StartsWith(this.LOCALIZATION_FOLDER) && resName.EndsWith(".xml"))

                // trim the resource name by removing the folder name
                // and only keep the two letter of the ISO language name [Substring(x, 2)]
                .Select(resName => resName.Substring(this.LOCALIZATION_FOLDER.Length + 1, 2))

                // remove duplicates
                .Distinct()

                // return the results as a string array
                .ToArray();
        }

        public string Translate(string key, params object[] obj)
        {
            return string.Format(this.Translate(key), obj);
        }

        public string Translate(string key)
        {
            // if value is null or empty, return nothing
            if ((string.IsNullOrEmpty(key)))
            {
                return "";
            }

            // if there is no localization for the resource, return the key
            if (languageDataset == null || languageDataset.Tables["Localization"] == null)
            {
                System.Console.WriteLine("W :: No [{0}] localization found for: {1}",
                                   this.currentLanguage, key);
                return key;
            }

            // find the translations for {key}
            DataRow[] languageRows = languageDataset.Tables["Localization"].Select("Key='" + key + "'");

            // if there is not results, return the key
            if (languageRows.Length <= 0)
            {
                System.Console.WriteLine("W :: No [{0}] localization found for: {1}",
                                   this.currentLanguage, key);
                return key;
            }

            // if translation(s) were found, return it
            return languageRows[0]["Value"].ToString();
        }

        public void ControlerTranslator(Control control)
        {
            MetroFramework.Controls.MetroTextBox tmpMetroTextBox;

            if (control.Controls.Count > 0)
            {
                string TranslatedText;
                foreach (Control subCtrl in control.Controls)
                {
                    if (subCtrl is Label
                        || subCtrl is MetroFramework.Controls.MetroLabel
                        || subCtrl is Button
                        || subCtrl is MetroFramework.Controls.MetroButton
                        || subCtrl is RadioButton
                        || subCtrl is MetroFramework.Controls.MetroRadioButton)
                    {
                        // try to get a value/ translation for the label
                        TranslatedText = Translate(subCtrl.Name);

                        // only change the Text attribut's value if there
                        // was a translation found
                        if (TranslatedText != subCtrl.Name)
                        {
                            subCtrl.Text = TranslatedText;
                        }
                    }

                    if (subCtrl is MetroFramework.Controls.MetroTextBox)
                    {
                        tmpMetroTextBox = (MetroFramework.Controls.MetroTextBox)subCtrl;
                        // try to get a value/ translation for the TextBox
                        TranslatedText = Translate(tmpMetroTextBox.WaterMark);

                        // only change the Text attribut's value if there
                        // was a translation found
                        if (TranslatedText != tmpMetroTextBox.WaterMark)
                        {
                            tmpMetroTextBox.WaterMark = TranslatedText;
                        }
                    }
                    // go through the control's children
                    ControlerTranslator(subCtrl);
                }
            }
        }
    }
}
