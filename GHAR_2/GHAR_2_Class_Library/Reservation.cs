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

        public string FullNameEntry { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime DepartDate { get; set; }

        public EventType Event { get; set; }

        public string CresCode { get; set; }

        public int Count { get; set; }

        public int Hour { get; set; }

        public int Minute { get; set; }

        public List<OtherEventCode> OtherEventCodes { get; set; } = new List<OtherEventCode>();

        public bool IsFullRepeat { get; set; } = false;

        #endregion

        #region Methods



        #endregion
    }
}
