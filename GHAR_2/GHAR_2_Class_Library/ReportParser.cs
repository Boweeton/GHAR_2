using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GHAR_2_Class_Library
{
    public class ReportParser
    {
        #region Fields

        // Ticket Master Listing Report (TML) Offset Constants [used in Megasys .txt reports (March 2018)]
        const int TmlDateBase = 0;
        const int TmlDateLength = 11;
        const int TmlTimeBase = 11;
        const int TmlTimeLength = 10;
        const int TmlEventBase = 21;
        const int TmlEventLength = 8;
        const int TmlNameBase = 36;
        const int TmlNameLength = 16;
        const int TmlCountBase = 56;
        const int TmlCountLength = 3;

        // Expected Arrivals Report (EA) Offset Constants [used in Megasys .txt reports (March 2018)]
        const int EaNameBase = 12;
        const int EaNameLength = 16;
        const int EaCresBase = 41;
        const int EaCresLength = 9;
        const int EaDepartDateBase = 50;
        const int EaDepartDateLength = 9;
        const int EaMrktCodeBase = 59;
        const int EaMrktCodeLength = 7;
        const int EaCountBase = 91;
        const int EaCountLength = 5;

        #endregion

        #region Constructors



        #endregion

        #region Properties



        #endregion

        #region Methods

        #region Public Methods

        /// <summary>
        /// Collects all the Reservations within a "Ticket Master Listing" (TML) Report [used in Megasys .txt reports (March 2018)].
        /// </summary>
        /// <param name="file">A .txt export of a Megasys TML Report (March 2018).</param>
        /// <returns></returns>
        public List<Reservation> ParseTmlReport(string file)
        {
            // Local Declarations
            List<Reservation> localReservations = new List<Reservation>();

            return localReservations;
        }

        /// <summary>
        /// Collects all the Reservations within an "Expected Arrivals" (EA) Report [used in Megasys .txt reports (March 2018)].
        /// </summary>
        /// <param name="file">A .txt export of a Megasys EA Report (March 2018).</param>
        /// <returns></returns>
        public List<Reservation> ParseEaReport(string file)
        {
            // Local Declarations
            List<Reservation> localReservations = new List<Reservation>();

            return localReservations;
        }

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods



        #endregion

        #endregion
    }
}