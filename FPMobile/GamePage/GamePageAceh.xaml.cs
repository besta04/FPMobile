using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FPMobile
{
    public partial class GamePage : PhoneApplicationPage
    {
        public GamePage()
        {
            InitializeComponent();
        }

        private void Pivot_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/GamePage/GamePageAceh.xaml?PivotMain.SelectedIndex = 0", UriKind.Relative));
            MyPivot.SelectedIndex = 2;
            btnA.IsEnabled = false;
            btnB.IsEnabled = false;
            btnC.IsEnabled = false;
            btnD.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyPivot.SelectedIndex = 1;
        }
    }
}