using System;
using System.Windows.Forms;
using System.IO;

namespace TDR
{
    public partial class ViewReport : Form
    {
        public static string AppDirectory = Environment.GetEnvironmentVariable("onedriveconsumer") + "\\documents\\Brew for You\\TDR\\";
        public static string SaveReport = AppDirectory + "TempReport.txt";

        public ViewReport()
        {
            InitializeComponent();
            ReportRTB.Text = File.ReadAllText(SaveReport);
        }

        private void OKBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
