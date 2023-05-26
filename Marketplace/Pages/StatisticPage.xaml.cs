using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для StatisticPage.xaml
    /// </summary>
    public partial class StatisticPage : Page
    {
        public StatisticPage()
        {
            InitializeComponent();
            var area = MainChart.ChartAreas.Add("MainArea");
            var legend = MainChart.Legends.Add("Main legend");
            area.AxisX.Interval = 1;
            area.AxisY.Interval = 1;
        }

        private void GenerateBt_Click(object sender, RoutedEventArgs e)
        {
            var startDate = DPStartDate.SelectedDate;
            var endDate = DPEndDate.SelectedDate;
            if(!startDate.HasValue) 
            {
                MessageBox.Show("vbhg");
                return;
            }
            MainChart.Series.Clear();
            foreach (var user in App.db.User)
            {
                var seria = MainChart.Series.Add($"#{user.Id} {user.Name}");
                var chartDate = App.db.Order.ToList().Where(z => z.Date >= startDate.Value.Date && z.Date <= endDate).OrderBy(u => u.Date)
                    .GroupBy(x => x.Date)
                    .ToDictionary(key => key.Key, value => value.Count());
                seria.Points.DataBindXY(chartDate.Keys, chartDate.Values);
                seria.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            }
           
            //var chartDate = App.db.Order.ToList()
            //    .GroupBy(x => x.Date. >= startDate.Value.Date && Date <= endDate)
            //    .ToDictionary(key => key.Key, value => value.Count());
            //var seria = MainChart.Series.Add("orders seriws");
            //seria.BorderWidth = 10;
            //seria.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            ////seria.BorderColor = System.Drawing.Color.Red;
            //seria.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
           
        }
    }
}
