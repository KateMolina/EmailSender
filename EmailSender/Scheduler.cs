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
    public class Scheduler
    {
        DispatcherTimer timer = new DispatcherTimer();
        EmailSendService emailSendService;
        // DateTime dtSend;
        // ObservableCollection<Email> emails;
        List<string> emails;
        string mailFrom;
        Dictionary<DateTime, string> dicDates = new Dictionary<DateTime, string>();
        public Dictionary<DateTime, string> DatesEmailDic
        {
            get { return dicDates; }
            set
            {
                dicDates = value;
                dicDates = dicDates.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            }
        }


        public Scheduler()
        {

        }
        public Scheduler(string From, Dictionary<DateTime, string> dicDT)
        {
            mailFrom = From;
            DatesEmailDic = dicDT;
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

        public void SendEmails(EmailSendService emailSendService, List<string> emails)
        {
            this.emailSendService = emailSendService;
            this.emails = emails;
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("Scheduled date = " + dicDates.Keys.First<DateTime>().ToShortTimeString());
            if (dicDates.Count == 0)
            {
                timer.Stop();
                MessageBox.Show("Emails have been sent");
            }
            else if (dicDates.Keys.First<DateTime>().ToShortTimeString() == DateTime.Now.ToShortTimeString())
            {
                emailSendService.StrBody = dicDates[dicDates.Keys.First<DateTime>()];
                emailSendService.StrSubject = $"Distribution from {dicDates.Keys.First<DateTime>().ToShortTimeString()} ";
                emailSendService.SendEmails(emails, mailFrom);
                dicDates.Remove(dicDates.Keys.First<DateTime>());
            }

            #region old code
            //if (dtSend.ToShortTimeString() == DateTime.Now.ToShortTimeString())
            //{
            //    emailSendService.SendEmails(emails, mailFrom);
            //    timer.Stop();
            //    MessageBox.Show("Emais have been sent");
            //}
            #endregion

        }
    }
}
