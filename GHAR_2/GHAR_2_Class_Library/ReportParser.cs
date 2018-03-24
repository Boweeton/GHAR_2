using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GHAR_2_Class_Library
{
    public class ReportParser
    {
        #region Fields

        // Ticket Master Listing (TML) Offset Constants
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

        // Expected Arrivals (EA) Offset Constants
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



        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods



        #endregion

        #endregion
    }
}