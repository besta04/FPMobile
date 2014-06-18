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
    public partial class selectLevel : PhoneApplicationPage
    {
        public string name;
        public int lastLevel;
        int selectedLevel;
        UsersContext db;

        public selectLevel()
        {
            InitializeComponent();
        }

        private void Navigate()
        {
            NavigationService.Navigate(new Uri("/playRegion.xaml?level=" + selectedLevel + "&name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            db = new UsersContext("isostore:/Users.sdf");
            if (!db.DatabaseExists())
            {
                db.CreateDatabase();
            }

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

            if (lastLevel == 2)
            {
                btnLvl2.IsHitTestVisible = true;
                btnLvl2.Opacity = 100;
                gembok2.Visibility = Visibility.Collapsed;
            }
            else if (lastLevel == 3)
            {
                btnLvl2.IsHitTestVisible = true;
                btnLvl3.IsHitTestVisible = true;
                btnLvl2.Opacity = 100;
                btnLvl3.Opacity = 100;
                gembok2.Visibility = Visibility.Collapsed;
                gembok3.Visibility = Visibility.Collapsed;
            }
            else if (lastLevel == 4)
            {
                btnLvl2.IsHitTestVisible = true;
                btnLvl3.IsHitTestVisible = true;
                btnLvl4.IsHitTestVisible = true;
                btnLvl2.Opacity = 100;
                btnLvl3.Opacity = 100;
                btnLvl4.Opacity = 100;
                gembok2.Visibility = Visibility.Collapsed;
                gembok3.Visibility = Visibility.Collapsed;
                gembok4.Visibility = Visibility.Collapsed;
            }
            else if (lastLevel == 5)
            {
                btnLvl2.IsHitTestVisible = true;
                btnLvl3.IsHitTestVisible = true;
                btnLvl4.IsHitTestVisible = true;
                btnLvl5.IsHitTestVisible = true;
                btnLvl2.Opacity = 100;
                btnLvl3.Opacity = 100;
                btnLvl4.Opacity = 100;
                btnLvl5.Opacity = 100;
                gembok2.Visibility = Visibility.Collapsed;
                gembok3.Visibility = Visibility.Collapsed;
                gembok4.Visibility = Visibility.Collapsed;
                gembok5.Visibility = Visibility.Collapsed;
            }
            else if (lastLevel == 6)
            {
                btnLvl2.IsHitTestVisible = true;
                btnLvl3.IsHitTestVisible = true;
                btnLvl4.IsHitTestVisible = true;
                btnLvl5.IsHitTestVisible = true;
                btnLvl6.IsHitTestVisible = true;
                btnLvl2.Opacity = 100;
                btnLvl3.Opacity = 100;
                btnLvl4.Opacity = 100;
                btnLvl5.Opacity = 100;
                btnLvl6.Opacity = 100;
                gembok2.Visibility = Visibility.Collapsed;
                gembok3.Visibility = Visibility.Collapsed;
                gembok4.Visibility = Visibility.Collapsed;
                gembok5.Visibility = Visibility.Collapsed;
                gembok6.Visibility = Visibility.Collapsed;
            }

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

        private void Button_Click(object sender, System.Windows.Input.GestureEventArgs e)
        {
            selectedLevel = 1;
            Navigate();
        }

        private void Button_Click_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            selectedLevel = 2;
            Navigate();
        }

        private void Button_Click_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            selectedLevel = 3;
            Navigate();
        }

        private void Button_Click_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            selectedLevel = 4;
            Navigate();
        }

        private void Button_Click_4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            selectedLevel = 5;
            Navigate();
        }

        private void Button_Click_5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            selectedLevel = 6;
            Navigate();
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