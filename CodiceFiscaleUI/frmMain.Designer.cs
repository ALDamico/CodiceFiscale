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
            this.pnlAbroad = new System.Windows.Forms.Panel();
            this.drpForeignCountries = new System.Windows.Forms.ComboBox();
            this.lblForeignCountry = new System.Windows.Forms.Label();
            this.pnlItaly = new System.Windows.Forms.Panel();
            this.drpMunicipality = new System.Windows.Forms.ComboBox();
            this.lblMunicipality = new System.Windows.Forms.Label();
            this.drpProvince = new System.Windows.Forms.ComboBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.drpItalyOrAbroad = new System.Windows.Forms.ComboBox();
            this.lblItalyOrAbroad = new System.Windows.Forms.Label();
            this.lblCF = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.ttCopiedToClipBoard = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaSessioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaCFOmocodiciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificaValiditàCFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guidaHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOmocode = new System.Windows.Forms.FlowLayoutPanel();
            this.lstOmocode = new System.Windows.Forms.ListBox();
            this.btnCopyListToClipboard = new System.Windows.Forms.Button();
            this.grpPersonalInfo.SuspendLayout();
            this.grpPlace.SuspendLayout();
            this.pnlAbroad.SuspendLayout();
            this.pnlItaly.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlOmocode.SuspendLayout();
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
            // pnlItaly
            // 
            this.pnlItaly.Controls.Add(this.drpMunicipality);
            this.pnlItaly.Controls.Add(this.lblMunicipality);
            this.pnlItaly.Controls.Add(this.drpProvince);
            this.pnlItaly.Controls.Add(this.lblProvince);
            resources.ApplyResources(this.pnlItaly, "pnlItaly");
            this.pnlItaly.Name = "pnlItaly";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.extraToolStripMenuItem,
            this.toolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovaSessioneToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // nuovaSessioneToolStripMenuItem
            // 
            this.nuovaSessioneToolStripMenuItem.Name = "nuovaSessioneToolStripMenuItem";
            resources.ApplyResources(this.nuovaSessioneToolStripMenuItem, "nuovaSessioneToolStripMenuItem");
            this.nuovaSessioneToolStripMenuItem.Click += new System.EventHandler(this.nuovaSessioneToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            resources.ApplyResources(this.esciToolStripMenuItem, "esciToolStripMenuItem");
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaCFOmocodiciToolStripMenuItem,
            this.verificaValiditàCFToolStripMenuItem});
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            resources.ApplyResources(this.extraToolStripMenuItem, "extraToolStripMenuItem");
            // 
            // visualizzaCFOmocodiciToolStripMenuItem
            // 
            this.visualizzaCFOmocodiciToolStripMenuItem.CheckOnClick = true;
            this.visualizzaCFOmocodiciToolStripMenuItem.Name = "visualizzaCFOmocodiciToolStripMenuItem";
            resources.ApplyResources(this.visualizzaCFOmocodiciToolStripMenuItem, "visualizzaCFOmocodiciToolStripMenuItem");
            this.visualizzaCFOmocodiciToolStripMenuItem.Click += new System.EventHandler(this.visualizzaCFOmocodiciToolStripMenuItem_Click);
            // 
            // verificaValiditàCFToolStripMenuItem
            // 
            this.verificaValiditàCFToolStripMenuItem.Name = "verificaValiditàCFToolStripMenuItem";
            resources.ApplyResources(this.verificaValiditàCFToolStripMenuItem, "verificaValiditàCFToolStripMenuItem");
            this.verificaValiditàCFToolStripMenuItem.Click += new System.EventHandler(this.verificaValiditàCFToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informazioniSuToolStripMenuItem,
            this.guidaHToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // informazioniSuToolStripMenuItem
            // 
            this.informazioniSuToolStripMenuItem.Name = "informazioniSuToolStripMenuItem";
            resources.ApplyResources(this.informazioniSuToolStripMenuItem, "informazioniSuToolStripMenuItem");
            // 
            // guidaHToolStripMenuItem
            // 
            this.guidaHToolStripMenuItem.Name = "guidaHToolStripMenuItem";
            resources.ApplyResources(this.guidaHToolStripMenuItem, "guidaHToolStripMenuItem");
            // 
            // pnlOmocode
            // 
            this.pnlOmocode.Controls.Add(this.lstOmocode);
            this.pnlOmocode.Controls.Add(this.btnCopyListToClipboard);
            resources.ApplyResources(this.pnlOmocode, "pnlOmocode");
            this.pnlOmocode.Name = "pnlOmocode";
            // 
            // lstOmocode
            // 
            this.lstOmocode.FormattingEnabled = true;
            resources.ApplyResources(this.lstOmocode, "lstOmocode");
            this.lstOmocode.Name = "lstOmocode";
            // 
            // btnCopyListToClipboard
            // 
            resources.ApplyResources(this.btnCopyListToClipboard, "btnCopyListToClipboard");
            this.btnCopyListToClipboard.Name = "btnCopyListToClipboard";
            this.btnCopyListToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyListToClipboard.Click += new System.EventHandler(this.btnCopyListToClipboard_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlOmocode);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblCF);
            this.Controls.Add(this.grpPlace);
            this.Controls.Add(this.grpPersonalInfo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpPlace.ResumeLayout(false);
            this.grpPlace.PerformLayout();
            this.pnlAbroad.ResumeLayout(false);
            this.pnlAbroad.PerformLayout();
            this.pnlItaly.ResumeLayout(false);
            this.pnlItaly.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlOmocode.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.ToolTip ttCopiedToClipBoard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaSessioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informazioniSuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guidaHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaCFOmocodiciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificaValiditàCFToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel pnlOmocode;
        private System.Windows.Forms.ListBox lstOmocode;
        private System.Windows.Forms.Button btnCopyListToClipboard;
    }
}

