using System;
using System.IO;    

namespace TDR
{
    internal class Program
    {
        public static double MorningTemp, AfternoonTemp, DepositAmount;  //values to store
        public static string LogPath = Environment.GetEnvironmentVariable("onedriveconsumer") + "\\documents\\brew for you\\TDR\\";

        static void Main(string[] args)
        {
            // Get all command-line arguments
            string[] cmdArgs = Environment.GetCommandLineArgs();

            // Check if the parameter '-p' exists
            if (Array.Exists(cmdArgs, arg => arg == "-p"))
            {
                LogPath = Environment.CurrentDirectory + "\\TDR\\";  //change directory
            }

            Console.Title = "BFY Temperature & Deposit Recorder";  //console window title
            Console.ForegroundColor = ConsoleColor.White;  //white text, easier for my 1 eye to see

            Print("This is the Brew for You Temperature & Deposit Recorder");  //tell the user what this program does
            Print("The program stores the morning and afternoon temperatures,");
            Print("along with the cash deposit total.\n\n");  //\n is new line

            //get 3 numbers using a numeric validation function
            MorningTemp = GetNumber("What is the   morning temperature?  ", 20, 50);
            AfternoonTemp = GetNumber("What is the afternoon temperature?  ", 20, 50);
            DepositAmount = GetNumber("   What is the cash Deposit Total?  $", 0, 150);

            SavetoFile();  //save data to file
        }

        static double GetNumber(String Prompt, int Low, int High)  //get a number from thee user
        {
            string line; double rtn = 0;  //line read and number returned
            while (true)  //loop until valid input
            {
                Console.Write(Prompt);  //display prompt message before getting input
                line = Console.ReadLine();  //store input

                if (double.TryParse(line, out rtn))  //if string can convert to double
                {
                    // Successfully parsed, exit the loop
                    break;
                }
                else
                {
                    // Invalid input, prompt the user again
                    System.Media.SystemSounds.Asterisk.Play();  //play a sound 
                }
            }

            if (rtn < Low || rtn > High)  //bounds check
            {
                System.Media.SystemSounds.Asterisk.Play();
                GetNumber(Prompt, Low, High);
            }

            return rtn;  //return number, all checks passed
        }

        static void Print(string text = "")  //write to console
        {
            Console.WriteLine(text);
        }

        static void SavetoFile()
        {
            DateTime CurDate = DateTime.Now;  //current date
                                              //path to write files
            Directory.CreateDirectory(LogPath);  //create LogPath directory if needed
            StreamWriter Temp = File.AppendText(LogPath + "Temperature.csv");  //append to temperature file
            Temp.Write(CurDate.ToShortDateString() + ",");  //write in csv format, date first
            Temp.Write(MorningTemp.ToString() + ",");  //morning temp
            Temp.Write(AfternoonTemp.ToString() + ",C.M.");  //afternoon temp, and initials
            Temp.WriteLine();  //blank line
            Temp.Flush();
            Temp.Close();  //close stream

            StreamWriter Depo = File.AppendText(LogPath + "Deposit.csv");  //deposit file
            Depo.WriteLine("$" + DepositAmount.ToString("n2"));  //amount
            Depo.Flush();
            Depo.Close();  //close file
        }
    }
}