﻿using System;
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
        public string name;
        public int lastLevel;
        int selectedLevel;

        public selectLevel()
        {
            InitializeComponent();
        }

        private void Navigate()
        {
            NavigationService.Navigate(new Uri("/playRegion.xaml?level=" + selectedLevel + "&name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
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

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                NavigationContext.QueryString["mode"].ToString();
                NavigationService.RemoveBackEntry();
                NavigationService.RemoveBackEntry();
                //NavigationService.RemoveBackEntry();
                WhenLoaded();
            }
            catch
            {
                WhenLoaded();
            }
        }

        private void WhenLoaded()
        {
            name = NavigationContext.QueryString["name"].ToString();
            lastLevel = 0;
            lastLevel = Convert.ToInt32(NavigationContext.QueryString["lastLevel"].ToString());
            //MessageBox.Show(lastLevel.ToString());
            if (lastLevel == 2)
            {
                btnLvl2.IsEnabled = true;
            }
            else if (lastLevel == 3)
            {
                btnLvl2.IsEnabled = true;
                btnLvl3.IsEnabled = true;
            }
            else if (lastLevel == 4)
            {
                btnLvl2.IsEnabled = true;
                btnLvl3.IsEnabled = true;
                btnLvl4.IsEnabled = true;
            }
            else if (lastLevel == 5)
            {
                btnLvl2.IsEnabled = true;
                btnLvl3.IsEnabled = true;
                btnLvl4.IsEnabled = true;
                btnLvl5.IsEnabled = true;
            }
            else if (lastLevel == 6)
            {
                btnLvl2.IsEnabled = true;
                btnLvl3.IsEnabled = true;
                btnLvl4.IsEnabled = true;
                btnLvl5.IsEnabled = true;
                btnLvl6.IsEnabled = true;
            }
        }
    }
}