using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TDR
{
    public partial class DataInput : Form
    {
        public static string AppDirectory = Environment.GetEnvironmentVariable("onedriveconsumer") + "\\documents\\Brew for You\\TDR\\";
        public static string SaveCSV = AppDirectory + "TempData.csv";
        public static string SaveReport = AppDirectory + "TempReport.txt";

        public DataInput()
        {
            InitializeComponent();
            IsTodayInFile();
        }

        public void SaveTemp()
        {
            if (IsTodayInFile() )
            {
                return;
            }

            System.IO.StreamWriter TD = new StreamWriter(SaveCSV, true);
            TD.WriteLine("{0},{1},{2}",
                DateTime.Now.ToShortDateString(),
                MorningNUD.Value.ToString(),
                AfternoonNUD.Value.ToString());
            TD.Close();
            DisableControls();
        }

        public void DisableControls()
        {
            MorningNUD.Enabled = false;
            AfternoonNUD.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
        }
                
        public bool IsTodayInFile()
        {
            if (!File.Exists(SaveCSV))
                return false;

            string fileContent = File.ReadAllText(SaveCSV);

            // Format today's date in multiple common formats
            string[] dateFormats = new[]
            {
            DateTime.Today.ToString("MM/dd/yyyy"),
            DateTime.Today.ToString("M/d/yyyy"),
            DateTime.Today.ToString("yyyy-MM-dd"),
            DateTime.Today.ToString("dd/MM/yyyy"),
            DateTime.Today.ToString("d MMM yyyy")
        };

            foreach (string date in dateFormats)
            {
                if (fileContent.Contains(date))
                {
                    DisableControls();
                    return true;
                }
            }

            return false;
        }

        public void GenerateReport()
        {
            SaveTemp();
            int MorningCount=0, MorningTotal = 0;
            int AfternoonCount=0, AfternoonTotal=0;
            int MorningAverage, AfternoonAverage;
            string Line;
            
            StreamReader SR = new StreamReader(SaveCSV);
            StreamWriter SW = new StreamWriter(SaveReport, false);

            SW.WriteLine("BREW FOR YOU - TEMPERATURE LOG");
            string currentMonth = DateTime.Now.ToString("MMMM");
            SW.WriteLine(currentMonth + ", " + DateTime.Now.Year.ToString());
            SW.WriteLine();
            SW.WriteLine("{0,-10} {1,10} {2,10}", "DATE", "MORNING", "AFTERNOON");    

            while ( !SR.EndOfStream )
            {
                Line= SR.ReadLine();
                string[] subs = Line.Split(',');  //split string by ,
                MorningTotal += Convert.ToInt16(subs[1]);
                AfternoonTotal += Convert.ToInt16(subs[2]);
                MorningCount ++;
                AfternoonCount ++;

                SW.WriteLine("{0,-10} {1,10} {2,10}", subs[0], subs[1], subs[2]);
            }
            SR.Close();

            MorningAverage = MorningTotal / MorningCount;
            AfternoonAverage = AfternoonTotal / AfternoonCount;

            SW.WriteLine();
            SW.WriteLine("{0,-10} {1,10} {2,10}","AVERAGES:", MorningAverage, AfternoonAverage);
            SW.WriteLine("{0,-10}     {1,10}     {2,10}", " ENTRIES:", MorningCount, "", "");
            SW.Close();
        }

        #region MenuBar Items
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form About = new AboutForm();
            About.ShowDialog();  //show about / help form as a dialog
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTemp();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer TempReader = new SpeechSynthesizer();  //create TTS
            TempReader.Rate = 3;  //change voice speed 
            TempReader.SpeakAsync("Temperatures recorded for " + DateTime.Now.ToLongDateString() + ".");
            TempReader.SpeakAsync("Morning:  " + MorningNUD.Value + "°F .");
            TempReader.SpeakAsync("Afternoon:  " + AfternoonNUD.Value + "°F .");
            //example speech:  Temperatures recorded for friday, september 26, 2025
            //                 morning:  32 °F      Afternoon:  39 °F
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReport();
            Form ViewReport = new ViewReport();
            ViewReport.ShowDialog();  //show about / help form as a dialog

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReport();
            SaveTemp();
            Application.Exit();     
        }
        #endregion
    }
}
