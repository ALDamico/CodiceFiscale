using libCodiceFiscale.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CodiceFiscaleUI
{
    public partial class VerificaValidita : Form
    {
        public VerificaValidita()
        {
            InitializeComponent();
        }

        private bool CheckTextBox()
        {
            if (string.IsNullOrEmpty(txtCF.Text))
            {
                epConvalida.SetError(txtCF, "Digita il codice fiscale qui.");
                return false;
            }
            if (txtCF.Text.Length != 16)
            {
                epConvalida.SetError(txtCF, $"Controlla la lunghezza della stringa.\nPrevista: 16\nEffettiva: {txtCF.Text.Length}");
                return false;
            }
            return true;
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            string s = txtCF.Text.ToUpper();
            var c = CFGenerator.CalculateCheckDigit(s.Substring(0, 15));
            if (c != s.Last())
            {
                epConvalida.SetError(txtCF, "Codice fiscale non valido.");
                MessageBox.Show("Il codice fiscale inserito non è valido", "Controllo non superato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                epConvalida.SetError(txtCF, "");
                MessageBox.Show("Il codice fiscale inserito è valido", "Controllo superato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void VerificaValidita_Load(object sender, EventArgs e)
        {
            MinimizeBox = MaximizeBox = false;
        }
    }
}
