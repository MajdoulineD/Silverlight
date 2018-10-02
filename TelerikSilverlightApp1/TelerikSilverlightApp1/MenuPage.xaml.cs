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
using System.Windows.Navigation;

namespace TelerikSilverlightApp1
{
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void fstats_Click(object sender, RoutedEventArgs e)
        {
            TelerikScenario1 stats = new TelerikScenario1();
            this.Content = stats;
        }

        private void studentslist_Click(object sender, RoutedEventArgs e)
        {
            TelerikScenario2 s = new TelerikScenario2();
            this.Content = s;
        }

        private void studentsfilieres_Click(object sender, RoutedEventArgs e)
        {
            StudentsParFiliere sp = new StudentsParFiliere();
            this.Content = sp;
        }

        private void calendar_Click(object sender, RoutedEventArgs e)
        {
            Calendrier c = new Calendrier();
            this.Content = c;
        }

        private void calcul_Click(object sender, RoutedEventArgs e)
        {
            Calculator c = new Calculator();
            this.Content = c;
        }

        private void deco_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            MainPage p = new MainPage();
            this.Content = p;
        }

        private void deconnect_Click(object sender, RoutedEventArgs e)
        {
            MainPage p = new MainPage();
            this.Content = p;
        }

        private void fs_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Host.Content.IsFullScreen = !Application.Current.Host.Content.IsFullScreen;
        }
    }
}
