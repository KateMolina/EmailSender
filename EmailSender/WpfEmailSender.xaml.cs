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
                    emailSender.SendEmails((IQueryable<Email>)dgEmails.ItemsSource, strLogin);
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

        private void BtnSchedule_Click(object sender, RoutedEventArgs e)
        {
            Scheduler sched = new Scheduler(cbSenderSelect.Text);
            TimeSpan tsSendTime = sched.GetSendTime(timePicker.Text);

            if(tsSendTime ==new TimeSpan()) { MessageBox.Show("Incorrect date format"); return; }

            DateTime dtSendDateTime = (cldScheduleDateTimes.SelectedDate ?? DateTime.Today).Add(tsSendTime);

            if (dtSendDateTime < DateTime.Now) { MessageBox.Show("Scheduled Date and Time should not be before current ones"); return; }

            item = (KeyValuePair<string, int>)cbSmtpSelect.SelectionBoxItem;
            EmailSendService ess = new EmailSendService(cbSenderSelect.Text, cbSenderSelect.SelectedValue.ToString(), item.Key, item.Value, ContentFromRTB(rtb));
            sched.SendEmails(dtSendDateTime, ess, (IQueryable<Email>)dgEmails.ItemsSource);
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

    }
}
