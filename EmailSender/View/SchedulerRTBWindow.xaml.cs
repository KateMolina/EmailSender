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
using System.Windows.Shapes;

namespace EmailSender.View
{
    /// <summary>
    /// Interaction logic for SchedulerRTBWindow.xaml
    /// </summary>
    public partial class SchedulerRTBWindow : Window
    {
        public SchedulerRTBWindow()
        {
            InitializeComponent();
        }

        private string _rtbContent;
        public string RtbContent { get => _rtbContent; set => _rtbContent = value; }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            TextRange txtRange;
            txtRange = new TextRange(rtbScheduler.Document.ContentStart, rtbScheduler.Document.ContentEnd);
            RtbContent = txtRange.Text;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
