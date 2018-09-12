using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CS3020HW3Classes;

namespace GHAR_2_Class_Library
{
    public class ReportGenerator
    {
        #region Fields

        List<Reservation> MasterReservations;
        StringBuilder sBuilder = new StringBuilder();

        // String Builder constants
        const int DefBuffer = 10;
        const int BufferAfterName = 10;

        #endregion

        #region Constructors



        #endregion

        #region Properties

        public string Name { get; set; }

        #endregion

        #region Methods

        #region PublicMethods

        public void SetMasterReservations(List<Reservation> newMasterList)
        {
            // Clear TotalReservations
            MasterReservations = newMasterList;
        }

        public void CalculateOtherEventCodes()
        {
            // Loop through the TotalReservations list
            foreach (Reservation currentRes in MasterReservations)
            {
                // Clear out the otherEvents in the reservation already
                currentRes.OtherEventCodes = new List<OtherEventCode>();

                foreach (Reservation checkRes in MasterReservations)
                {
                    if (currentRes.LastName == checkRes.LastName &&
                        currentRes.FirstName == checkRes.FirstName &&
                        currentRes != checkRes &&
                        currentRes.DepartDate == checkRes.DepartDate &&
                        !checkRes.IsFullRepeat)
                    {
                        currentRes.OtherEventCodes.Add(Util.CreateOtherEventCode(checkRes));
                    }
                }
            }
        }

        public List<Reservation> TESTCalculateOtherEventCodes(List<Reservation> testList)
        {
            // Loop through the TotalReservations list
            foreach (Reservation currentRes in testList)
            {
                foreach (Reservation checkRes in testList)
                {
                    if (currentRes.LastName == checkRes.LastName &&
                        currentRes.FirstName == checkRes.FirstName &&
                        currentRes != checkRes &&
                        currentRes.DepartDate == checkRes.DepartDate &&
                        !checkRes.IsFullRepeat)
                    {
                        currentRes.OtherEventCodes.Add(Util.CreateOtherEventCode(checkRes));
                    }
                }
            }

            return testList;
        }

        public void CreateDayEventsReport(string destPath)
        {
            // Sort
            MasterReservations = MasterReservations.OrderBy(o => o.FirstName).ToList();
            MasterReservations = MasterReservations.OrderBy(o => o.LastName).ToList();
            MasterReservations = MasterReservations.OrderBy(o => o.Event).ToList();
            MasterReservations = MasterReservations.OrderBy(o => o.DepartDate).ToList();

            // Flush out the sBuilder
            sBuilder = new StringBuilder();

            // Loop through the reservations to add the correct data to the sBuilder
            foreach (Reservation res in MasterReservations)
            {
                if (res.Event != EventType.Overnight)
                {
                    sBuilder.AppendLine($"{res.LastName}, {res.FirstName, -DefBuffer}{res.Count, -DefBuffer}{res.Event, -DefBuffer}{res.Hour}:{res.Minute, -DefBuffer}{res.OtherEventCodes.Count}");
                }
            }

            // Write the sBuilder out to the file
            Console.WriteLine(sBuilder.ToString());
        }

        public void CreateOvernightsReport(string destPath)
        {

        }

        #endregion

        #region PrivateMethods

        #endregion

        #endregion
    }
}