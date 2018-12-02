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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.drpGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.grpPlace = new System.Windows.Forms.GroupBox();
            this.pnlItaly = new System.Windows.Forms.Panel();
            this.pnlAbroad = new System.Windows.Forms.Panel();
            this.drpForeignCountries = new System.Windows.Forms.ComboBox();
            this.lblForeignCountry = new System.Windows.Forms.Label();
            this.drpMunicipality = new System.Windows.Forms.ComboBox();
            this.lblMunicipality = new System.Windows.Forms.Label();
            this.drpProvince = new System.Windows.Forms.ComboBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.drpItalyOrAbroad = new System.Windows.Forms.ComboBox();
            this.lblItalyOrAbroad = new System.Windows.Forms.Label();
            this.lblCF = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.ttCopiedToClipBoard = new System.Windows.Forms.ToolTip(this.components);
            this.grpPersonalInfo.SuspendLayout();
            this.grpPlace.SuspendLayout();
            this.pnlItaly.SuspendLayout();
            this.pnlAbroad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.drpGender);
            this.grpPersonalInfo.Controls.Add(this.lblGender);
            this.grpPersonalInfo.Controls.Add(this.dtBirthday);
            this.grpPersonalInfo.Controls.Add(this.lblBirthday);
            this.grpPersonalInfo.Controls.Add(this.lblCognome);
            this.grpPersonalInfo.Controls.Add(this.txtSurname);
            this.grpPersonalInfo.Controls.Add(this.lblName);
            this.grpPersonalInfo.Controls.Add(this.txtName);
            resources.ApplyResources(this.grpPersonalInfo, "grpPersonalInfo");
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.TabStop = false;
            // 
            // drpGender
            // 
            this.drpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpGender.FormattingEnabled = true;
            this.drpGender.Items.AddRange(new object[] {
            resources.GetString("drpGender.Items"),
            resources.GetString("drpGender.Items1")});
            resources.ApplyResources(this.drpGender, "drpGender");
            this.drpGender.Name = "drpGender";
            // 
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.Name = "lblGender";
            // 
            // dtBirthday
            // 
            resources.ApplyResources(this.dtBirthday, "dtBirthday");
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthday.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dtBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Value = new System.DateTime(2018, 11, 26, 0, 0, 0, 0);
            // 
            // lblBirthday
            // 
            resources.ApplyResources(this.lblBirthday, "lblBirthday");
            this.lblBirthday.Name = "lblBirthday";
            // 
            // lblCognome
            // 
            resources.ApplyResources(this.lblCognome, "lblCognome");
            this.lblCognome.Name = "lblCognome";
            // 
            // txtSurname
            // 
            resources.ApplyResources(this.txtSurname, "txtSurname");
            this.txtSurname.Name = "txtSurname";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // btnExecute
            // 
            resources.ApplyResources(this.btnExecute, "btnExecute");
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // grpPlace
            // 
            this.grpPlace.Controls.Add(this.pnlAbroad);
            this.grpPlace.Controls.Add(this.pnlItaly);
            this.grpPlace.Controls.Add(this.drpItalyOrAbroad);
            this.grpPlace.Controls.Add(this.lblItalyOrAbroad);
            resources.ApplyResources(this.grpPlace, "grpPlace");
            this.grpPlace.Name = "grpPlace";
            this.grpPlace.TabStop = false;
            // 
            // pnlItaly
            // 
            this.pnlItaly.Controls.Add(this.drpMunicipality);
            this.pnlItaly.Controls.Add(this.lblMunicipality);
            this.pnlItaly.Controls.Add(this.drpProvince);
            this.pnlItaly.Controls.Add(this.lblProvince);
            resources.ApplyResources(this.pnlItaly, "pnlItaly");
            this.pnlItaly.Name = "pnlItaly";
            // 
            // pnlAbroad
            // 
            this.pnlAbroad.Controls.Add(this.drpForeignCountries);
            this.pnlAbroad.Controls.Add(this.lblForeignCountry);
            resources.ApplyResources(this.pnlAbroad, "pnlAbroad");
            this.pnlAbroad.Name = "pnlAbroad";
            // 
            // drpForeignCountries
            // 
            this.drpForeignCountries.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpForeignCountries.FormattingEnabled = true;
            resources.ApplyResources(this.drpForeignCountries, "drpForeignCountries");
            this.drpForeignCountries.Name = "drpForeignCountries";
            // 
            // lblForeignCountry
            // 
            resources.ApplyResources(this.lblForeignCountry, "lblForeignCountry");
            this.lblForeignCountry.Name = "lblForeignCountry";
            // 
            // drpMunicipality
            // 
            this.drpMunicipality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            resources.ApplyResources(this.drpMunicipality, "drpMunicipality");
            this.drpMunicipality.FormattingEnabled = true;
            this.drpMunicipality.Name = "drpMunicipality";
            // 
            // lblMunicipality
            // 
            resources.ApplyResources(this.lblMunicipality, "lblMunicipality");
            this.lblMunicipality.Name = "lblMunicipality";
            // 
            // drpProvince
            // 
            this.drpProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpProvince.FormattingEnabled = true;
            resources.ApplyResources(this.drpProvince, "drpProvince");
            this.drpProvince.Name = "drpProvince";
            this.drpProvince.SelectedIndexChanged += new System.EventHandler(this.drpProvince_SelectedIndexChanged);
            // 
            // lblProvince
            // 
            resources.ApplyResources(this.lblProvince, "lblProvince");
            this.lblProvince.Name = "lblProvince";
            // 
            // drpItalyOrAbroad
            // 
            this.drpItalyOrAbroad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpItalyOrAbroad.FormattingEnabled = true;
            this.drpItalyOrAbroad.Items.AddRange(new object[] {
            resources.GetString("drpItalyOrAbroad.Items"),
            resources.GetString("drpItalyOrAbroad.Items1")});
            resources.ApplyResources(this.drpItalyOrAbroad, "drpItalyOrAbroad");
            this.drpItalyOrAbroad.Name = "drpItalyOrAbroad";
            this.drpItalyOrAbroad.SelectedIndexChanged += new System.EventHandler(this.drpItalyOrAbroad_SelectedIndexChanged);
            // 
            // lblItalyOrAbroad
            // 
            resources.ApplyResources(this.lblItalyOrAbroad, "lblItalyOrAbroad");
            this.lblItalyOrAbroad.Name = "lblItalyOrAbroad";
            // 
            // lblCF
            // 
            resources.ApplyResources(this.lblCF, "lblCF");
            this.lblCF.Name = "lblCF";
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::CodiceFiscaleUI.Properties.Resources.icon;
            resources.ApplyResources(this.pbIcon, "pbIcon");
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.TabStop = false;
            // 
            // txtCF
            // 
            this.txtCF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtCF, "txtCF");
            this.txtCF.Name = "txtCF";
            this.txtCF.ReadOnly = true;
            // 
            // btnCopyToClipboard
            // 
            resources.ApplyResources(this.btnCopyToClipboard, "btnCopyToClipboard");
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblCF);
            this.Controls.Add(this.grpPlace);
            this.Controls.Add(this.grpPersonalInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpPlace.ResumeLayout(false);
            this.grpPlace.PerformLayout();
            this.pnlItaly.ResumeLayout(false);
            this.pnlItaly.PerformLayout();
            this.pnlAbroad.ResumeLayout(false);
            this.pnlAbroad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
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
        private System.Windows.Forms.Label lblCF;
        private System.Windows.Forms.Panel pnlAbroad;
        private System.Windows.Forms.ComboBox drpForeignCountries;
        private System.Windows.Forms.Label lblForeignCountry;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.ToolTip ttCopiedToClipBoard;
    }
}

