using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace FPMobile
{
    public partial class UUDRead_2pivot : PhoneApplicationPage
    {
        public UUDRead_2pivot()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string bab = NavigationContext.QueryString["bab"].ToString();
            if (bab == "BAB VII : Dewan Perwakilan Rakyat")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab07-p1.png", UriKind.Relative));
                page1.ImageSource = bi;
                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Pasal/bab07-p2.png", UriKind.Relative));
                page2.ImageSource = bi2;
            }
            else if (bab == "BAB VIII : Hal Keuangan")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab08-p1.png", UriKind.Relative));
                page1.ImageSource = bi;
                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Pasal/bab08-p2.png", UriKind.Relative));
                page2.ImageSource = bi2;
            }
            else if (bab == "BAB XIII : Pendidikan dan Kebudayaan")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab13-p1.png", UriKind.Relative));
                page1.ImageSource = bi;
                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Pasal/bab13-p2.png", UriKind.Relative));
                page2.ImageSource = bi2;
            }
            else if (bab == "BAB XIV : Perekonomian Nasional dan Kesejahteraan Sosial")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab14-p1.png", UriKind.Relative));
                page1.ImageSource = bi;
                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Pasal/bab14-p2.png", UriKind.Relative));
                page2.ImageSource = bi2;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            MyPivot.SelectedIndex++;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MyPivot.SelectedIndex--;
        }

        private void MyPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}