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

           // DataBase db = new DataBase();
            //dgEmails.ItemsSource = db.Emails;
        }

        private void BtnClock_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = tabPlanner;
            
        }

        private void SendAtOnce_Click(object sender, RoutedEventArgs e)
        {
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
            EmailSendService emailSender = new EmailSendService(strLogin, strPassword);
            emailSender.SendEmails((IQueryable<Email>)dgEmails.ItemsSource);

        }

        private void BtnSchedule_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
