using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using Telerik.Charting;
using Telerik.Windows.Controls.Charting;

namespace TelerikSilverlightApp1
{
    /// <summary>
    /// Interaction logic for TelerikScenario1.xaml
    /// </summary>
    public partial class TelerikScenario1
    {
        Dictionary<string, int> d = new Dictionary<string, int>();
        DataSeries dataSeries;
        public TelerikScenario1()
        {
            InitializeComponent();
            ServiceReference1.MyServiceClient serv = new ServiceReference1.MyServiceClient();
            serv.GetFilieresStatsCompleted += Serv_GetFilieresStatsCompleted;
            
            serv.GetFilieresStatsAsync();
            

        }

        private void Serv_GetFilieresStatsCompleted(object sender, ServiceReference1.GetFilieresStatsCompletedEventArgs e)
        {
            d = e.Result;

            dataSeries = new DataSeries();
            dataSeries.Definition = new BarSeriesDefinition();

            var keys = d.Keys;

            foreach (var item in keys)
            {
                var val = 0;
                d.TryGetValue(item, out val);
                dataSeries.Add(new Telerik.Windows.Controls.Charting.DataPoint() { YValue = val, XCategory = item });
            }



            myChart.DefaultView.ChartArea.DataSeries.Add(dataSeries);
            dataSeries.LegendLabel = "Nombre d'étudiants par filière";
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuPage p = new MenuPage();
            this.Content = p;
        }
    }
}
