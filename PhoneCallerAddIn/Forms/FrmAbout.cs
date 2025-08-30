using System;
using System.Windows.Forms;

namespace PhoneCallerAddIn.Forms
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
