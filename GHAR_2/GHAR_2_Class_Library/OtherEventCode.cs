using System;
using System.Collections.Generic;
using System.Text;

namespace GHAR_2_Class_Library
{
    public class OtherEventCode
    {
        public string Code { get; set; }

        public int Hour { get; set; }

        public int Minute { get; set; }

        public EventType Type { get; set; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Code;
        }
    }
}
