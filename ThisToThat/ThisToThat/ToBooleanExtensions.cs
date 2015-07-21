using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ThisToThat
{
    /// <summary>
    /// Static class of extension methods all for converting various basic types to boolean.
    /// </summary>
    public static class ToBooleanExtensions
    {
        private static readonly string[] _TRUE_STRINGS = { "TRUE", "T", "YES", "Y", "ON", "1" };
        private static readonly string[] _FALSE_STRINGS = { "FALSE", "F", "NO", "N", "OFF", "0" };

        /// <summary>
        /// Converts and returns this string's value as a boolean or the specified default value.
        /// Values which will convert to true are: "TRUE", "T", "YES", "Y", "ON", "1"
        /// Values which will convert to false are: "FALSE", "F", "NO", "N", "OFF", "0"
        /// All other values will convert to the default specified.
        /// </summary>
        public static bool ToBooleanOrDefault(this string thisString, bool defaultValue = default(bool))
        {
            bool returnValue = defaultValue;

            if (_TRUE_STRINGS.Contains(thisString.ToUpper()))
                returnValue = true;
            else if (_FALSE_STRINGS.Contains(thisString.ToUpper()))
                returnValue = false;

            return returnValue;
        }

        /// <summary>
        /// Converts and returns this string's value as a nullable boolean.
        /// Values which will convert to true are: "TRUE", "T", "YES", "Y", "ON", "1"
        /// Values which will convert to false are: "FALSE", "F", "NO", "N", "OFF", "0"
        /// All other values will convert to null.
        /// </summary>
        public static bool? ToBooleanNullable(this string thisString)
        {
            bool? returnValue = null;

            if (_TRUE_STRINGS.Contains(thisString.ToUpper()))
                returnValue = true;
            else if (_FALSE_STRINGS.Contains(thisString.ToUpper()))
                returnValue = false;

            return returnValue;
        }

    }
}
