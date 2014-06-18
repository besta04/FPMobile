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
    public partial class GamePageLevel1 : PhoneApplicationPage
    {
        public string name, regions = null;
        public int lastLevel;
        public int localScore = 0;
        UsersContext db;

        public GamePageLevel1()
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

            if (regions == "aceh")
            {
                // ganti backgroundnya semua pivot
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Images/aceh.png", UriKind.Relative));
                pivot1.ImageSource = bi;

                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Images/soal1.png", UriKind.Relative));
                pivot2.ImageSource = bi2;

                BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Images/soal2.png", UriKind.Relative));
                pivot3.ImageSource = bi3;

                // ganti jawabannya
                btnA.Content = "19 ayat 1";
                btnB.Content = "25 ayat 2";
                btnC.Content = "31 ayat 2";
                btnD.Content = "31 ayat 1";
                btn2A.Content = "22 ayat 1";
                btn2B.Content = "pasal 35";
                btn2C.Content = "pasal 19";
                btn2D.Content = "pasal 33";

                // ambil di database apa dia udah jawab soal di region ini apa belum
                var temp = from all in db.user
                           where all.Name == name
                           select all.RegionAceh;
                foreach (var item in temp)
                {
                    flagRegional = item;
                }

                // kalo dia sudah nyampe lvl 2 dan belum jawab region ini, tombol enable semua
                if (lastLevel == 1 && flagRegional != true)
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
            else if (regions == "sumut")
            {
                // ganti backgroundnya semua pivot
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Images/sumut.png", UriKind.Relative));
                pivot1.ImageSource = bi;

                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Images/sumut-soal3.png", UriKind.Relative));
                pivot2.ImageSource = bi2;

                BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Images/sumut-soal4.png", UriKind.Relative));
                pivot3.ImageSource = bi3;

                // ganti jawabannya
                btnA.Content = "33 ayat 3";
                btnB.Content = "22 ayat 4";
                btnC.Content = "18 ayat 2";
                btnD.Content = "pasal 25";
                btn2A.Content = "20 ayat 1";
                btn2B.Content = "pasal 34";
                btn2C.Content = "19 ayat 2";
                btn2D.Content = "34 ayat 3";

                // ambil di database apa dia udah jawab soal di region ini apa belum
                var temp = from all in db.user
                           where all.Name == name
                           select all.RegionSumut;
                foreach (var item in temp)
                {
                    flagRegional = item;
                }

                // kalo dia sudah nyampe lvl 2 dan belum jawab region ini, tombol enable semua
                if (lastLevel == 1 && flagRegional != true)
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
            else if (regions == "riau")
            {
                // ganti backgroundnya semua pivot
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Images/riau.png", UriKind.Relative));
                pivot1.ImageSource = bi;

                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Images/riau - soal5.png", UriKind.Relative));
                pivot2.ImageSource = bi2;

                BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Images/riau - soal6.png", UriKind.Relative));
                pivot3.ImageSource = bi3;

                // ganti jawabannya
                btnA.Content = "33 ayat 3";
                btnB.Content = "31 ayat 1";
                btnC.Content = "22 ayat 2";
                btnD.Content = "34 ayat 2";
                btn2A.Content = "20 ayat 1";
                btn2B.Content = "28A ayat 2";
                btn2C.Content = "28H ayat 1";
                btn2D.Content = "28B ayat 1";

                // ambil di database apa dia udah jawab soal di region ini apa belum
                var temp = from all in db.user
                           where all.Name == name
                           select all.RegionRiau;
                foreach (var item in temp)
                {
                    flagRegional = item;
                }

                // kalo dia sudah nyampe lvl 2 dan belum jawab region ini, tombol enable semua
                if (lastLevel == 1 && flagRegional != true)
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
            else if (regions == "sumsel")
            {
                // ganti backgroundnya semua pivot
                BitmapImage bi = new BitmapImage(new Uri("/Assets/Images/sumsel.png", UriKind.Relative));
                pivot1.ImageSource = bi;

                BitmapImage bi2 = new BitmapImage(new Uri("/Assets/Images/sumsel - soal7.png", UriKind.Relative));
                pivot2.ImageSource = bi2;

                BitmapImage bi3 = new BitmapImage(new Uri("/Assets/Images/sumsel - soal8.png", UriKind.Relative));
                pivot3.ImageSource = bi3;

                // ganti jawabannya
                btnA.Content = "33 ayat 3";
                btnB.Content = "31 ayat 1";
                btnC.Content = "22 ayat 2";
                btnD.Content = "34 ayat 2";
                btn2A.Content = "20 ayat 1";
                btn2B.Content = "pasal 34";
                btn2C.Content = "19 ayat 2";
                btn2D.Content = "34 ayat 2";

                // ambil di database apa dia udah jawab soal di region ini apa belum
                var temp = from all in db.user
                           where all.Name == name
                           select all.RegionSumsel;
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

        // question 1 - true for sumut & riau
        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "sumut" || regions == "riau")
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

        // question 1 - true for sumsel
        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "sumsel")
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

        // question 1 - true for aceh
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "aceh")
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
        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // question 2 - wrong
        private void btn2A_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // question 2 - true for aceh
        private void btn2B_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "aceh")
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
                user.RegionAceh = true;
                user.Hint++;
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

        // question 2 - true for riau
        private void btn2C_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "riau")
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
                user.RegionRiau = true;
                user.Hint++;
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

        // question 2 - true for sumut & sumsel
        private void btn2D_Click(object sender, RoutedEventArgs e)
        {
            if (regions == "sumut")
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
                user.RegionSumut = true;
                user.Hint++;
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
            else if (regions == "sumsel")
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
                user.RegionSumsel = true;
                user.Hint++;
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

        // back to select region / level
        void messagePrompt_Completed(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            bool flag1 = false, flag2 = false, flag3 = false, flag4 = false;
            var temp = from all in db.user
                       where all.Name == name
                       select all.RegionAceh;
            foreach (var item in temp)
            {
                flag1 = item;
            }
            var temp2 = from all in db.user
                        where all.Name == name
                        select all.RegionSumut;
            foreach (var item in temp2)
            {
                flag2 = item;
            }
            var temp3 = from all in db.user
                        where all.Name == name
                        select all.RegionRiau;
            foreach (var item in temp3)
            {
                flag3 = item;
            }
            var temp4 = from all in db.user
                        where all.Name == name
                        select all.RegionSumsel;
            foreach (var item in temp4)
            {
                flag4 = item;
            }

            if (flag1 == true && flag2 == true && flag3 == true && flag4 == true)
            {
                Users user = db.user.Single(p => p.Name == name);
                user.LastLevel = 2;
                lastLevel = 2;
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