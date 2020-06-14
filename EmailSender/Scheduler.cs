using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Xceed.Wpf.Toolkit;
using EmailSendServiceDLL;
using System.Collections.ObjectModel;

namespace EmailSender
{
    class Scheduler
    {
        DispatcherTimer timer = new DispatcherTimer();
        EmailSendService emailSendService;
        DateTime dtSend;
        // ObservableCollection<Email> emails;
        List<string> emails;
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

        public void SendEmails(DateTime dtSend, EmailSendService emailSendService, List<string> emails)
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
