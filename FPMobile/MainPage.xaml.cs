using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FPMobile.Resources;
using FPMobile.Class;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Coding4Fun.Toolkit.Controls;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Threading;

namespace FPMobile
{
    public partial class MainPage : PhoneApplicationPage
    {
        private Popup popup;
        private BackgroundWorker backroungWorker;
        public string name;
        public int lastLevel;
        UsersContext db;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ShowSplash();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // splash screen
        private void ShowSplash()
        {
            this.popup = new Popup();
            this.popup.Child = new SplashScreenControl();
            this.popup.IsOpen = true;
            StartLoadingData();
        }

        private void StartLoadingData()
        {
            backroungWorker = new BackgroundWorker();
            backroungWorker.DoWork += backroungWorker_DoWork;
            backroungWorker.RunWorkerCompleted += backroungWorker_RunWorkerCompleted;
            backroungWorker.RunWorkerAsync();
        }

        void backroungWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(() =>
            {
                this.popup.IsOpen = false;

            }
            );
        }

        void backroungWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //here we can load data
            Thread.Sleep(5000);
        }

        void inputPlayer(string name)
        {
            Users user = new Users
            {
                Name = name,
                LastLevel = 1,
                Score = 0,
                Hint = 3,
                RegionAceh = false,
                RegionRiau = false,
                RegionSumsel = false,
                RegionSumut = false,
                RegionJakarta = false,
                RegionJateng = false,
                RegionJatim = false,
                RegionSulut = false,
                RegionSulteng = false,
                RegionSulsel = false,
                RegionSultenggara = false
            };
            db.user.InsertOnSubmit(user);
            try
            {
                db.SubmitChanges();
                var messagePrompt = new MessagePrompt
                {
                    Title = "Success",
                    Message = "Welcome " + name
                };
                messagePrompt.Show();
            }
            catch (Exception ex)
            {
                var messagePrompt = new MessagePrompt
                {
                    Title = "Failed",
                    Message = "Name registration failed"
                };
                messagePrompt.Show();
            }
            Refresh();
            myLst.SelectedIndex = myLst.Items.Count - 1;
        }

        // New Game
        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            InputPrompt input = new InputPrompt();
            input.Title = "Your Name";
            input.Message = "Please input your name";
            input.Completed += input_Completed;
            input.IsCancelVisible = true;
            input.Show();
        }

        void input_Completed(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            switch (e.PopUpResult)
            {
                case PopUpResult.Cancelled:
                    break;
                case PopUpResult.Ok:
                    inputPlayer(e.Result);
                    break;
                case PopUpResult.UserDismissed:
                    break;
                default:
                    break;
            }
        }

        // Play
        private void Button_Click(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                name = myLst.SelectedItem.ToString();
                var temp = from all in db.user
                           where all.Name == name
                           select all.LastLevel;
                foreach (var item in temp)
                {
                    lastLevel = item;
                }
                NavigationService.Navigate(new Uri("/selectLevel.xaml?name=" + name + "&lastLevel=" + lastLevel.ToString(), UriKind.RelativeOrAbsolute));
            }
            catch
            {
                InputPrompt input = new InputPrompt();
                input.Title = "Your Name";
                input.Message = "Please input your name";
                input.Completed += input_Completed2;
                input.IsCancelVisible = true;
                input.Show();
            }
        }

        private void input_Completed2(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            switch (e.PopUpResult)
            {
                case PopUpResult.Cancelled:
                    break;
                case PopUpResult.NoResponse:
                    break;
                case PopUpResult.Ok:
                    inputPlayer(e.Result);
                    name = myLst.SelectedItem.ToString();
                    var temp = from all in db.user
                               where all.Name == name
                               select all.LastLevel;
                    foreach (var item in temp)
                    {
                        lastLevel = item;
                    }
                    NavigationService.Navigate(new Uri("/selectLevel.xaml?name=" + name + "&lastLevel=" + lastLevel.ToString(), UriKind.RelativeOrAbsolute));
                    break;
                case PopUpResult.UserDismissed:
                    break;
                default:
                    break;
            }
        }

        // Instruction
        private void Image_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UUDIndex.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            db = new UsersContext("isostore:/Users.sdf");
            if (!db.DatabaseExists())
            {
                db.CreateDatabase();
            }

            Refresh();
        }

        private void Refresh()
        {
            try
            {
                var item = from all in db.user
                           select all.Name;
                myLst.ItemsSource = item;
            }
            catch { }
        }

        // delete user
        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                var deletePlayer = from details in db.user
                                   where details.Name == myLst.SelectedItem.ToString()
                                   select details;

                foreach (var detail in deletePlayer)
                {
                    db.user.DeleteOnSubmit(detail);
                }
                db.SubmitChanges();
                Refresh();
            }
            catch
            {

            }
        }
    }
}