using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_RadarAreaChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl RadarAreaChart = new ChartControl();

            // Add a radar series to it.
            Series series1 = new Series("Series 1", ViewType.RadarArea);

            // Populate the series with points.
            series1.Points.Add(new SeriesPoint(0, 90));
            series1.Points.Add(new SeriesPoint(90, 95));
            series1.Points.Add(new SeriesPoint(180, 50));
            series1.Points.Add(new SeriesPoint(270, 55));
            series1.Points.Add(new SeriesPoint(0, 180));
            series1.Points.Add(new SeriesPoint(90, 185));
            series1.Points.Add(new SeriesPoint(180, 270));
            series1.Points.Add(new SeriesPoint(270, 275));

            // Add the series to the chart.
            RadarAreaChart.Series.Add(series1);

            // Flip the diagram (if necessary).
            ((RadarDiagram)RadarAreaChart.Diagram).StartAngleInDegrees = 180;
            ((RadarDiagram)RadarAreaChart.Diagram).RotationDirection =
                RadarDiagramRotationDirection.Counterclockwise;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Radar Area Chart";
            RadarAreaChart.Titles.Add(chartTitle1);
            RadarAreaChart.Legend.Visibility =  DevExpress.Utils.DefaultBoolean.False;

            // Add the chart to the form.
            RadarAreaChart.Dock = DockStyle.Fill;
            this.Controls.Add(RadarAreaChart);
        }

    }
}