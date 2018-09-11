using System;
using System.Collections.Generic;
using System.IO;
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
                    tmpRes.FullNameEntry = line.Substring(TmlNameBase, TmlNameLength);

                    // Read out / set the DepartureDate
                    tmpRes.DepartDate = DateTime.Parse(line.Substring(TmlDateBase,TmlDateLength));

                    // Read out / set the EventType
                    tmpRes.Event = FindEventType(line.Substring(TmlEventBase, TmlEventLength));

                    // Read out / set the MrktCode

                    // Read out / set the People Count
                    tmpRes.Count = int.Parse(line.Substring(TmlCountBase, TmlCountLength));

                    // Read out / set the EventTime
                    string[] timeComponents = line.Substring(TmlTimeBase, TmlTimeLength).Split(':');
                    tmpRes.Hour = int.Parse(timeComponents[0].Trim());
                    tmpRes.Minute = int.Parse(timeComponents[1].Trim());

                    // Parse the LastName and the FirstName
                    string[] names = tmpRes.FullNameEntry.Split(',');
                    tmpRes.FirstName = names[0].Trim();
                    tmpRes.LastName = names[1].Trim();

                    // Add that to the localReservations
                    localReservations.Add(tmpRes);
                }
            }

            return localReservations;

            // Local Functions
            bool IsValidTmlReservationLine(string line)
            {
                return true;    // ToDo: fix this
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
                    tmpRes.FullNameEntry = line.Substring(EaNameBase, EaNameLength);

                    // Read out / set the DepartureDate
                    tmpRes.DepartDate = DateTime.Parse(line.Substring(EaDepartDateBase, EaNameLength));

                    // Read out / set the EventType
                    tmpRes.Event = FindEventType(line.Substring(EaCresBase, EaCresLength));

                    // Read out / set the MrktCode
                    tmpRes.MrktCode = line.Substring(EaMrktCodeBase, EaMrktCodeLength);

                    // Read out / set the People Count
                    tmpRes.Count = int.Parse(line.Substring(EaCountBase, EaCountLength));

                    switch (tmpRes.Event)
                    {
                        // Read out / set the EventTime
                        case EventType.TeaAm:
                            // Hard code TeaAm time since Glen Eyrie is an undercommunicator
                            tmpRes.Hour = 11;
                            tmpRes.Minute = 0;
                            break;

                        case EventType.TeaPm:
                            // Hard code TeaPm time since Glen Eyrie is an undercommunicator
                            tmpRes.Hour = 2;
                            tmpRes.Minute = 30;
                            break;

                        default:
                            tmpRes.Hour = 12;
                            tmpRes.Minute = 0;
                            break;
                    }

                    // Parse the LastName and the FirstName
                    string[] names = tmpRes.FullNameEntry.Split(',');
                    tmpRes.FirstName = names[0].Trim();
                    tmpRes.LastName = names[1].Trim();

                    // Add that to the localReservations
                    localReservations.Add(tmpRes);
                }
            }

            return localReservations;

            // Local Functions
            bool IsValidEaReservationLine(string line)
            {
                return true;    // Todo: fix this
            }
        }

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods

        static EventType FindEventType(string code)
        {
            // Switch through all expected codes
            switch (code.ToLower())
            {
                case "tour":
                    return EventType.Tour;
                default:
                    return EventType.SpecialEvent;
            }
        }

        #endregion

        #endregion
    }
}