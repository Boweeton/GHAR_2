using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS3020HW3Classes;
using GHAR_2_Class_Library;

namespace GHAR_2_Console_Application
{
    class Program
    {
        static void Main()
        {
            ReportParser parser = new ReportParser();
            List<Reservation> masterList = new List<Reservation>();

            // read in the substring of the file
            foreach (string file in Directory.EnumerateFileSystemEntries(@"E:\Data\test"))
            {
                List<Reservation> tmpList = parser.ParseEaReport(file);

                foreach (Reservation res in tmpList)
                {
                    masterList.Add(res);
                }
            }

            foreach (Reservation res in masterList)
            {
                if (res.Event != EventType.Tour)
                {
                    Console.WriteLine($"{res.LastName}, {res.FirstName}\t\t{res.Event}\t{res.DepartDate:M/d}");
                }
            }

            Console.ReadKey();
        }
    }
}