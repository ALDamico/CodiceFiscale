namespace CodiceFiscaleUI
{
    partial class VerificaValidita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificaValidita));
            this.lblCF = new System.Windows.Forms.Label();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.epConvalida = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epConvalida)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCF
            // 
            this.lblCF.AutoSize = true;
            this.lblCF.Location = new System.Drawing.Point(13, 13);
            this.lblCF.Name = "lblCF";
            this.lblCF.Size = new System.Drawing.Size(76, 13);
            this.lblCF.TabIndex = 0;
            this.lblCF.Text = "Codice fiscale:";
            // 
            // txtCF
            // 
            this.txtCF.Location = new System.Drawing.Point(96, 13);
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(193, 20);
            this.txtCF.TabIndex = 1;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(120, 96);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(75, 23);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // epConvalida
            // 
            this.epConvalida.ContainerControl = this;
            // 
            // VerificaValidita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(311, 131);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.lblCF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerificaValidita";
            this.ShowInTaskbar = false;
            this.Text = "Verifica validità codice fiscale";
            this.Load += new System.EventHandler(this.VerificaValidita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epConvalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCF;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.ErrorProvider epConvalida;
    }
}