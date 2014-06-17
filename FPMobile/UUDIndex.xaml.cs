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
            list.Add("BAB VI : Pemerintah Daerah");
            list.Add("BAB VII : Dewan Perwakilan Rakyat");
            list.Add("BAB VIIA : Dewan Perwakilan Daerah");
            list.Add("BAB VIIB : Pemilihan Umum");
            list.Add("BAB VIII : Hal Keuangan");
            list.Add("BAB VIIIA : Badan Pemeriksa Keuangan");
            list.Add("BAB IX : Kekuasaan Kehakiman");
            list.Add("BAB IXA : Wilayah Negara");
            list.Add("BAB X : Warga Negara dan Penduduk");
            list.Add("BAB XA : Hak Asasi Manusia");
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

        }
    }
}