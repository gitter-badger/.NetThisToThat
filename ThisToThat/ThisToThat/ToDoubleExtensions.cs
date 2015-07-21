
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToDoubleExtensions
    {

        /* 
        SByte to Double: Method omitted
        There is a predefined implicit conversion from SByte to Double
        */

        /* 
        Byte to Double: Method omitted
        There is a predefined implicit conversion from Byte to Double
        */

        /* 
        Int16 to Double: Method omitted
        There is a predefined implicit conversion from Int16 to Double
        */

        /* 
        UInt16 to Double: Method omitted
        There is a predefined implicit conversion from UInt16 to Double
        */

        /* 
        Int32 to Double: Method omitted
        There is a predefined implicit conversion from Int32 to Double
        */

        /* 
        UInt32 to Double: Method omitted
        There is a predefined implicit conversion from UInt32 to Double
        */

        /* 
        Int64 to Double: Method omitted
        There is a predefined implicit conversion from Int64 to Double
        */

        /* 
        UInt64 to Double: Method omitted
        There is a predefined implicit conversion from UInt64 to Double
        */

        /* 
        Single to Double: Method omitted
        There is a predefined implicit conversion from Single to Double
        */

        /* 
        Decimal to Double: Method omitted
        Explicit numeric conversion is possible from Decimal to Double.
        Decimal falls within the range of Double.
        To convert, simply cast as Double e.g: 

        Decimal myDecimal = Decimal.MinValue;
        Double myDouble = (Double)myDecimal;
        */

        /// <summary>
        /// Converts and returns this string's value as a nullable Double.
        /// Null is returned if the value does not successfully parse to Double.
        /// </summary>
        /// <returns>This string's value converted to a nullable Double.</returns>
        public static Double? ToDoubleNullable(this string strThisString)
        {
            Double doubleReturn;
            return Double.TryParse(strThisString, out doubleReturn) ? doubleReturn : (Double?)null;
        }
        
        /// <summary>
        /// Converts and returns this string's value as Double.
        /// The default value passed in is returned if the string does not successfully parse to Double.
        /// </summary>
        /// <returns>This string converted to Double, or the default value if conversion unsuccessful.</returns>
        public static Double ToDoubleOrDefault(this string strThisString, Double doubleDefault = default(Double))
        {
            Double doubleReturn;
            return Double.TryParse(strThisString, out doubleReturn) ? doubleReturn : doubleDefault;
        }

    }
}
