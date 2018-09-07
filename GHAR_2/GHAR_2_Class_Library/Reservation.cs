using System;
using System.Collections.Generic;

namespace GHAR_2_Class_Library
{
    public class Reservation
    {
        #region Fields



        #endregion

        #region Constructors



        #endregion

        #region Properties

        public string Name { get; set; }

        public DateTime DepartDate { get; set; }

        public EventType Event { get; set; }

        public string MrktCode { get; set; }

        public int Count { get; set; }

        public DateTime EventTime { get; set; }

        public List<OtherEventCode> OtherEventCodes { get; set; } = new List<OtherEventCode>();

        #endregion

        #region Methods



        #endregion
    }
}
