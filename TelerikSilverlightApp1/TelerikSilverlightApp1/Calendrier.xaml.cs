using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Telerik.Windows.Controls;

namespace TelerikSilverlightApp1
{
    /// <summary>
    /// Interaction logic for Calendrier.xaml
    /// </summary>
    public partial class Calendrier
    {
        public Calendrier()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuPage m = new TelerikSilverlightApp1.MenuPage();
            this.Content = m;
        }
    }
}
