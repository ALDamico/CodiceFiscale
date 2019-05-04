using libCodiceFiscale.Controllers;
using libCodiceFiscale.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodiceFiscaleUI
{
    public partial class frmMain : Form
    {
        internal MainController controller;

        public frmMain()
        {
            controller = new MainController();
            Omocodes = new List<string>();
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Imposta la data massima alla giornata odierna
            dtBirthday.MaxDate = DateTime.Now;
            controller.RetrieveForeignCountriesAsList();
            //Task t = new Task(new Action(controller.RetrieveProvincesAsList));
            //t.Start() ;
            drpProvince.DataSource = controller.Provinces;
            //controller.RetrieveForeignCountriesAsList();
            drpForeignCountries.DataSource = controller.ForeignCounties;

            InitializeSaveDialog();
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
            lstOmocode.DataSource = null;
            lstOmocode.Items.Clear();
            pnlAbroad.Visible = false;
            pnlItaly.Visible = false;
            txtCF.Text = "";
            btnCopyToClipboard.Enabled = false;
            btnCopyListToClipboard.Enabled = false;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            DateTime dateOfBirth = dtBirthday.Value;
            char gender = Convert.ToChar(drpGender.SelectedItem);
            if (drpItalyOrAbroad.SelectedIndex == 0)
            {
                controller.CurrentPlace = new Comuni_Italiani(drpMunicipality.SelectedValue.ToString());
            }
            else
            {
                controller.CurrentPlace = new ForeignCountry(drpForeignCountries.SelectedValue.ToString());
            }

            controller.SetPersonValues(name, surname, dateOfBirth, gender, controller.CurrentPlace);

            controller.Generator.GenerateFiscalCode();
            txtCF.Text = controller.Generator.FiscalCode;
            Omocodes = OmocodeGenerator.RetrieveList(txtCF.Text);
            lstOmocode.DataSource = Omocodes;
            btnCopyToClipboard.Enabled = true;
            btnCopyListToClipboard.Enabled = true;
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

        private List<string> Omocodes { get; set; }

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
            ResetConfirmation();
        }

        private void ResetConfirmation()
        {
            var answer = MessageBox.Show(
                "Sei sicuro di voler reimpostare i valori?", "Conferma reset",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
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

        private void nuovaSessioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetConfirmation();
        }
        private SaveFileDialog saveDialog;
        public string DefaultSaveLocation { get => "CF" + txtName.Text + txtSurname.Text + DateTime.Now.ToString(); }
        private void salvaSuFileDiTestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeSaveDialog();
            var answer = saveDialog.ShowDialog();
            if (answer == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    writer.WriteLine(txtCF.Text);
                }
            }
        }

        private void InitializeSaveDialog()
        {
            saveDialog = new SaveFileDialog();
            saveDialog.AddExtension = true;
            saveDialog.CheckFileExists = true;
            saveDialog.CreatePrompt = true; saveDialog.DefaultExt = ".txt";
            saveDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            saveDialog.FileName = DefaultSaveLocation;
        }

        private void visualizzaCFOmocodiciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (visualizzaCFOmocodiciToolStripMenuItem.Checked == true)
            {
                pnlOmocode.Visible = true;
            }
            else
            {
                pnlOmocode.Visible = false;
            }
        }

        private void btnCopyListToClipboard_Click(object sender, EventArgs e)
        {
            StringBuilder output = new StringBuilder();
            foreach (var item in Omocodes)
            {
                output.AppendLine(item);
            }
            try
            {
                Clipboard.SetText(output.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Si è verificato un errore.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            ttCopiedToClipBoard.Show("Elementi copiati negli appunti!", lstOmocode, 1000);
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Sei sicuro di voler uscire?", "Conferma uscita", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void verificaValiditàCFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var dialog = new VerificaValidita();
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ShowDialog(this);
        }
    }
}