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
    /// Interaction logic for StudentsParFiliere.xaml
    /// </summary>
    public partial class StudentsParFiliere
    {
        ServiceReference3.MyServiceClient s;


        public StudentsParFiliere()
        {
            InitializeComponent();

            s = new ServiceReference3.MyServiceClient();

            s.GetAllFilieresCompleted += S_GetAllFilieresCompleted;
            s.GetStudentsByFiliereCompleted += S_GetStudentsByFiliereCompleted;
            s.GetAllFilieresAsync();

        }

        private void S_GetStudentsByFiliereCompleted(object sender, ServiceReference3.GetStudentsByFiliereCompletedEventArgs e)
        {
            var x = e.Result;
            gridView.ItemsSource = x;
        }

        private void S_GetAllFilieresCompleted(object sender, ServiceReference3.GetAllFilieresCompletedEventArgs e)
        {
            var x = e.Result;
            
            comboBoxFiliere.ItemsSource = x;
            
        }

        private void comboBoxFiliere_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            s.GetStudentsByFiliereAsync((comboBoxFiliere.SelectedItem as ServiceReference3.Filiere).id);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuPage m = new MenuPage();
            this.Content = m;
        }
    }
}
