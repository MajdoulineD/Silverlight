using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TelerikSilverlightApp1
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            var correct_login = "admin";
            var correct_pass = "admin";
            var correct = true;
            if (login.Text != correct_login)
            {
                login_err.Text = "* Login incorrect!";
                login.Background = (new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)));
                correct = false;
            }
            else
            {
                login_err.Text = "";
                login.Background = (new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)));
                correct &= true;
            }
            if (motdepasse.Password != correct_pass)
            {
                pass_err.Text = "* Mot de passe incorrect!";
                motdepasse.Background = (new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)));
                correct = false;
            }
            else
            {
                pass_err.Text = "";
                motdepasse.Background = (new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)));
                correct &= true;
            }

            if (correct)
            {
                MenuPage t = new MenuPage();
                this.Content = t;
            }

        }
    }
}
