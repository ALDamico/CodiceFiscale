using libCodiceFiscale.Controllers;
using libCodiceFiscale.Models;
using System;
using System.Windows.Forms;

namespace CodiceFiscaleUI
{
    public partial class frmMain : Form
    {
        private MainController controller;

        public frmMain()
        {
            controller = new MainController();
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Imposta la data massima alla giornata odierna
            dtBirthday.MaxDate = DateTime.Now;
            controller.RetrieveProvincesAsList();
            drpProvince.DataSource = controller.Provinces;
            controller.RetrieveForeignCountriesAsList();
            drpForeignCountries.DataSource = controller.ForeignCounties;
            ResetControls();
        }

        private void ResetControls()
        {
            foreach (Control c in grpPersonalInfo.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            pnlAbroad.Visible = false;
            pnlItaly.Visible = false;
            txtCF.Text = "";
            btnCopyToClipboard.Enabled = false;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            DateTime dateOfBirth = dtBirthday.Value;
            char gender = Convert.ToChar(drpGender.SelectedItem);
            if (drpItalyOrAbroad.SelectedIndex == 0)
            {
                controller.CurrentPlace = new ItalianMunicipality(drpMunicipality.SelectedValue.ToString());
            }
            else
            {
                controller.CurrentPlace = new ForeignCountry(drpForeignCountries.SelectedValue.ToString());
            }

            controller.SetPersonValues(name, surname, dateOfBirth, gender, controller.CurrentPlace);

            controller.Generator.GenerateFiscalCode();
            txtCF.Text = controller.Generator.FiscalCode;
            btnCopyToClipboard.Enabled = true;
        }

        private void drpProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDrpMunicipality();
            controller.CurrentProvince = drpProvince.SelectedValue.ToString();
            controller.RetrieveCurrentProvinceMunicipalities();
            drpMunicipality.DataSource = controller.CurrentProviceMunicipalities;
            drpMunicipality.Enabled = true;
            lblMunicipality.Enabled = true;
        }

        private void ClearDrpMunicipality()
        {
            drpMunicipality.DataSource = null; //Setta il datasource a null per consentire di svuotare la lista
            drpMunicipality.Items.Clear();
        }

        private void drpItalyOrAbroad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpItalyOrAbroad.SelectedIndex == 0) //0 corrisponde all'elemento "in Italia"
            {
                pnlItaly.Visible = true;
                pnlAbroad.Visible = false;
            }
            else //Presenti solo due elementi nella dropdown, quindi questa soluzione funziona
            {
                pnlItaly.Visible = false;
                pnlAbroad.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Sei sicuro di voler reimpostare i valori?", "Conferma reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                ResetControls();
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtCF.Text);
            }
            catch (Exception)

            {

            }
            ttCopiedToClipBoard.Show("Testo copiato negli appunti!", txtCF, 1000);

        }
    }
}