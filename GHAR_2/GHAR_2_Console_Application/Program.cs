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
            ReportGenerator generator = new ReportGenerator();
            List<Reservation> masterList = new List<Reservation>();

            // read in the substring of the file
            foreach (string file in Directory.EnumerateFileSystemEntries(@"E:\Data\RawDataReports"))
            {
                List<Reservation> tmpList = parser.DetectReportTypeAndParse(file);

                if (tmpList != null)
                {
                    foreach (Reservation res in tmpList)
                    {
                        masterList.Add(res);
                    }
                }
            }

            masterList = masterList.OrderBy(o => o.FirstName).ToList();
            masterList = masterList.OrderBy(o => o.LastName).ToList();
            masterList = masterList.OrderBy(o => o.Event).ToList();
            masterList = masterList.OrderBy(o => o.DepartDate).ToList();

            // Shave repeats
            foreach (Reservation res in masterList)
            {
                foreach (Reservation checkRes in masterList)
                {
                    if (res != checkRes &&
                        res.FirstName == checkRes.FirstName &&
                        res.LastName == checkRes.LastName &&
                        res.Event == checkRes.Event &&
                        res.Count == checkRes.Count &&
                        res.DepartDate == checkRes.DepartDate &&
                        res.Hour == checkRes.Hour)
                    {
                        checkRes.IsFullRepeat = true;
                    }
                }
            }

            masterList = generator.TESTCalculateOtherEventCodes(masterList);

            foreach (Reservation res in masterList)
            {
                if (!res.IsFullRepeat)
                {
                    Console.Write($"{res.LastName},{res.FirstName}\t\t{res.Event}\t\t{res.DepartDate:M/d}\t\t");

                    foreach (OtherEventCode code in res.OtherEventCodes)
                    {
                        Console.Write($"{code}");
                    }

                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}