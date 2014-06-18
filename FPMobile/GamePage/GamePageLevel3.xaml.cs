using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Coding4Fun.Toolkit.Controls;
using FPMobile.Class;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Microsoft.Phone.Tasks;

namespace FPMobile
{
    public partial class GamePageLevel3 : PhoneApplicationPage
    {
        public string name, regions = null;
        public int lastLevel;
        public int localScore = 0;
        UsersContext db;

        public GamePageLevel3()
        {
            InitializeComponent();
        }

        // called when page loaded
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            // init database
            db = new UsersContext("isostore:/Users.sdf");

            // ambil parsingan dr page sebelumnya, nama region yg dimasukin
            regions = NavigationContext.QueryString["region"].ToString();
            bool flagRegional = false;

            // ambil parsingan nama dan last level
            name = NavigationContext.QueryString["name"].ToString();
            lastLevel = Convert.ToInt32(NavigationContext.QueryString["lastLevel"].ToString());

            if (regions == "sulut")
            {
                // ganti backgroundnya semua pivot
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Images/Level3/sulut.png", UriKind.Relative));
                pivot1.ImageSource = bi;

                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Images/Level3/sulut-soal15.png", UriKind.Relative));
                pivot2.ImageSource = bi2;

                BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Images/Level3/sulut-soal16.png", UriKind.Relative));
                pivot3.ImageSource = bi3;

                // ganti jawabannya
                btnA.Content = "32 ayat 1";
                btnB.Content = "28 ayat 2";
                btnC.Content = "28F ayat 1";
                btnD.Content = "28H ayat 1";
                btn2A.Content = "37 ayat 1";
                btn2B.Content = "20 ayat 2";
                btn2C.Content = "28C ayat 1";
                btn2D.Content = "19 ayat 3";

                // ambil di database apa dia udah jawab soal di region ini apa belum
                var temp = from all in db.user
                           where all.Name == name
                           select all.RegionSulut;
                foreach (var item in temp)
                {
                    flagRegional = item;
                }

                // kalo dia sudah nyampe lvl 2 dan belum jawab region ini, tombol enable semua
                if (lastLevel == 3 && flagRegional != true)
                {
                    btnGO.IsEnabled = true;
                    btnA.IsEnabled = true;
                    btnB.IsEnabled = true;
                    btnC.IsEnabled = true;
                    btnD.IsEnabled = true;
                    btn2A.IsEnabled = true;
                    btn2B.IsEnabled = true;
                    btn2C.IsEnabled = true;
                    btn2D.IsEnabled = true;

                    // reset local score per region
                    localScore = 0;
                }

            }
            else if (regions == "sulteng")
            {
                // ganti backgroundnya semua pivot
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Images/Level3/sulteng.png", UriKind.Relative));
                pivot1.ImageSource = bi;

                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Images/Level3/sulteng-soal17.png", UriKind.Relative));
                pivot2.ImageSource = bi2;

                BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Images/Level3/sulteng-soal18.png", UriKind.Relative));
                pivot3.ImageSource = bi3;

                // ganti jawabannya
                btnA.Content = "28D ayat 1";
                btnB.Content = "28 ayat 2";
                btnC.Content = "30 ayat 1";
                btnD.Content = "16 ayat 1";
                btn2A.Content = "7 ayat 1";
                btn2B.Content = "27 ayat 2";
                btn2C.Content = "29 ayat 1";
                btn2D.Content = "14 ayat 3";

                // ambil di database apa dia udah jawab soal di region ini apa belum
                var temp = from all in db.user
                           where all.Name == name
                           select all.RegionSulteng;
                foreach (var item in temp)
                {
                    flagRegional = item;
                }

                // kalo dia sudah nyampe lvl 2 dan belum jawab region ini, tombol enable semua
                if (lastLevel == 3 && flagRegional != true)
                {
                    btnGO.IsEnabled = true;
                    btnA.IsEnabled = true;
                    btnB.IsEnabled = true;
                    btnC.IsEnabled = true;
                    btnD.IsEnabled = true;
                    btn2A.IsEnabled = true;
                    btn2B.IsEnabled = true;
                    btn2C.IsEnabled = true;
                    btn2D.IsEnabled = true;

                    // reset local score per region
                    localScore = 0;
                }
            }
            else if (regions == "sulsel")
            {
                // ganti backgroundnya semua pivot
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Images/Level3/sulsel.png", UriKind.Relative));
                pivot1.ImageSource = bi;

                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Images/Level3/sulsel-soal19.png", UriKind.Relative));
                pivot2.ImageSource = bi2;

                BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Images/Level3/sulsel-soal20.png", UriKind.Relative));
                pivot3.ImageSource = bi3;

                // ganti jawabannya
                btnA.Content = "29 ayat 2";
                btnB.Content = "28 ayat 2";
                btnC.Content = "31 ayat 1";
                btnD.Content = "33 ayat 1";
                btn2A.Content = "8 ayat 1";
                btn2B.Content = "20 ayat 2";
                btn2C.Content = "22E ayat 1";
                btn2D.Content = "17 ayat 3";

                // ambil di database apa dia udah jawab soal di region ini apa belum
                var temp = from all in db.user
                           where all.Name == name
                           select all.RegionSulsel;
                foreach (var item in temp)
                {
                    flagRegional = item;
                }

                // kalo dia sudah nyampe lvl 2 dan belum jawab region ini, tombol enable semua
                if (lastLevel == 3 && flagRegional != true)
                {
                    btnGO.IsEnabled = true;
                    btnA.IsEnabled = true;
                    btnB.IsEnabled = true;
                    btnC.IsEnabled = true;
                    btnD.IsEnabled = true;
                    btn2A.IsEnabled = true;
                    btn2B.IsEnabled = true;
                    btn2C.IsEnabled = true;
                    btn2D.IsEnabled = true;

                    // reset local score per region
                    localScore = 0;
                }
            }
            else if (regions == "sultenggara")
            {
                // ganti backgroundnya semua pivot
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Images/Level3/sultenggara.png", UriKind.Relative));
                pivot1.ImageSource = bi;

                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Images/Level3/sultenggara-soal21.png", UriKind.Relative));
                pivot2.ImageSource = bi2;

                BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Images/Level3/sultenggara-soal22.png", UriKind.Relative));
                pivot3.ImageSource = bi3;

                // ganti jawabannya
                btnA.Content = "19 ayat 2";
                btnB.Content = "28D ayat 1";
                btnC.Content = "13 ayat 1";
                btnD.Content = "26 ayat 2";
                btn2A.Content = "8 ayat 1";
                btn2B.Content = "20 ayat 2";
                btn2C.Content = "22E ayat 1";
                btn2D.Content = "17 ayat 3";

                // ambil di database apa dia udah jawab soal di region ini apa belum
                var temp = from all in db.user
                           where all.Name == name
                           select all.RegionSultenggara;
                foreach (var item in temp)
                {
                    flagRegional = item;
                }

                // kalo dia sudah nyampe lvl 2 dan belum jawab region ini, tombol enable semua
                if (lastLevel == 3 && flagRegional != true)
                {
                    btnGO.IsEnabled = true;
                    btnA.IsEnabled = true;
                    btnB.IsEnabled = true;
                    btnC.IsEnabled = true;
                    btnD.IsEnabled = true;
                    btn2A.IsEnabled = true;
                    btn2B.IsEnabled = true;
                    btn2C.IsEnabled = true;
                    btn2D.IsEnabled = true;

                    // reset local score per region
                    localScore = 0;
                }
            }

