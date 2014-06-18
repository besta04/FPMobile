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

namespace FPMobile
{
    public partial class GamePageLevel2 : PhoneApplicationPage
    {
        public string name, regions = null;
        public int lastLevel;
        public int localScore = 0;
        UsersContext db;

        public GamePageLevel2()
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

            if (regions == "jakarta")
            {
                // ganti backgroundnya semua pivot
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Images/Level2/jakarta.png", UriKind.Relative));
                pivot1.ImageSource = bi;

                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Images/Level2/jakarta-soal9.png", UriKind.Relative));
                pivot2.ImageSource = bi2;

                BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Images/Level2/jakarta-soal10.png", UriKind.Relative));
                pivot3.ImageSource = bi3;

                // ganti jawabannya
                btnA.Content = "30 ayat 1";
                btnB.Content = "30 ayat 4";
                btnC.Content = "29 ayat 1";
                btnD.Content = "pasal 35";
                btn2A.Content = "27 ayat 1";
                btn2B.Content = "25 ayat 2";
                btn2C.Content = "26 ayat 2";
                btn2D.Content = "19 ayat 2";

                // ambil di database apa dia udah jawab soal di region ini apa belum
                var temp = from all in db.user
                           where all.Name == name
                           select all.RegionJakarta;
                foreach (var item in temp)
                {
                    flagRegional = item;
                }

                // kalo dia sudah nyampe lvl 2 dan belum jawab region ini, tombol enable semua
                if (lastLevel == 2 && flagRegional != true)
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
            else if (regions == "jateng")
            {
                // ganti backgroundnya semua pivot
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Images/Level2/jateng.png", UriKind.Relative));
                pivot1.ImageSource = bi;

                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Images/Level2/jateng-soal11.png", UriKind.Relative));
                pivot2.ImageSource = bi2;

                BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Images/Level2/jateng-soal12.png", UriKind.Relative));
                pivot3.ImageSource = bi3;

                // ganti jawabannya
                btnA.Content = "28D ayat 2";
                btnB.Content = "pasal 10";
                btnC.Content = "19 ayat 1";
                btnD.Content = "28C ayat 1";
                btn2A.Content = "pasal 6A";
                btn2B.Content = "pasal 6B";
                btn2C.Content = "11 ayat 1";
                btn2D.Content = "31 ayat 2";

                // ambil di database apa dia udah jawab soal di region ini apa belum
                var temp = from all in db.user
                           where all.Name == name
                           select all.RegionJateng;
                foreach (var item in temp)
                {
                    flagRegional = item;
                }

                // kalo dia sudah nyampe lvl 2 dan belum jawab region ini, tombol enable semua
                if (lastLevel == 2 && flagRegional != true)
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
            else if (regions == "jatim")
            {
                // ganti backgroundnya semua pivot
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Images/Level2/jatim.png", UriKind.Relative));
                pivot1.ImageSource = bi;

                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Images/Level2/jatim-soal13.png", UriKind.Relative));
                pivot2.ImageSource = bi2;

                BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Images/Level2/jatim-soal14.png", UriKind.Relative));
                pivot3.ImageSource = bi3;

                // ganti jawabannya
                btnA.Content = "28C ayat 2";
                btnB.Content = "28 ayat 1";
                btnC.Content = "29 ayat 2";
                btnD.Content = "18 ayat 1";
                btn2A.Content = "19 ayat 1";
                btn2B.Content = "18 ayat 6";
                btn2C.Content = "18 ayat 5";
                btn2D.Content = "20 ayat 2";

                // ambil di database apa dia udah jawab soal di region ini apa belum
                var temp = from all in db.user
                           where all.Name == name
                           select all.RegionJatim;
                foreach (var item in temp)
                {
                    flagRegional = item;
                }

                // kalo dia sudah nyampe lvl 2 dan belum jawab region ini, tombol enable semua
                if (lastLevel == 2 && flagRegional != true)
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

        // question 1 - wrong
        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // question 1 - true for jakarta
        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "jakarta")
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

        // question 1 - true for jatim
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "jatim")
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

        // question 1 - true for jateng
        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "jateng")
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

        // question 2 - true for jateng
        private void btn2A_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "jateng")
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

                // update skor ke database
                Users user = db.user.Single(p => p.Name == name);
                user.RegionJateng = true;
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

        // question 2 - true for jatim
        private void btn2B_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "jatim")
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

                // update skor ke database
                Users user = db.user.Single(p => p.Name == name);
                user.RegionJatim = true;
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

        // question 2 - true for jakarta
        private void btn2C_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "jakarta")
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
                user.RegionJakarta = true;
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
            bool flag1 = false, flag2 = false, flag3 = false;
            var temp = from all in db.user
                       where all.Name == name
                       select all.RegionJakarta;
            foreach (var item in temp)
            {
                flag1 = item;
            }
            var temp2 = from all in db.user
                        where all.Name == name
                        select all.RegionJateng;
            foreach (var item in temp2)
            {
                flag2 = item;
            }
            var temp3 = from all in db.user
                        where all.Name == name
                        select all.RegionJatim;
            foreach (var item in temp3)
            {
                flag3 = item;
            }

            if (flag1 == true && flag2 == true && flag3 == true)
            {
                Users user = db.user.Single(p => p.Name == name);
                user.LastLevel = 3;
                lastLevel = 3;
                try
                {
                    db.SubmitChanges();
                }
                catch
                {

                }
                NavigationService.Navigate(new Uri("/selectLevel.xaml?mode=back&name=" + name + "&lastLevel=" + lastLevel, UriKind.RelativeOrAbsolute));
            }
            else
            {
                NavigationService.GoBack();
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