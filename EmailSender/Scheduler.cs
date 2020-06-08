using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Xceed.Wpf.Toolkit;

namespace EmailSender
{
    class Scheduler
    {
        DispatcherTimer timer = new DispatcherTimer();
        EmailSendService emailSendService;
        DateTime dtSend;
        IQueryable<Email> emails;
        string mailFrom;


        public Scheduler(string From)
        {
            mailFrom = From;
        }
        public TimeSpan GetSendTime(string strSendTime)
        {
            TimeSpan tsSendTime = new TimeSpan();
            try
            {
                tsSendTime = TimeSpan.Parse(strSendTime);
            }
            catch { }
            return tsSendTime;
        }

        public void SendEmails(DateTime dtSend, EmailSendService emailSendService, IQueryable<Email> emails)
        {
            this.dtSend = dtSend;
            this.emailSendService = emailSendService;
            this.emails = emails;
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (dtSend.ToShortTimeString() == DateTime.Now.ToShortTimeString())
            {
                emailSendService.SendEmails(emails, mailFrom);
                timer.Stop();
                MessageBox.Show("Emais have been sent");
            }

        }
    }
}
