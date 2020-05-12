using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ReusableBlocks.Misc
{
    public class OutlookEmailSenderBlock
    {
        private Outlook.Application _Outlook = new Outlook.Application();
        private String onBehalf;


        public OutlookEmailSenderBlock()
        {
        }

        public OutlookEmailSenderBlock(String onBehalf)
        {
            this.onBehalf = onBehalf;
        }

        public void Send(String emailTo, String emailCC, String emailBCC, String subject, String body, IEnumerable<String> fileNames)
        {
            try
            {
                Outlook.MailItem olMail = BuildMailItem(emailTo, emailCC, emailBCC, subject, body);

                if (fileNames != null)
                {
                    foreach (var fileName in fileNames)
                    {
                        Outlook.Attachment oAttach = olMail.Attachments.Add(fileName);
                    }
                }

                (olMail as Outlook._MailItem).Send();

            }
            catch (Exception)
            {
            }
        }

        private Outlook.MailItem BuildMailItem(string emailTo, string emailCC, string emailBCC, string subject, string body)
        {
            Outlook.MailItem olMail = (Outlook.MailItem)_Outlook.CreateItem(Outlook.OlItemType.olMailItem);

            if (!String.IsNullOrEmpty(emailTo))
            {
                olMail.To = emailTo.Replace(";", "; ");
            }
            if (!String.IsNullOrEmpty(emailCC))
            {
                olMail.CC = emailCC.Replace(";", "; ");
            }
            if (!String.IsNullOrEmpty(emailBCC))
            {
                olMail.BCC = emailBCC.Replace(";", "; ");
            }
            olMail.Subject = subject;

            //olMail.SetBody(Message); for plain text
            olMail.HTMLBody = body;

            if (onBehalf != null)
                olMail.SentOnBehalfOfName = onBehalf;

            return olMail;
        }
    }
}
