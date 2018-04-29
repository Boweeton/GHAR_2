using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

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
        /// <param name="str">The "milti line" string to be analized.</param>
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
            return $"RepotOf:_({reportName})_({DateTime.Now:s}).{ext}";
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

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods



        #endregion

        #endregion
    }
}