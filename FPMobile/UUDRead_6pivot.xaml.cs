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
    public partial class UUDRead_6pivot : PhoneApplicationPage
    {
        public UUDRead_6pivot()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab03-p1.png", UriKind.Relative));
            page1.ImageSource = bi;
            BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Pasal/bab03-p2.png", UriKind.Relative));
            page2.ImageSource = bi2;
            BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Pasal/bab03-p3.png", UriKind.Relative));
            page3.ImageSource = bi3;
            BitmapImage bi4 = new BitmapImage(new Uri("/Assets/Pasal/bab03-p4.png", UriKind.Relative));
            page4.ImageSource = bi4;
            BitmapImage bi5 = new BitmapImage(new Uri("/Assets/Pasal/bab03-p5.png", UriKind.Relative));
            page5.ImageSource = bi5;
            BitmapImage bi6 = new BitmapImage(new Uri("/Assets/Pasal/bab03-p6.png", UriKind.Relative));
            page6.ImageSource = bi6;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MyPivot.SelectedIndex--;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            MyPivot.SelectedIndex++;
        }

        private void MyPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}