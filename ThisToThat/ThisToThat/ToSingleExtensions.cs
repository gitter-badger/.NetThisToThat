
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToSingleExtensions
    {

        /* 
        SByte to Single: Method omitted
        There is a predefined implicit conversion from SByte to Single
        */

        /* 
        Byte to Single: Method omitted
        There is a predefined implicit conversion from Byte to Single
        */

        /* 
        Int16 to Single: Method omitted
        There is a predefined implicit conversion from Int16 to Single
        */

        /* 
        UInt16 to Single: Method omitted
        There is a predefined implicit conversion from UInt16 to Single
        */

        /* 
        Int32 to Single: Method omitted
        There is a predefined implicit conversion from Int32 to Single
        */

        /* 
        UInt32 to Single: Method omitted
        There is a predefined implicit conversion from UInt32 to Single
        */

        /* 
        Int64 to Single: Method omitted
        There is a predefined implicit conversion from Int64 to Single
        */

        /* 
        UInt64 to Single: Method omitted
        There is a predefined implicit conversion from UInt64 to Single
        */

        /// <summary>
        /// Converts this Double to Single or returns the specified default value
        /// </summary>
        /// <returns>This Double converted to Single</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.7976931348623157E+308
        /// Max value: 1.7976931348623157E+308
        ///
        /// Target type: Single
        /// Min value: -3.40282347E+38
        /// Max value: 3.40282347E+38
        /// </remarks>
        public static Single ToSingleOrDefault(this Double thisDouble, Single defaultValue = default(Single))
        {
            return thisDouble.ToSingleNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Double to Single?
        /// </summary>
        /// <returns>This Double converted to Single</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.7976931348623157E+308
        /// Max value: 1.7976931348623157E+308
        ///
        /// Target type: Single
        /// Min value: -3.40282347E+38
        /// Max value: 3.40282347E+38
        /// </remarks>
        public static Single? ToSingleNullable(this Double thisDouble)
        {
            return (thisDouble < -3.40282347E+38d || thisDouble > 3.40282347E+38d) ? (Single?)null : (Single)thisDouble;
        }

        /* 
        Decimal to Single: Method omitted
        Explicit numeric conversion is possible from Decimal to Single.
        Decimal falls within the range of Single.
        To convert, simply cast as Single e.g: 

        Decimal myDecimal = Decimal.MinValue;
        Single mySingle = (Single)myDecimal;
        */

        /// <summary>
        /// Converts and returns this string's value as a nullable Single.
        /// Null is returned if the value does not successfully parse to Single.
        /// </summary>
        /// <returns>This string's value converted to a nullable Single.</returns>
        public static Single? ToSingleNullable(this string strThisString)
        {
            Single singleReturn;
            return Single.TryParse(strThisString, out singleReturn) ? singleReturn : (Single?)null;
        }
        
        /// <summary>
        /// Converts and returns this string's value as Single.
        /// The default value passed in is returned if the string does not successfully parse to Single.
        /// </summary>
        /// <returns>This string converted to Single, or the default value if conversion unsuccessful.</returns>
        public static Single ToSingleOrDefault(this string strThisString, Single singleDefault = default(Single))
        {
            Single singleReturn;
            return Single.TryParse(strThisString, out singleReturn) ? singleReturn : singleDefault;
        }

    }
}
