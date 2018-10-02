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
    /// Interaction logic for EditStudent.xaml
    /// </summary>
    public partial class EditStudent
    {
        public EditStudent(string cne = "1234")
        {
            InitializeComponent();
            ServiceReference3.MyServiceClient s = new ServiceReference3.MyServiceClient();
            s.getStudentCompleted += S_getStudentCompleted;
            
            s.getStudentAsync(int.Parse(cne));
        }

        private void S_getStudentCompleted(object sender, ServiceReference3.getStudentCompletedEventArgs e)
        {
            var x = e.Result;
            RadDataForm1.CurrentItem = x;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            TelerikScenario2 t = new TelerikScenario2();
            this.Content = t;
        }
    }
}
