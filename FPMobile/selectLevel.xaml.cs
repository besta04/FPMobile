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
    public partial class selectLevel : PhoneApplicationPage
    {
        int selectedLevel;

        public selectLevel()
        {
            InitializeComponent();
        }

        private void Navigate()
        {
            NavigationService.Navigate(new Uri("/playRegion.xaml?level=" + selectedLevel, UriKind.RelativeOrAbsolute));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            selectedLevel = 1;
            Navigate();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            selectedLevel = 2;
            Navigate();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            selectedLevel = 3;
            Navigate();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            selectedLevel = 4;
            Navigate();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            selectedLevel = 5;
            Navigate();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            selectedLevel = 6;
            Navigate();
        }
    }
}