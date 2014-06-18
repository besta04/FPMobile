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
    public partial class UUDIndex : PhoneApplicationPage
    {
        public UUDIndex()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("BAB I : Bentuk Dan Kedaulatan");
            list.Add("BAB II : Majelis Permusyawaratan Rakyat");
            list.Add("BAB III : Kekuasaan Pemerintahan Negara");
            list.Add("BAB V : Kementrian Negara");
            list.Add("BAB VII : Dewan Perwakilan Rakyat");
            list.Add("BAB VIII : Hal Keuangan");
            list.Add("BAB IX : Kekuasaan Kehakiman");
            list.Add("BAB X : Warga Negara dan Penduduk");
            list.Add("BAB XI : Agama");
            list.Add("BAB XII : Pertahanan Negara dan Keamanan Negara");
            list.Add("BAB XIII : Pendidikan dan Kebudayaan");
            list.Add("BAB XIV : Perekonomian Nasional dan Kesejahteraan Sosial");
            list.Add("BAB XV : Bendera, Bahasa, dan Lambang Negara, serta Lagu Kebangsaan");
            list.Add("BAB XVI : Perubahan Undang Undang Dasar");
            MainListBox.ItemsSource = list;
        }

        private void StackPanel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (MainListBox.SelectedItem.ToString() == "BAB III : Kekuasaan Pemerintahan Negara")
            {
                NavigationService.Navigate(new Uri("/UUDRead_6pivot.xaml", UriKind.Relative));
            }
            else if (MainListBox.SelectedItem.ToString() == "BAB VII : Dewan Perwakilan Rakyat" || MainListBox.SelectedItem.ToString() == "BAB VIII : Hal Keuangan" || MainListBox.SelectedItem.ToString() == "BAB XIII : Pendidikan dan Kebudayaan" || MainListBox.SelectedItem.ToString() == "BAB XIV : Perekonomian Nasional dan Kesejahteraan Sosial")
            {
                NavigationService.Navigate(new Uri("/UUDRead_2pivot.xaml?bab=" + MainListBox.SelectedItem.ToString(), UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/UUDRead.xaml?bab=" + MainListBox.SelectedItem.ToString(), UriKind.Relative));
            }
        }
    }
}