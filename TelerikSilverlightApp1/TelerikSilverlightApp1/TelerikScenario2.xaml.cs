using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for TelerikScenario2.xaml
    /// </summary>
    public partial class TelerikScenario2
    {
        Dictionary<string, string[]> d = new Dictionary<string, string[]>();
        ObservableCollection<Student> items = new ObservableCollection<Student>();
        ServiceReference2.MyServiceClient c;
        ServiceReference3.MyServiceClient s;
        public TelerikScenario2()
        {
            InitializeComponent();

            c = new ServiceReference2.MyServiceClient();
            c.GetAllStudentsCompleted += C_GetAllStudentsCompleted;

            s = new ServiceReference3.MyServiceClient();
            s.DeleteStudentCompleted += S_DeleteStudentCompleted;
           

            c.GetAllStudentsAsync();
            //todo

        }

        private void S_DeleteStudentCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            TelerikScenario2 t = new TelerikScenario2();
            this.Content = t;
        }

        private void C_GetAllStudentsCompleted(object sender, ServiceReference2.GetAllStudentsCompletedEventArgs e)
        {
            var x = e.Result;
            
            
            var keys = x.Keys;
            foreach (var item in keys)
            {
                var value = new ObservableCollection<string>();
                x.TryGetValue(item, out value);
                items.Add(new Student(value[0], value[1], item));
            }

            cf.ItemsSource = items;
            
            
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuPage m = new MenuPage();
            this.Content = m;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = cf.SelectedItem as Student;
            ViewStudent es = new ViewStudent(x.Cne);
            this.Content = es;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var x = cf.SelectedItem as Student;
            EditStudent es = new EditStudent(x.Cne);
            this.Content = es;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var x = cf.SelectedItem as Student;
            s.DeleteStudentAsync(x.Cne);
        }
    }
}
