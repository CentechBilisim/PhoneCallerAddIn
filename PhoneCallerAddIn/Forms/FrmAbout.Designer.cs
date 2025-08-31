namespace PhoneCallerAddIn.Forms
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.PctAbout = new System.Windows.Forms.PictureBox();
            this.LblAbout = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // PctAbout
            // 
            this.PctAbout.Image = global::PhoneCallerAddIn.Properties.Resources.ctech_small;
            this.PctAbout.Location = new System.Drawing.Point(205, 12);
            this.PctAbout.Name = "PctAbout";
            this.PctAbout.Size = new System.Drawing.Size(186, 30);
            this.PctAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PctAbout.TabIndex = 0;
            this.PctAbout.TabStop = false;
            // 
            // LblAbout
            // 
            this.LblAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAbout.Location = new System.Drawing.Point(12, 52);
            this.LblAbout.Name = "LblAbout";
            this.LblAbout.Padding = new System.Windows.Forms.Padding(10);
            this.LblAbout.Size = new System.Drawing.Size(572, 157);
            this.LblAbout.TabIndex = 1;
            this.LblAbout.Text = "CENTECH Bilişim tarafından 2025 yılında açık kaynaklı geliştirilen bu Outlook ekl" +
    "entisi, E-posta gönderen kişiyi tek tıkla arama imkânı sunar.\r\n\r\nhttps://centech" +
    ".com.tr";
            this.LblAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnClose.Location = new System.Drawing.Point(233, 212);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(130, 41);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 265);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblAbout);
            this.Controls.Add(this.PctAbout);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uygulama Hakkında";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PctAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctAbout;
        private System.Windows.Forms.Label LblAbout;
        private System.Windows.Forms.Button BtnClose;
    }
}