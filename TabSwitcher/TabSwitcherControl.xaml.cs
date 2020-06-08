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

namespace TabSwitcher
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class TabSwitcherControl : UserControl
    {
        public TabSwitcherControl()
        {
            InitializeComponent();
        }
        private bool bHidebtnPrevious = false;
        private bool bHidebtnNext = false;

        public bool IsHidebtnPrevious { get { return bHidebtnPrevious; } set { bHidebtnPrevious = value; SetButtons(); } }
        public bool IsHidebtnNext { get { return bHidebtnNext; } set { bHidebtnNext = value; SetButtons(); } }

        private void BtnNextTrueBtnPreviousFalse()
        {
            btnNext.Visibility = Visibility.Hidden;
            btnPrevious.Visibility = Visibility.Visible;
            btnPrevious.Width = 229;
            btnNext.Width = 0;
            btnPrevious.HorizontalAlignment = HorizontalAlignment.Stretch;
        }
        private void BtnPreviousTrueBtnNextFalse()
        {
            btnNext.Visibility = Visibility.Visible;
            btnPrevious.Visibility = Visibility.Hidden;
            btnNext.Width = 229;
            btnPrevious.Width = 0;
            btnNext.HorizontalAlignment = HorizontalAlignment.Stretch;
        }
        private void BtnPreviousFalseBtnNextFalse()
        {
            btnNext.Visibility = Visibility.Visible;
            btnPrevious.Visibility = Visibility.Visible;
            btnPrevious.Width = 114.5;
            btnNext.Width = 114.5;
        }
        private void BtnPreviousTrueBtnNextTrue()
        {
            btnPrevious.Visibility = Visibility.Hidden;
            btnNext.Visibility = Visibility.Hidden;
        }
        private void SetButtons()
        {
            if (bHidebtnPrevious && bHidebtnNext) BtnPreviousTrueBtnNextTrue();
            else if (!bHidebtnNext && !bHidebtnPrevious) BtnPreviousFalseBtnNextFalse();
            else if (bHidebtnNext && !bHidebtnPrevious) BtnNextTrueBtnPreviousFalse();
            else if (!bHidebtnNext && bHidebtnPrevious) BtnPreviousTrueBtnNextFalse();
        }

        public event RoutedEventHandler btnNextClick;
        public event RoutedEventHandler btnPreviousClick;


        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            btnNextClick?.Invoke(sender, e);
        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            btnPreviousClick?.Invoke(sender, e);
        }
    }

}
