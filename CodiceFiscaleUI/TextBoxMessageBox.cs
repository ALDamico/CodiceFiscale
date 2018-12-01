using System;
using System.Windows.Forms;

namespace CodiceFiscaleUI
{
    public partial class TextBoxMessageBox : UserControl
    {
        public TextBoxMessageBox()
        {
            InitializeComponent();
        }

        private void TextBoxMessageBox_Load(object sender, EventArgs e)
        {
        }

        public void Show(string message, string detailedMessage, MessageBoxIcon icon, MessageBoxButtons buttons, MessageBoxDefaultButton options)
        {
            lblMessage.Text = message;
            txtMessageDetail.Text = detailedMessage;
            this.Show();
        }

        private void TextBoxMessageBox_Load(string message, string detailedMessage, MessageBoxIcon icon, MessageBoxButtons buttons, MessageBoxDefaultButton options)
        {
        }
    }
}