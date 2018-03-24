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
            // Check for invalid file
            if (!File.Exists(file))
            {
                throw new FileNotFoundException(file);
            }

            // Local Declarations
            List<Reservation> localReservations = new List<Reservation>();
            string[] fileLines = File.ReadAllLines(file);

            foreach (string line in fileLines)
            {
                // Check to see if line has a reservation in it
                if (IsValidTmlReservationLine(line))
                {
                    Reservation tmpRes = new Reservation();

                    // Read out / set the Name

                    // Read out / set the DepartureDate

                    // Read out / set the EventType

                    // Reat out / set the MrktCode

                    // Read out / set the People Count

                    // Read out / set the EventTime

                    // Add that to the localReservations
                }
            }

            return localReservations;

            // Local Fuctions
            bool IsValidTmlReservationLine(string line)
            {
                return true;
            }
        }

        /// <summary>
        /// Collects all the Reservations within an "Expected Arrivals" (EA) Report [used in Megasys .txt reports (March 2018)].
        /// </summary>
        /// <param name="file">A .txt export of a Megasys EA Report (March 2018).</param>
        /// <returns></returns>
        public List<Reservation> ParseEaReport(string file)
        {
            // Check for invalid file
            if (!File.Exists(file))
            {
                throw new FileNotFoundException(file);
            }

            // Local Declarations
            List<Reservation> localReservations = new List<Reservation>();
            string[] fileLines = File.ReadAllLines(file);

            foreach (string line in fileLines)
            {
                // Check to see if line has a reservation in it
                if (IsValidEaReservationLine(line))
                {
                    Reservation tmpRes = new Reservation();

                    // Read out / set the Name

                    // Read out / set the DepartureDate

                    // Read out / set the EventType

                    // Reat out / set the MrktCode

                    // Read out / set the People Count

                    // Read out / set the EventTime

                    // Add that to the localReservations
                }
            }

            return localReservations;

            // Local Fuctions
            bool IsValidEaReservationLine(string line)
            {
                return true;
            }
        }

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods



        #endregion

        #endregion
    }
}