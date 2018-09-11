using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using GHAR_2_Class_Library;

namespace CS3020HW3Classes
{
    /// <summary>
    /// 
    /// </summary>
    public static class Util
    {
        #region Fields



        #endregion

        #region Constructors



        #endregion

        #region Properties



        #endregion

        #region Methods

        #region Public Methods

        /// <summary>
        /// Serialize out the given file out to the given path.
        /// </summary>
        /// <param name="file">The file to be written out.</param>
        /// <param name="filePath">The file path.</param>
        public static void SerializeOut<T>(T file, string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, file);
            }
        }

        /// <summary>
        /// Deserialize in from the given path to the given file.
        /// </summary>
        /// <param name="file">The file to store what's read in.</param>
        /// <param name="filePath">The file path.</param>
        public static T DeserializeIn<T>(T file, string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                // Deserialize
                BinaryFormatter formatter = new BinaryFormatter();
                return (T)formatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// Returns how many line return characters are in the provided string.
        /// </summary>
        /// <param name="str">The "multi line" string to be analized.</param>
        /// <returns>Returns an int representing the number of lines in the string. (May include blank lines.)</returns>
        public static int CountLines(this string str)
        {
            return (str.Length - str.Replace("\n", "").Length) + 1;
        }

        /// <summary>
        /// Returns a string file name for a Megasys raw data report.
        /// </summary>
        /// <param name="reportName">The name of the raw report.</param>
        /// <param name="ext">The file extension.</param>
        /// <returns></returns>
        public static string CreateRawDataFileName(string reportName, string ext)
        {
            return $"ReportOf:_({reportName})_({DateTime.Now:s}).{ext}";
        }

        /// <summary>
        /// Returns a string file name for the GHAR processed data
        /// </summary>
        /// <param name="reportName">The name of the processed report.</param>
        /// <param name="ext">The file extension.</param>
        /// <returns></returns>
        public static string CreateProcessedDataFileName(string reportName, string ext)
        {
            return $"ProcessedDataFor:_({reportName})_({DateTime.Now:s}).{ext}";
        }

        /// <summary>
        /// Returns a OtherEventCode form of the reservation input.
        /// </summary>
        /// <param name="input">The input Reservation.</param>
        /// <returns></returns>
        public static OtherEventCode CreateOtherEventCode(Reservation res)
        {
            // Local Declarations
            OtherEventCode tmp = new OtherEventCode();

            // Find the time of the Reservation
            tmp.Hour = res.Hour;
            tmp.Minute = res.Minute;

            // Set the compacted display code
            switch (res.Event)
            {
                case EventType.Overnight:
                    tmp.Code = "(Ov)";
                    break;

                case EventType.TeaAm:
                    tmp.Code = $"(Te-{CreateCompactedTimeStamp(tmp.Hour, tmp.Minute)})";
                    break;

                case EventType.TeaPm:
                    tmp.Code = $"(Te-{CreateCompactedTimeStamp(tmp.Hour, tmp.Minute)})";
                    break;

                case EventType.Tour:
                    tmp.Code = $"(Tr-{CreateCompactedTimeStamp(tmp.Hour, tmp.Minute)})";
                    break;

                case EventType.Concert:
                    tmp.Code = $"(Ct-{CreateCompactedTimeStamp(tmp.Hour, tmp.Minute)})";
                    break;

                case EventType.Dinner:
                    tmp.Code = $"(Dn-{CreateCompactedTimeStamp(tmp.Hour, tmp.Minute)})";
                    break;

                case EventType.Madrigal:
                    tmp.Code = "(Madrigal)";
                    break;

                case EventType.SpecialEvent:
                    tmp.Code = "(Sp-Event)";
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            return tmp;

            // Local Functions
            string CreateCompactedTimeStamp(int h, int m)
            {
                string hour = h.ToString();
                string min = m == 0 ? string.Empty : $":{m.ToString().Trim('0')}";

                return hour + min;
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