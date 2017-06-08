using System;
using System.Windows.Forms;

using MetroFramework.Forms;

using BreakingBudget.Repositories;
using BreakingBudget.Services.Lang;

namespace BreakingBudget.Views
{
    public partial class ModifierEntreePosteFixe : MetroForm
    {
        public PostePeriodiqueRepository.PostePeriodiqueModel originalData { get; }

        private PostePeriodiqueRepository.PostePeriodiqueModel _editedData = new PostePeriodiqueRepository.PostePeriodiqueModel();
        public PostePeriodiqueRepository.PostePeriodiqueModel editedData
        {
            get
            {
                return this._editedData;
            }
        }

        public ModifierEntreePosteFixe(PostePeriodiqueRepository.PostePeriodiqueModel originalData)
        {
            InitializeComponent();
            this.originalData = originalData;

            // localize
            this.Text = Program.settings.localize.Translate(this.Name);
            this.Refresh();

            Program.settings.localize.ControlerTranslator(this);

            // inherit the theme
            this.metroStyleExtender.StyleManager = Program.settings.styleManager;
            this.StyleManager = this.metroStyleManager;

            this.StyleManager.Theme = Program.settings.styleManager.Theme;
            this.StyleManager.Style = Program.settings.styleManager.Style;
        }

        private void Submit_Click(object sender, EventArgs _e)
        {
            decimal montant;
            int everyXDays;

            PeriodiciteRepository.PeriodiciteModel period;

            try {
                PosteRepository.CheckDayRangeOrThrow(int.Parse(this.TxtBoxTousLesXMois.Text));
            }
            catch (ArgumentException e)
            {
                ErrorManager.ShowOperationFailed(this, e.Message);
                return;
            }

            // check if fields not empty
            if (string.IsNullOrWhiteSpace(this.txtBoxLibPoste.Text)
                || string.IsNullOrWhiteSpace(TxtBoxTousLesXMois.Text)
                || string.IsNullOrWhiteSpace(this.TxtBoxMontantPosteFixe.Text)
                || this.ComboxBoxListePeriodicites.SelectedItem == null)
            {
                ErrorManager.ShowMissingFieldsError(this);
                return;
            }

            // check if values are valid
            if (!(LocalizationManager.ConvertFloatingTo<int>(
                    this.TxtBoxTousLesXMois.Text, int.TryParse, out everyXDays)
                    && LocalizationManager.ConvertFloatingTo<decimal>(
                    this.TxtBoxMontantPosteFixe.Text, decimal.TryParse, out montant)))
            {
                ErrorManager.ShowNotANumberError(this);
                return;
            }

            editedData.libPoste_s = this.txtBoxLibPoste.Text;

            // if the lib poste was modified, check if unique; if not => error
            if (!originalData.libPoste_s.Equals(editedData.libPoste_s)
                && !PosteRepository.IsUnique(editedData.libPoste_s))
            {
                ErrorManager.ShowDuplicateError(this);
                return;
            }

            period = (PeriodiciteRepository.PeriodiciteModel)this.ComboxBoxListePeriodicites.SelectedItem;

            // retrieve/ set remaining data
            editedData.jourDuMois = everyXDays;
            editedData.montant = montant;
            editedData.typePer = period.codePer;
            editedData.libPer_s = period.libPer;

            // mark form as submitted and close it
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ModifierEntreePosteFixe_Load(object sender, EventArgs _e)
        {
            this.ComboxBoxListePeriodicites.Items.AddRange(PeriodiciteRepository.List());

            foreach (PeriodiciteRepository.PeriodiciteModel e in this.ComboxBoxListePeriodicites.Items)
            {
                if (e.codePer == this.originalData.typePer)
                {
                    this.ComboxBoxListePeriodicites.SelectedItem = e;
                    break;
                }
            }

            this.txtBoxLibPoste.Text = this.originalData.libPoste_s;
            this.TxtBoxTousLesXMois.Text = this.originalData.jourDuMois.ToString();
            this.TxtBoxMontantPosteFixe.Text = this.originalData.montant.ToString();
        }
    }
}
