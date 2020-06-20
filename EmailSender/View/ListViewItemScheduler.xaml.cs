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

namespace EmailSender.View
{
    /// <summary>
    /// Interaction logic for ListViewItemScheduler.xaml
    /// </summary>
    public partial class ListViewItemScheduler : UserControl
    {
        SchedulerRTBWindow rTBWindow = new SchedulerRTBWindow();
        private DateTime _timePickerVal;
        private string _text;
       public DateTime TimePickerValue { get => _timePickerVal; set { if (lvTimePicker.Value != null) _timePickerVal = (DateTime)lvTimePicker.Value; }}
        public string Text { get => _text; set => _text = rTBWindow.RtbContent; }

        public ListViewItemScheduler()
        {
            InitializeComponent();
        }
        public string Message { get; set; }

        private void BtnCallRbt_Click(object sender, RoutedEventArgs e)
        {
            SchedulerRTBWindow rtbWin = new SchedulerRTBWindow();
            rtbWin.Show();
        }
        private void BtnDeleteDT_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
