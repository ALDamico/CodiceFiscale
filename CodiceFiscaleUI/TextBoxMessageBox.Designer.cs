namespace CodiceFiscaleUI
{
    partial class TextBoxMessageBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessageDetail = new System.Windows.Forms.RichTextBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(101, 37);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(83, 17);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Placeholder";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMessageDetail
            // 
            this.txtMessageDetail.Location = new System.Drawing.Point(48, 111);
            this.txtMessageDetail.Name = "txtMessageDetail";
            this.txtMessageDetail.ReadOnly = true;
            this.txtMessageDetail.Size = new System.Drawing.Size(620, 263);
            this.txtMessageDetail.TabIndex = 1;
            this.txtMessageDetail.Text = "Placeholder";
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(48, 37);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(47, 50);
            this.picIcon.TabIndex = 2;
            this.picIcon.TabStop = false;
            // 
            // TextBoxMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.txtMessageDetail);
            this.Controls.Add(this.lblMessage);
            this.Name = "TextBoxMessageBox";
            this.Size = new System.Drawing.Size(723, 439);
            this.Load += new System.EventHandler(this.TextBoxMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RichTextBox txtMessageDetail;
        private System.Windows.Forms.PictureBox picIcon;
    }
}
