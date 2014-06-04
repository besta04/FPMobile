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
    public partial class GamePageSumsel : PhoneApplicationPage
    {
        public string name;
        public int lastLevel;
        public int localScore = 0;
        UsersContext db;

        public GamePageSumsel()
        {
            InitializeComponent();
        }

        // called when page loaded
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            db = new UsersContext("isostore:/Users.sdf");

            bool regSumsel = false;
            name = NavigationContext.QueryString["name"].ToString();
            lastLevel = Convert.ToInt32(NavigationContext.QueryString["lastLevel"].ToString());
            var temp = from all in db.user
                       where all.Name == name
                       select all.RegionSumsel;
            foreach (var item in temp)
            {
                regSumsel = item;
            }
            if (lastLevel == 1 && regSumsel != true)
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

        // go to first pivot when enter
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyPivot.SelectedIndex = 1;
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

        // question 1 - wrong
        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // question 1 - true
        private void btnB_Click(object sender, RoutedEventArgs e)
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

        // question 1 - wrong
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // question 1 - true
        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // question 2 - wrong
        private void btn2A_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // question 2 - wrong
        private void btn2B_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // question 2 - wrong
        private void btn2C_Click(object sender, RoutedEventArgs e)
        {
            WrongAnswer();
        }

        // question 2 - true
        private void btn2D_Click(object sender, RoutedEventArgs e)
        {
            // jawaban bener, skor + 100
            localScore += 100;
            var messagePrompt = new MessagePrompt
            {
                Title = "Congratulations",
                Message = "You have finished this region and gained " + localScore + " points! Go to next level."
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
            user.LastLevel = 2;
            user.Score += localScore;
            try
            {
                db.SubmitChanges();
            }
            catch
            {

            }
        }

        // back to select level
        void messagePrompt_Completed(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            NavigationService.Navigate(new Uri("/selectLevel.xaml?mode=back", UriKind.RelativeOrAbsolute));
        }

        // go to next question
        private void messagePrompt_Completed2(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            MyPivot.SelectedIndex = 2;
        }
    }
}