﻿using System;
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
                    if (currentRes.LastName == checkRes.LastName &&
                        currentRes.FirstName == checkRes.FirstName &&
                        currentRes != checkRes)
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