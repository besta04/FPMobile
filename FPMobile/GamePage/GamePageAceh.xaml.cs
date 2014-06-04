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

namespace FPMobile
{
    public partial class GamePage : PhoneApplicationPage
    {
        public string name;
        public int lastLevel;
        public int localScore = 0;
        UsersContext db;

        public GamePage()
        {
            InitializeComponent();
        }

        private void Pivot_Loaded(object sender, RoutedEventArgs e)
        {

        }

        // trueAnswer - 1
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/GamePage/GamePageAceh.xaml?PivotMain.SelectedIndex = 0", UriKind.Relative));
            MyPivot.SelectedIndex = 2;
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
            messagePrompt.Show();

            // go to next question
            MyPivot.SelectedIndex = 2;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyPivot.SelectedIndex = 1;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            db = new UsersContext("isostore:/Users.sdf");

            bool regAceh = false;
            //int test = 0;
            name = NavigationContext.QueryString["name"].ToString();
            //MessageBox.Show(name);
            lastLevel = Convert.ToInt32(NavigationContext.QueryString["lastLevel"].ToString());
            var temp = from all in db.user
                       where all.Name == name
                       select all.RegionAceh;
            foreach(var item in temp)
            {
                regAceh = item;
                //test = item;
            }
            //MessageBox.Show(regAceh.ToString());
            if(lastLevel == 1 && regAceh != true)
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
            }
        }

        
        // trueAnswer - 2
        private void btn2B_Click(object sender, RoutedEventArgs e)
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
            //user.LastLevel = 2;
            user.Score = localScore;
            try
            {
                db.SubmitChanges();
            }
            catch
            {

            }

            // back to select region
            //NavigationService.Navigate(new Uri("/playRegion.xaml", UriKind.RelativeOrAbsolute));
            //NavigationService.GoBack();
        }

        void messagePrompt_Completed(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            NavigationService.GoBack();
        }

        // kalo jawaban salah
        private void WrongAnswer()
        {
            // jawab salah, skor - 50
            localScore -= 50;

            var messagePrompt = new MessagePrompt
            {
                Title = "Wrong Answer",
                Message = "Sorry, your answer is wrong"
            };
            messagePrompt.Show();
        }

        // wrong answer - 1
        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // wrong answe - 1
        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // wrong answer - 1
        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // wrong answer - 2
        private void btn2A_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // wrong answer - 2
        private void btn2C_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // wrong answer - 2
        private void btn2D_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }
    }
}