            // ganti nama, skor, jumlah hint di UI
            UIname.Text = name;
            try
            {
                int skor = 0;
                var scores = from all in db.user
                             where all.Name == name
                             select all.Score;
                foreach (var temps in scores)
                {
                    skor = temps;
                }
                UIScore.Text = skor.ToString();
                int hint = 0;
                var hints = from all in db.user
                            where all.Name == name
                            select all.Hint;
                foreach (var temps in hints)
                {
                    hint = temps;
                }
                UIHint.Text = hint.ToString();
            }
            catch { }
        }

        // go to first pivot when enter
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyPivot.SelectedIndex = 1;
        }

        // kalo jawaban salah
        private void WrongAnswer()
        {
            // jawab salah, skor - 50
            localScore -= 25;

            var messagePrompt = new MessagePrompt
            {
                Title = "Wrong Answer",
                Message = "Sorry, your answer is wrong"
            };
            messagePrompt.Show();
        }

        // question 1 - true for sulteng & sulsel
        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "sulteng" || regions == "sulsel")
            {
                btnA.IsEnabled = false;
                btnB.IsEnabled = false;
                btnC.IsEnabled = false;
                btnD.IsEnabled = false;

                // jawab bener, skor + 100
                localScore += 100;

                var messagePrompt = new MessagePrompt
                {
                    Title = "Correct",
                    Message = "You answered correctly"
                };
                messagePrompt.Completed += messagePrompt_Completed2;
                messagePrompt.Show();
            }
            else
            {
                WrongAnswer();
            }
        }

        // question 1 - true for sultenggara
        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "sultenggara")
            {
                btnA.IsEnabled = false;
                btnB.IsEnabled = false;
                btnC.IsEnabled = false;
                btnD.IsEnabled = false;

                // jawab bener, skor + 100
                localScore += 100;

                var messagePrompt = new MessagePrompt
                {
                    Title = "Correct",
                    Message = "You answered correctly"
                };
                messagePrompt.Completed += messagePrompt_Completed2;
                messagePrompt.Show();
            }
            else
            {
                WrongAnswer();
            }
        }

        // question 1 - wrong
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // question 1 - true for sulut
        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "sulut")
            {
                btnA.IsEnabled = false;
                btnB.IsEnabled = false;
                btnC.IsEnabled = false;
                btnD.IsEnabled = false;

                // jawab bener, skor + 100
                localScore += 100;

                var messagePrompt = new MessagePrompt
                {
                    Title = "Correct",
                    Message = "You answered correctly"
                };
                messagePrompt.Completed += messagePrompt_Completed2;
                messagePrompt.Show();
            }
            else
            {
                WrongAnswer();
            }
        }

        // question 2 - wrong answer
        private void btn2A_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // question 2 - true for sulteng
        private void btn2B_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "sulteng")
            {
                // jawaban bener, skor + 100
                localScore += 100;
                var messagePrompt = new MessagePrompt
                {
                    Title = "Congratulations",
                    Message = "You have finished this region and gained " + localScore + " points! Next region is unlocked."
                };
                messagePrompt.Completed += messagePrompt_Completed;
                messagePrompt.Show();
                btn2A.IsEnabled = false;
                btn2B.IsEnabled = false;
                btn2C.IsEnabled = false;
                btn2D.IsEnabled = false;
                //btnGO.BorderBrush = null;

                // update skor ke database
                Users user = db.user.Single(p => p.Name == name);
                user.RegionSulteng = true;
                //user.LastLevel = 2;
                user.Score += localScore;
                try
                {
                    db.SubmitChanges();
                }
                catch
                {

                }
            }
            else
            {
                WrongAnswer();
            }
        }

        // question 2 - true for sulut & sulsel
        private void btn2C_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "sulut")
            {
                // jawaban bener, skor + 100
                localScore += 100;
                var messagePrompt = new MessagePrompt
                {
                    Title = "Congratulations",
                    Message = "You have finished this region and gained " + localScore + " points! Next region is unlocked."
                };
                messagePrompt.Completed += messagePrompt_Completed;
                messagePrompt.Show();
                btn2A.IsEnabled = false;
                btn2B.IsEnabled = false;
                btn2C.IsEnabled = false;
                btn2D.IsEnabled = false;
                //btnGO.BorderBrush = null;

                // update skor ke database
                Users user = db.user.Single(p => p.Name == name);
                user.RegionSulut = true;
                //user.LastLevel = 2;
                user.Score += localScore;
                try
                {
                    db.SubmitChanges();
                }
                catch
                {

                }
            }
            else if (regions == "sulsel")
            {
                // jawaban bener, skor + 100
                localScore += 100;
                var messagePrompt = new MessagePrompt
                {
                    Title = "Congratulations",
                    Message = "You have finished this region and gained " + localScore + " points! Next region is unlocked."
                };
                messagePrompt.Completed += messagePrompt_Completed;
                messagePrompt.Show();
                btn2A.IsEnabled = false;
                btn2B.IsEnabled = false;
                btn2C.IsEnabled = false;
                btn2D.IsEnabled = false;
                //btnGO.BorderBrush = null;

                // update skor ke database
                Users user = db.user.Single(p => p.Name == name);
                user.RegionSulsel = true;
                //user.LastLevel = 2;
                user.Score += localScore;
                try
                {
                    db.SubmitChanges();
                }
                catch
                {

                }
            }
            else
            {
                WrongAnswer();
            }
        }

        // question 2 - wrong
        private void btn2D_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // back to select region / level
        void messagePrompt_Completed(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            bool flag1 = false, flag2 = false, flag3 = false, flag4 = false;
            var temp = from all in db.user
                       where all.Name == name
                       select all.RegionSulut;
            foreach (var item in temp)
            {
                flag1 = item;
            }
            var temp2 = from all in db.user
                        where all.Name == name
                        select all.RegionSulteng;
            foreach (var item in temp2)
            {
                flag2 = item;
            }
            var temp3 = from all in db.user
                        where all.Name == name
                        select all.RegionSulsel;
            foreach (var item in temp3)
            {
                flag3 = item;
            }
            var temp4 = from all in db.user
                        where all.Name == name
                        select all.RegionSultenggara;

            if (flag1 == true && flag2 == true && flag3 == true && flag4 == true)
            {
                //Users user = db.user.Single(p => p.Name == name);
                //user.LastLevel = 4;
                //lastLevel = 4;
                //try
                //{
                //    db.SubmitChanges();
                //}
                //catch
                //{

                //}
                var messagePrompt = new MessagePrompt
                {
                    Title = "Level Completed",
                    Message = "Congratulations, you have finished the last level, stay tune and more level will be unlocked! We would love to hear your opinion of this game, would you like to rate this app?"
                };
                messagePrompt.Completed += messagePrompt_Completed3;
                messagePrompt.Show();
            }
            else
            {
                NavigationService.GoBack();
            }
        }

        void messagePrompt_Completed3(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            switch (e.PopUpResult)
            {
                case PopUpResult.Cancelled:
                    NavigationService.Navigate(new Uri("/selectLevel.xaml?mode=back&name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
                    break;
                case PopUpResult.Ok:
                    MarketplaceReviewTask rate = new MarketplaceReviewTask();
                    rate.Show();
                    NavigationService.Navigate(new Uri("/selectLevel.xaml?mode=back&name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
                    break;
                case PopUpResult.UserDismissed:
                    break;
                default:
                    break;
            }
        }

        // go to next question
        private void messagePrompt_Completed2(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            MyPivot.SelectedIndex = 2;
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