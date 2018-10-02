using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TelerikSilverlightApp1
{
    public class Student
    {
        public Student(string n, string p, string id = "")
        {
            Nom = n; Picture = p; Cne = id;
        }
        public string Cne { get; set; }
        public string Nom { get; set; }
        public string Picture { get; set; }

    }
}
