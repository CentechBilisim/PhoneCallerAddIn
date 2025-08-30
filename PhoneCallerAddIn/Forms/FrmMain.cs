using PhoneCallerAddIn.Items.Abstract;
using System;
using System.Windows.Forms;

namespace PhoneCallerAddIn.Forms
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public partial class FrmMain : Form
    {
        private readonly SenderItem sender;

        public FrmMain(SenderItem sender)
        {
            InitializeComponent();

            this.sender = sender;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            LblCall.Text = $"{sender}";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PctInfo_Click(object sender, EventArgs e)
        {
            using (var frmAbout = new FrmAbout())
            {
                frmAbout.ShowDialog();
            }
        }
    }
}
