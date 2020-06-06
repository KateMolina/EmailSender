using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace EmailSender
{
    class EmailSendService
    {
        #region Vars
        private string strLogin;
        private string strPassword;

        private string strSmtp = "smtp.gmail.com";
        private int iSmtpPort = 587;
        private string strBody;
        private string strSubject;
        #endregion

        public EmailSendService(string sLogin, string sPassword)
        {
            strLogin = sLogin;
            strPassword = sPassword;
        }

        private void SendEmail (string mailTo, string name)
        {
            using (MailMessage mm = new MailMessage(strLogin, mailTo))
            {
                mm.Subject = strSubject;
                mm.Body = "TestBody";
                mm.IsBodyHtml = false;
                SmtpClient sc = new SmtpClient(strSmtp, iSmtpPort);
                sc.EnableSsl = true;
                sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                sc.UseDefaultCredentials = false;
                sc.Credentials = new NetworkCredential(strLogin, strPassword);
                try
                {
                    sc.Send(mm);
                }catch(SmtpException ex)
                {
                    MessageBox.Show("Unable to send an email " + ex.Message);
                }
            }
                
        }
        public void SendEmails(IQueryable<Email> emails)
        {
            foreach(Email email in emails)
            {
                SendEmail(email.EmailCol, email.Name);
            }
        }


    }
}
