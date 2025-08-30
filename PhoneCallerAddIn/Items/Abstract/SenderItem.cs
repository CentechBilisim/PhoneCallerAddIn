using PhoneCallerAddIn.Extensions;
using PhoneCallerAddIn.Items.Base;

namespace PhoneCallerAddIn.Items.Abstract
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public sealed class SenderItem : ItemBase
    {
        public string SenderName { get; set; }
        public string SenderMailAddress { get; set; }

        public bool IsValid
        {
            get
            {
                return SenderName.IsNotNullOrEmpty() && SenderMailAddress.IsNotNullOrEmpty();
            }
        }

        public SenderItem(string senderName, string senderMailAddress)
        {
            SenderName = senderName;
            SenderMailAddress = senderMailAddress;
        }

        public override string ToString()
        {
            return $"{SenderName} aranıyor...";
        }
    }
}
