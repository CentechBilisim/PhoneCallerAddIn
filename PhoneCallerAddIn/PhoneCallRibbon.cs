using PhoneCallerAddIn.Extensions;
using PhoneCallerAddIn.Forms;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;

namespace PhoneCallerAddIn
{
    [ComVisible(true)]
    public class PhoneCallRibbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public PhoneCallRibbon()
        {
        }

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("PhoneCallerAddIn.PhoneCallRibbon.xml");
        }

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            ribbon = ribbonUI;
        }

        public void OnOpenForm(Office.IRibbonControl control)
        {
            var sender = Globals.ThisAddIn.Application.GetSenderInfo();

            if (sender == null || !sender.IsValid) return;

            if (MessageBox.Show($"{sender.SenderName} isimli kişiyi aramak istediğinizden emin misiniz?", "Arama Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            using (var frmMain = new FrmMain(sender))
            {
                frmMain.ShowDialog();
            }
        }

        private static string GetResourceText(string resourceName)
        {
            var asm = Assembly.GetExecutingAssembly();

            var resourceNames = asm.GetManifestResourceNames();

            for (var i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (var resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }

            return null;
        }
    }
}
