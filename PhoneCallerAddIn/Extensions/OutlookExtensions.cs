using Microsoft.Office.Interop.Outlook;
using PhoneCallerAddIn.Items.Abstract;
using System;
using System.Runtime.InteropServices;

namespace PhoneCallerAddIn.Extensions
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public static class OutlookExtensions
    {
        public static SenderItem GetSenderInfo(this Application app)
        {
            Inspector insp = null;
            Explorer exp = null;
            Selection sel = null;
            MailItem mi = null;
            AddressEntry addr = null;
            ExchangeUser exch = null;

            try
            {
                insp = app.ActiveInspector();

                if (insp?.CurrentItem is MailItem im)
                {
                    mi = im;
                }
                else
                {
                    exp = app.ActiveExplorer();
                    sel = exp?.Selection;

                    if (sel != null && sel.Count > 0 && sel[1] is MailItem sm)
                    {
                        mi = sm;
                    }
                }

                if (mi == null) return null;

                var display = mi.Sender?.Name;
                var smtp = mi.SenderEmailAddress;

                if (string.Equals(mi.SenderEmailType, "EX", StringComparison.OrdinalIgnoreCase))
                {
                    addr = mi.Sender;
                    exch = addr?.GetExchangeUser();

                    if (exch.PrimarySmtpAddress.IsNotNullOrEmpty())
                    {
                        smtp = exch.PrimarySmtpAddress;
                    }
                }

                if (display.IsNotNullOrEmpty() && smtp.IsNotNullOrEmpty())
                {
                    return new SenderItem(display, smtp);
                }

                return null;
            }
            finally
            {
                SafeRelease(exch);
                SafeRelease(addr);
                SafeRelease(mi);
                SafeRelease(sel);
                SafeRelease(exp);
                SafeRelease(insp);
            }
        }

        private static void SafeRelease(object com)
        {
            if (com == null) return;

            try
            {
                Marshal.FinalReleaseComObject(com);
            }
            catch
            { }
        }
    }
}
