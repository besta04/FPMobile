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

namespace FPMobile
{
    public partial class MainPage : PhoneApplicationPage
    {
        public string name;
        public int lastLevel;
        UsersContext db;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // New Game
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InputPrompt input = new InputPrompt();
            input.Title = "Your Name";
            input.Message = "Please input your name";
            input.Completed +=input_Completed;
            input.IsCancelVisible = true;
            input.Show();
        }

        void input_Completed(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            Users user = new Users
            {
                Name = e.Result,
                LastLevel = 1,
                Score = 0,
                RegionAceh = false,
                RegionRiau = false,
                RegionSumsel = false,
                RegionSumut = false
            };
            db.user.InsertOnSubmit(user);
            try
            {
                db.SubmitChanges();
                var messagePrompt = new MessagePrompt
                {
                    Title = "Success",
                    Message = "Welcome " + e.Result
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

        // Play
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            name = myLst.SelectedItem.ToString();
            var temp = from all in db.user
                       where all.Name == name
                       select all.LastLevel;
            foreach(var item in temp)
            {
                lastLevel += item;
            }
            NavigationService.Navigate(new Uri("/selectLevel.xaml?name=" + name + "&lastLevel=" + lastLevel.ToString(), UriKind.RelativeOrAbsolute));
        }

        // Instruction
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            db = new UsersContext("isostore:/Users.sdf");
            if(!db.DatabaseExists())
            {
                db.CreateDatabase();
            }

            Refresh();            
        }

        private void Refresh()
        {
            var item = from all in db.user
                       select all.Name;
            myLst.ItemsSource = item;
        }
    }
}