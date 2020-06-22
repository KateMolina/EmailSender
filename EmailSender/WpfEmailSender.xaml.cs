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
using CodePasswordDLL;
using EmailSender.View;
using EmailSender.ViewModel;
using EmailSendServiceDLL;

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
            cbSenderSelect.ItemsSource = Variables.Senders;
            cbSenderSelect.DisplayMemberPath = "Key";
            cbSenderSelect.SelectedValuePath = "Value";
            cbSmtpSelect.ItemsSource = Variables.SmtpServers;
            cbSmtpSelect.DisplayMemberPath = "Key";
            cbSmtpSelect.SelectedValuePath = "Value";

            // DataBase db = new DataBase();
            //dgEmails.ItemsSource = db.Emails;


        }

        KeyValuePair<string, int> item;

        private void BtnClock_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = tabPlanner;
            
        }

        private void SendAtOnce_Click(object sender, RoutedEventArgs e)
        {
           item = (KeyValuePair<string, int>)cbSmtpSelect.SelectionBoxItem;

            string sSmtp = item.Key;
            int iPort = item.Value;
            string strLogin = cbSenderSelect.Text;
            string strPassword = cbSenderSelect.SelectedValue.ToString();
            if (string.IsNullOrEmpty(strLogin))
            {
                MessageBox.Show("Select sender's email address"); return;
            }
            if (string.IsNullOrEmpty(strPassword))
            {
                MessageBox.Show("Enter your password"); return;
            }
            try
            {
                if (!isRichTBEmpty(rtb))
                {
                    EmailSendService emailSender = new EmailSendService(strLogin, strPassword, sSmtp, iPort, ContentFromRTB(rtb));
                    var locator = (ViewModelLocator)FindResource("Locator");
                    List<string> emails = new List<string>();
                    foreach(Email email in locator.Main.Emails)
                    { emails.Add(email.EmailCol); }
                    emailSender.SendEmails(emails, strLogin);
                }
                else
                {
                    do
                    {
                        MessageBox.Show("Enter some content of the email");
                        tabControl.SelectedItem = EditorTab;
                    } while (!isRichTBEmpty(rtb));
                }
            }
            catch { MessageBox.Show("Something went wrong"); }
          
        }
        ListViewItemScheduler lvItem;
        private void BtnSchedule_Click(object sender, RoutedEventArgs e)
        {
            //Scheduler sched = new Scheduler(cbSenderSelect.Text, new Dictionary<DateTime, string>());
            item = (KeyValuePair<string, int>)cbSmtpSelect.SelectionBoxItem;
            Scheduler sched = new Scheduler();
            for (int i = 1; i < plannerListView.Items.Count; i++)
            {
                    var item = plannerListView.Items[i];
                lvItem = item as ListViewItemScheduler;
                sched.DatesEmailDic.Add(lvItem.timePickerValue.Value, lvItem.Text);
            }
            EmailSendService emailSender = new EmailSendService(cbSenderSelect.Text, cbSenderSelect.SelectedValue.ToString(), item.Key, item.Value, ContentFromRTB(rtb));
            var locator = (ViewModelLocator)FindResource("Locator");
            List<string> emails = new List<string>();
            foreach (Email email in locator.Main.Emails) { emails.Add(email.EmailCol); }
            sched.SendEmails(emailSender, emails);

            //            TimeSpan tsSendTime = sched.GetSendTime(timePicker.Text);

            ////            if(tsSendTime ==new TimeSpan()) { MessageBox.Show("Incorrect date format"); return; }

            //            DateTime dtSendDateTime = (cldScheduleDateTimes.SelectedDate ?? DateTime.Today).Add(tsSendTime);

            //            if (dtSendDateTime < DateTime.Now) { MessageBox.Show("Scheduled Date and Time should not be before current ones"); return; }

            //            item = (KeyValuePair<string, int>)cbSmtpSelect.SelectionBoxItem;
            //            EmailSendService ess = new EmailSendService(cbSenderSelect.Text, cbSenderSelect.SelectedValue.ToString(), item.Key, item.Value, ContentFromRTB(rtb));
            //            var locator = (ViewModelLocator)FindResource("Locator");
            //            List<string> emails = new List<string>();
            //            foreach(Email email in locator.Main.Emails) { emails.Add(email.EmailCol); }
            //            sched.SendEmails(dtSendDateTime, ess, emails);
        }

        public bool isRichTBEmpty(RichTextBox rtb)
        {
            if (rtb.Document.Blocks.Count == 0) return true;
            TextPointer startPointer = rtb.Document.ContentStart.GetNextInsertionPosition(LogicalDirection.Forward);
            TextPointer endPointer = rtb.Document.ContentEnd.GetNextInsertionPosition(LogicalDirection.Backward);
            return startPointer.CompareTo(endPointer) == 0;
        }

        string ContentFromRTB(RichTextBox rtb)
        {
            TextRange tr = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            return tr.Text;
        }

        private void BtnAddShedControl_Click(object sender, RoutedEventArgs e)
        {
            plannerListView.Items.Add(new ListViewItemScheduler());
        }
       
    }
}
