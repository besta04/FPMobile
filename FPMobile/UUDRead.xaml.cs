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
    public partial class UUDRead : PhoneApplicationPage
    {
        public UUDRead()
        {
            InitializeComponent();
        }
        // 1 2 5 9 10 11 12 15 16
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string bab = NavigationContext.QueryString["bab"].ToString();

            if(bab == "BAB I : Bentuk Dan Kedaulatan")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab01.png", UriKind.Relative));
                gambarUUD.ImageSource = bi;
            }
            else if(bab == "BAB II : Majelis Permusyawaratan Rakyat")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab02.png", UriKind.Relative));
                gambarUUD.ImageSource = bi;
            }
            else if (bab == "BAB V : Kementrian Negara")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab05.png", UriKind.Relative));
                gambarUUD.ImageSource = bi;
            }
            else if (bab == "BAB IX : Kekuasaan Kehakiman")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab09.png", UriKind.Relative));
                gambarUUD.ImageSource = bi;
            }
            else if (bab == "BAB X : Warga Negara dan Penduduk")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab10.png", UriKind.Relative));
                gambarUUD.ImageSource = bi;
            }
            else if (bab == "BAB XI : Agama")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab11.png", UriKind.Relative));
                gambarUUD.ImageSource = bi;
            }
            else if (bab == "BAB XII : Pertahanan Negara dan Keamanan Negara")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab12.png", UriKind.Relative));
                gambarUUD.ImageSource = bi;
            }
            else if (bab == "BAB XV : Bendera, Bahasa, dan Lambang Negara, serta Lagu Kebangsaan")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab15.png", UriKind.Relative));
                gambarUUD.ImageSource = bi;
            }
            else if (bab == "BAB XVI : Perubahan Undang Undang Dasar")
            {
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Pasal/bab16.png", UriKind.Relative));
                gambarUUD.ImageSource = bi;
            }
        }
    }
}