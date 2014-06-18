using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FPMobile.Class;

namespace FPMobile
{
    public partial class playRegion : PhoneApplicationPage
    {
        public string name;
        public int lastLevel;
        UsersContext db;

        public playRegion()
        {
            InitializeComponent();
        }

        private void AddRegion(int level)
        {
            List<string> region = new List<string>();
            region.Clear();
            if (level == 1)
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
                region.Add("Sulawesi Utara");
                region.Add("Sulawesi Tengah");
                region.Add("Sulawesi Selatan");
                region.Add("Sulawesi Tenggara");
            }
            else if (level == 4)
            {
                region.Add("Bali");
                region.Add("NTB");
                region.Add("NTT");
            }
            else if (level == 5)
            {
                region.Add("Kalimantan Barat");
                region.Add("Kalimantan Tengah");
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
            db = new UsersContext("isostore:/Users.sdf");
            if (!db.DatabaseExists())
            {
                db.CreateDatabase();
            }

            int levels = Convert.ToInt32(NavigationContext.QueryString["level"].ToString());
            AddRegion(levels);
            name = NavigationContext.QueryString["name"].ToString();
            lastLevel = Convert.ToInt32(NavigationContext.QueryString["lastLevel"].ToString());

            // ganti nama, skor, jumlah hint di UI
            UIname.Text = name;
            try
            {
                int skor = 0;
                var scores = from all in db.user
                             where all.Name == name
                             select all.Score;
                foreach (var temp in scores)
                {
                    skor = temp;
                }
                UIScore.Text = skor.ToString();
                int hint = 0;
                var hints = from all in db.user
                            where all.Name == name
                            select all.Hint;
                foreach (var temp in hints)
                {
                    hint = temp;
                }
                UIHint.Text = hint.ToString();
            }
            catch { }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(myLst.SelectedItem.ToString());
            if (myLst.SelectedItem.ToString() == "D.I. Aceh")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageLevel1.xaml?name=" + name + "&lastLevel=" + lastLevel + "&region=aceh", UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Sumatera Utara")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageLevel1.xaml?name=" + name + "&lastLevel=" + lastLevel + "&region=sumut", UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Riau")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageLevel1.xaml?name=" + name + "&lastLevel=" + lastLevel + "&region=riau", UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Sumatera Selatan")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageLevel1.xaml?name=" + name + "&lastLevel=" + lastLevel + "&region=sumsel", UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "DKI Jakarta")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageLevel2.xaml?name=" + name + "&lastLevel=" + lastLevel + "&region=jakarta", UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Jawa Tengah")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageLevel2.xaml?name=" + name + "&lastLevel=" + lastLevel + "&region=jateng", UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Jawa Timur")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageLevel2.xaml?name=" + name + "&lastLevel=" + lastLevel + "&region=jatim", UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Sulawesi Utara")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageLevel3.xaml?name=" + name + "&lastLevel=" + lastLevel + "&region=sulut", UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Sulawesi Tengah")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageLevel3.xaml?name=" + name + "&lastLevel=" + lastLevel + "&region=sulteng", UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Sulawesi Selatan")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageLevel3.xaml?name=" + name + "&lastLevel=" + lastLevel + "&region=sulsel", UriKind.RelativeOrAbsolute));
            }
            else if (myLst.SelectedItem.ToString() == "Sulawesi Tenggara")
            {
                NavigationService.Navigate(new Uri("/GamePage/GamePageLevel3.xaml?name=" + name + "&lastLevel=" + lastLevel + "&region=sultenggara", UriKind.RelativeOrAbsolute));
            }
        }

        // hint pressed
        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int hint = Convert.ToInt32(UIHint.Text);
            if (hint > 0)
            {
                hint--;
                Users user = db.user.Single(p => p.Name == name);
                user.Hint = hint;
                try
                {
                    db.SubmitChanges();
                }
                catch { }
                NavigationService.Navigate(new Uri("/UUDIndex.xaml", UriKind.Relative));
            }
        }
    }
}