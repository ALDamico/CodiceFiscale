namespace CodiceFiscaleUI
{
    partial class frmMain
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
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.drpGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpPlace = new System.Windows.Forms.GroupBox();
            this.drpItalyOrAbroad = new System.Windows.Forms.ComboBox();
            this.lblItalyOrAbroad = new System.Windows.Forms.Label();
            this.pnlItaly = new System.Windows.Forms.Panel();
            this.drpMunicipality = new System.Windows.Forms.ComboBox();
            this.lblMunicipality = new System.Windows.Forms.Label();
            this.drpProvince = new System.Windows.Forms.ComboBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.pnlAbroad = new System.Windows.Forms.Panel();
            this.drpForeignCountries = new System.Windows.Forms.ComboBox();
            this.lblForeignCountry = new System.Windows.Forms.Label();
            this.lblCF = new System.Windows.Forms.Label();
            this.grpPersonalInfo.SuspendLayout();
            this.grpPlace.SuspendLayout();
            this.pnlItaly.SuspendLayout();
            this.pnlAbroad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.btnExecute);
            this.grpPersonalInfo.Controls.Add(this.drpGender);
            this.grpPersonalInfo.Controls.Add(this.lblGender);
            this.grpPersonalInfo.Controls.Add(this.dtBirthday);
            this.grpPersonalInfo.Controls.Add(this.lblBirthday);
            this.grpPersonalInfo.Controls.Add(this.lblCognome);
            this.grpPersonalInfo.Controls.Add(this.txtSurname);
            this.grpPersonalInfo.Controls.Add(this.lblName);
            this.grpPersonalInfo.Controls.Add(this.txtName);
            this.grpPersonalInfo.Location = new System.Drawing.Point(461, 31);
            this.grpPersonalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPersonalInfo.Size = new System.Drawing.Size(315, 329);
            this.grpPersonalInfo.TabIndex = 0;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Informazioni personali";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(232, 300);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "Calcola";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // drpGender
            // 
            this.drpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpGender.FormattingEnabled = true;
            this.drpGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.drpGender.Location = new System.Drawing.Point(85, 105);
            this.drpGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpGender.Name = "drpGender";
            this.drpGender.Size = new System.Drawing.Size(223, 24);
            this.drpGender.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(8, 108);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Genere:";
            // 
            // dtBirthday
            // 
            this.dtBirthday.CustomFormat = "dd MMMM yyyy";
            this.dtBirthday.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthday.Location = new System.Drawing.Point(120, 78);
            this.dtBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtBirthday.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dtBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(188, 22);
            this.dtBirthday.TabIndex = 5;
            this.dtBirthday.Value = new System.DateTime(2018, 11, 26, 0, 0, 0, 0);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(8, 79);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(106, 17);
            this.lblBirthday.TabIndex = 4;
            this.lblBirthday.Text = "Data di nascita:";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(7, 50);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(72, 17);
            this.lblCognome.TabIndex = 3;
            this.lblCognome.Text = "Cognome:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(85, 49);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(223, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 22);
            this.txtName.TabIndex = 0;
            // 
            // grpPlace
            // 
            this.grpPlace.Controls.Add(this.pnlAbroad);
            this.grpPlace.Controls.Add(this.drpItalyOrAbroad);
            this.grpPlace.Controls.Add(this.lblItalyOrAbroad);
            this.grpPlace.Controls.Add(this.pnlItaly);
            this.grpPlace.Location = new System.Drawing.Point(17, 31);
            this.grpPlace.Margin = new System.Windows.Forms.Padding(4);
            this.grpPlace.Name = "grpPlace";
            this.grpPlace.Padding = new System.Windows.Forms.Padding(4);
            this.grpPlace.Size = new System.Drawing.Size(393, 329);
            this.grpPlace.TabIndex = 1;
            this.grpPlace.TabStop = false;
            this.grpPlace.Text = "Luogo di nascita";
            // 
            // drpItalyOrAbroad
            // 
            this.drpItalyOrAbroad.FormattingEnabled = true;
            this.drpItalyOrAbroad.Items.AddRange(new object[] {
            "in Italia",
            "all\'estero"});
            this.drpItalyOrAbroad.Location = new System.Drawing.Point(108, 19);
            this.drpItalyOrAbroad.Margin = new System.Windows.Forms.Padding(4);
            this.drpItalyOrAbroad.Name = "drpItalyOrAbroad";
            this.drpItalyOrAbroad.Size = new System.Drawing.Size(272, 24);
            this.drpItalyOrAbroad.TabIndex = 2;
            this.drpItalyOrAbroad.SelectedIndexChanged += new System.EventHandler(this.drpItalyOrAbroad_SelectedIndexChanged);
            // 
            // lblItalyOrAbroad
            // 
            this.lblItalyOrAbroad.AutoSize = true;
            this.lblItalyOrAbroad.Location = new System.Drawing.Point(9, 21);
            this.lblItalyOrAbroad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItalyOrAbroad.Name = "lblItalyOrAbroad";
            this.lblItalyOrAbroad.Size = new System.Drawing.Size(77, 17);
            this.lblItalyOrAbroad.TabIndex = 1;
            this.lblItalyOrAbroad.Text = "Sono nato:";
            // 
            // pnlItaly
            // 
            this.pnlItaly.Controls.Add(this.drpMunicipality);
            this.pnlItaly.Controls.Add(this.lblMunicipality);
            this.pnlItaly.Controls.Add(this.drpProvince);
            this.pnlItaly.Controls.Add(this.lblProvince);
            this.pnlItaly.Location = new System.Drawing.Point(8, 50);
            this.pnlItaly.Margin = new System.Windows.Forms.Padding(4);
            this.pnlItaly.Name = "pnlItaly";
            this.pnlItaly.Size = new System.Drawing.Size(377, 271);
            this.pnlItaly.TabIndex = 0;
            // 
            // drpMunicipality
            // 
            this.drpMunicipality.Enabled = false;
            this.drpMunicipality.FormattingEnabled = true;
            this.drpMunicipality.Location = new System.Drawing.Point(87, 61);
            this.drpMunicipality.Margin = new System.Windows.Forms.Padding(4);
            this.drpMunicipality.Name = "drpMunicipality";
            this.drpMunicipality.Size = new System.Drawing.Size(285, 24);
            this.drpMunicipality.TabIndex = 3;
            // 
            // lblMunicipality
            // 
            this.lblMunicipality.AutoSize = true;
            this.lblMunicipality.Enabled = false;
            this.lblMunicipality.Location = new System.Drawing.Point(8, 61);
            this.lblMunicipality.Name = "lblMunicipality";
            this.lblMunicipality.Size = new System.Drawing.Size(64, 17);
            this.lblMunicipality.TabIndex = 2;
            this.lblMunicipality.Text = "Comune:";
            // 
            // drpProvince
            // 
            this.drpProvince.FormattingEnabled = true;
            this.drpProvince.Location = new System.Drawing.Point(87, 26);
            this.drpProvince.Margin = new System.Windows.Forms.Padding(4);
            this.drpProvince.Name = "drpProvince";
            this.drpProvince.Size = new System.Drawing.Size(285, 24);
            this.drpProvince.TabIndex = 1;
            this.drpProvince.SelectedIndexChanged += new System.EventHandler(this.drpProvince_SelectedIndexChanged);
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(5, 27);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(70, 17);
            this.lblProvince.TabIndex = 0;
            this.lblProvince.Text = "Provincia:";
            // 
            // pnlAbroad
            // 
            this.pnlAbroad.Controls.Add(this.drpForeignCountries);
            this.pnlAbroad.Controls.Add(this.lblForeignCountry);
            this.pnlAbroad.Location = new System.Drawing.Point(11, 49);
            this.pnlAbroad.Name = "pnlAbroad";
            this.pnlAbroad.Size = new System.Drawing.Size(374, 274);
            this.pnlAbroad.TabIndex = 5;
            this.pnlAbroad.Visible = false;
            // 
            // drpForeignCountries
            // 
            this.drpForeignCountries.FormattingEnabled = true;
            this.drpForeignCountries.Location = new System.Drawing.Point(100, 33);
            this.drpForeignCountries.Name = "drpForeignCountries";
            this.drpForeignCountries.Size = new System.Drawing.Size(271, 24);
            this.drpForeignCountries.TabIndex = 1;
            // 
            // lblForeignCountry
            // 
            this.lblForeignCountry.AutoSize = true;
            this.lblForeignCountry.Location = new System.Drawing.Point(11, 33);
            this.lblForeignCountry.Name = "lblForeignCountry";
            this.lblForeignCountry.Size = new System.Drawing.Size(52, 17);
            this.lblForeignCountry.TabIndex = 0;
            this.lblForeignCountry.Text = "Paese:";
            // 
            // lblCF
            // 
            this.lblCF.AutoSize = true;
            this.lblCF.Location = new System.Drawing.Point(281, 386);
            this.lblCF.Name = "lblCF";
            this.lblCF.Size = new System.Drawing.Size(82, 17);
            this.lblCF.TabIndex = 2;
            this.lblCF.Text = "placeholder";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCF);
            this.Controls.Add(this.grpPlace);
            this.Controls.Add(this.grpPersonalInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Codice Fiscale";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpPlace.ResumeLayout(false);
            this.grpPlace.PerformLayout();
            this.pnlItaly.ResumeLayout(false);
            this.pnlItaly.PerformLayout();
            this.pnlAbroad.ResumeLayout(false);
            this.pnlAbroad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.ComboBox drpGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.GroupBox grpPlace;
        private System.Windows.Forms.Label lblItalyOrAbroad;
        private System.Windows.Forms.Panel pnlItaly;
        private System.Windows.Forms.ComboBox drpItalyOrAbroad;
        private System.Windows.Forms.ComboBox drpProvince;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.ComboBox drpMunicipality;
        private System.Windows.Forms.Label lblMunicipality;
        private System.Windows.Forms.Panel pnlAbroad;
        private System.Windows.Forms.ComboBox drpForeignCountries;
        private System.Windows.Forms.Label lblForeignCountry;
        private System.Windows.Forms.Label lblCF;
    }
}

