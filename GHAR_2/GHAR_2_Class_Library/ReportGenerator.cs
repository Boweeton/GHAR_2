using System;
using System.Collections.Generic;
using System.Text;
using CS3020HW3Classes;

namespace GHAR_2_Class_Library
{
    class ReportGenerator
    {
        #region Fields

        List<Reservation> TotalReservations;

        #endregion

        #region Constructors



        #endregion

        #region Properties

        public string Name { get; set; }

        #endregion

        #region Methods

        #region PublicMethods

        /// <summary>
        /// Clears TotalReservations and reads in every Reservation object in each list passed in.
        /// </summary>
        /// <param name="newTotalList">The List of Lists of Reservation objects.</param>
        public void SetTotalReservations(List<List<Reservation>> newTotalList)
        {
            // Clear TotalReservations
            TotalReservations = new List<Reservation>();

            // Add all the new Reservation objects
            foreach (List<Reservation> subList in newTotalList)
            {
                foreach (Reservation res in subList)
                {
                    TotalReservations.Add(res);
                }
            }
        }

        #endregion

        #region PrivateMethods

        void CalculateOtherEventCodes()
        {
            // Loop through the TotalReservations list
            foreach (Reservation currentRes in TotalReservations)
            {
                foreach (Reservation checkRes in TotalReservations)
                {
                    if (currentRes.Name == checkRes.Name && currentRes != checkRes)
                    {
                        currentRes.OtherEventCodes.Add(Util.CreateOtherEventCode(checkRes));
                    }
                }
            }
        }

        #endregion

        #endregion
    }
}
