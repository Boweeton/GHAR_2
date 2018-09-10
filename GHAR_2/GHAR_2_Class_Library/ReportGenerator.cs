using System;
using System.Collections.Generic;
using System.Text;
using CS3020HW3Classes;

namespace GHAR_2_Class_Library
{
    public class ReportGenerator
    {
        #region Fields

        List<Reservation> MasterReservations;

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
                foreach (Reservation checkRes in MasterReservations)
                {
                    if (currentRes.Name == checkRes.Name && currentRes != checkRes)
                    {
                        currentRes.OtherEventCodes.Add(Util.CreateOtherEventCode(checkRes));
                    }
                }
            }
        }

        public void CreateDayEventsReport(string destPath)
        {

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