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
    public partial class playRegion : PhoneApplicationPage
    {
        public string name;
        public int lastLevel;
        public playRegion()
        {
            InitializeComponent();
        }

        private void AddRegion(int level)
        {
            List<string> region = new List<string>();
            region.Clear();
            if(level == 1)
            {
                region.Add("D.I. Aceh");
                region.Add("Sumatera Utara");
                region.Add("Riau");
                region.Add("Sumatera Selatan");
            }
            else if (level == 2)
            {
                region.Add("DKI Jakarta");
                region.Add("Jawa Tengah");
                region.Add("Jawa Timur");
            }
            else if (level == 3)
            {
                region.Add("Kalimantan Barat");
                region.Add("Kalimantan Tengah");
            }
            else if (level == 4)
            {
                region.Add("Bali");
                region.Add("NTB");
                region.Add("NTT");
            }
            else if (level == 5)
            {
                region.Add("Sulawesi Utara");
                region.Add("Sulawesi Tengah");
                region.Add("Sulawesi Selatan");
                region.Add("Sulawesi Tenggara");
            }
            else if (level == 6)
            {
                region.Add("Maluku");
                region.Add("Papua Barat");
                region.Add("Papua");
            }
            myLst.ItemsSource = region;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            int levels = Convert.ToInt32(NavigationContext.QueryString["level"].ToString());
            AddRegion(levels);
            name = NavigationContext.QueryString["name"].ToString();
            lastLevel = Convert.ToInt32(NavigationContext.QueryString["lastLevel"].ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(myLst.SelectedItem.ToString());
            if (myLst.SelectedItem.ToString() == "D.I. Aceh")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageAceh.xaml?name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Sumatera Utara")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageSumut.xaml?name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Riau")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageRiau.xaml?name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Sumatera Selatan")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageSumsel.xaml?name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "DKI Jakarta")
            {
                //NavigationService.Navigate(new Uri("/GamePage/GamePageAceh.xaml?name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Jawa Tengah")
            {
                //NavigationService.Navigate(new Uri("/GamePage/GamePageAceh.xaml?name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Jawa Timur")
            {
                //NavigationService.Navigate(new Uri("/GamePage/GamePageAceh.xaml?name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
            }
        }
    }
}