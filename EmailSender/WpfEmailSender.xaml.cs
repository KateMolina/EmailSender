using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmailSender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            //cbSenderSelect.ItemsSource = Variables.Senders;
            //cbSenderSelect.DisplayMemberPath = "Key";
            //cbSenderSelect.SelectedValuePath = "Value";
            cbSmtpSelect.ItemsSource = Variables.SmtpServers;
            cbSmtpSelect.DisplayMemberPath = "Key";
            cbSmtpSelect.SelectedValuePath = "Value";

           // DataBase db = new DataBase();
            //dgEmails.ItemsSource = db.Emails;

        }

        KeyValuePair<string, int> item;
        KeyValuePair<string, string> item1;

        private void BtnClock_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = tabPlanner;
            
        }

        private void SendAtOnce_Click(object sender, RoutedEventArgs e)
        {
           item = (KeyValuePair<string, int>)cbSmtpSelect.SelectionBoxItem;
            item1 = (KeyValuePair<string, string>)cbSenderSelect.SelectionBoxItem;

            string sSmtp = item.Key;
            int iPort = item.Value;
            string strLogin = item1.Key;
            string strPassword = "#Purple55";//cbSenderSelect.SelectedValue.ToString();
            if (string.IsNullOrEmpty(strLogin))
            {
                MessageBox.Show("Select sender's email address"); return;
            }
            if (string.IsNullOrEmpty(strPassword))
            {
                MessageBox.Show("Enter your password"); return;
            }
            EmailSendService emailSender = new EmailSendService(strLogin, strPassword, sSmtp, iPort);
            emailSender.SendEmails((IQueryable<Email>)dgEmails.ItemsSource, strLogin);

        }

        private void BtnSchedule_Click(object sender, RoutedEventArgs e)
        {
            Scheduler sched = new Scheduler();
            TimeSpan tsSendTime = sched.GetSendTime(timePicker.Text);

            if(tsSendTime ==new TimeSpan()) { MessageBox.Show("Incorrect date format"); return; }

            DateTime dtSendDateTime = (cldScheduleDateTimes.SelectedDate ?? DateTime.Today).Add(tsSendTime);

            if (dtSendDateTime < DateTime.Now) { MessageBox.Show("Scheduled Date and Time should not be before current ones"); return; }

            item = (KeyValuePair<string, int>)cbSmtpSelect.SelectionBoxItem;
            EmailSendService ess = new EmailSendService(cbSenderSelect.Text, cbSenderSelect.SelectedValue.ToString(), item.Key, item.Value);
            sched.SendEmails(dtSendDateTime, ess, (IQueryable<Email>)dgEmails.ItemsSource);
        }
    }
}
