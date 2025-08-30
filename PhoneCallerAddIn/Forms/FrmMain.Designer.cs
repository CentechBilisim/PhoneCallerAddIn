namespace PhoneCallerAddIn.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LblCall = new System.Windows.Forms.Label();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblHeader = new System.Windows.Forms.Label();
            this.PctInfo = new System.Windows.Forms.PictureBox();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCall
            // 
            this.LblCall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCall.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCall.Location = new System.Drawing.Point(12, 88);
            this.LblCall.Name = "LblCall";
            this.LblCall.Size = new System.Drawing.Size(660, 88);
            this.LblCall.TabIndex = 0;
            this.LblCall.Text = "[CALL_INFO]";
            this.LblCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.LightSlateGray;
            this.PnlHeader.Controls.Add(this.PctInfo);
            this.PnlHeader.Controls.Add(this.LblHeader);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(684, 74);
            this.PnlHeader.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnClose.Location = new System.Drawing.Point(277, 192);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(130, 41);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Kapat";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblHeader
            // 
            this.LblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHeader.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.ForeColor = System.Drawing.Color.White;
            this.LblHeader.Location = new System.Drawing.Point(13, 13);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(621, 49);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Mail Göndereni Kişiyi Arama";
            this.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PctInfo
            // 
            this.PctInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctInfo.Image = global::PhoneCallerAddIn.Properties.Resources.Info2;
            this.PctInfo.Location = new System.Drawing.Point(640, 21);
            this.PctInfo.Name = "PctInfo";
            this.PctInfo.Size = new System.Drawing.Size(32, 32);
            this.PctInfo.TabIndex = 1;
            this.PctInfo.TabStop = false;
            this.PctInfo.Click += new System.EventHandler(this.PctInfo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 245);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.LblCall);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gönderen Kişiyi Arama";
            this.TopMost = true;
            this.PnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblCall;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.PictureBox PctInfo;
    }
}