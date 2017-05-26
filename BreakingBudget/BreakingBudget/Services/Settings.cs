using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using BreakingBudget.Services.Lang;

namespace BreakingBudget.Services
{
    [Serializable]
    public class Settings
    {

        public MetroFramework.MetroColorStyle MetroColorStyle = MetroFramework.MetroColorStyle.Default;
        public MetroFramework.MetroThemeStyle MetroTheme = MetroFramework.MetroThemeStyle.Default;

        public string TwoLetterISOLanguage = null;

        [NonSerialized]
        public const string OUTPUT_FILE = "Settings.dat";

        [NonSerialized]
        public LocalizationManager localize;

        public static Settings Load()
        {
            if (!File.Exists(Settings.OUTPUT_FILE))
            {
                return null;
            }

            Settings instance;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Settings.OUTPUT_FILE,
                FileMode.Open, FileAccess.Read, FileShare.Read);

            try
            {
                instance = (Settings)formatter.Deserialize(stream);
            }
            catch (SerializationException e)
            {
                MessageBox.Show(e.ToString(), "Deserialization Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                stream.Close();
            }

            instance.localize = new LocalizationManager("Commons", instance.TwoLetterISOLanguage);
            return instance;
        }

        public bool Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Settings.OUTPUT_FILE,
                FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                formatter.Serialize(stream, this);
            }
            catch (SerializationException e)
            {
                MessageBox.Show(e.ToString(), "Serialization Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                stream.Close();
            }

            return true;
        }
    }
}
