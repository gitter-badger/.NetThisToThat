
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToInt64Extensions
    {

        /* 
        SByte to Int64: Method omitted
        There is a predefined implicit conversion from SByte to Int64
        */

        /* 
        Byte to Int64: Method omitted
        There is a predefined implicit conversion from Byte to Int64
        */

        /* 
        Int16 to Int64: Method omitted
        There is a predefined implicit conversion from Int16 to Int64
        */

        /* 
        UInt16 to Int64: Method omitted
        There is a predefined implicit conversion from UInt16 to Int64
        */

        /* 
        Int32 to Int64: Method omitted
        There is a predefined implicit conversion from Int32 to Int64
        */

        /* 
        UInt32 to Int64: Method omitted
        There is a predefined implicit conversion from UInt32 to Int64
        */

        /// <summary>
        /// Converts this UInt64 to Int64 or returns the Int64 default value
        /// </summary>
        /// <returns>This UInt64 converted to Int64</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        /// </remarks>
        public static Int64 ToInt64(this UInt64 thisUInt64)
        {
            return thisUInt64.ToInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt64 to Int64 or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to Int64</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        /// </remarks>
        public static Int64 ToInt64OrDefault(this UInt64 thisUInt64, Int64 defaultValue = default(Int64))
        {
            return thisUInt64.ToInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt64 to Int64?
        /// </summary>
        /// <returns>This UInt64 converted to Int64</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        /// </remarks>
        public static Int64? ToInt64Nullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 9223372036854775807UL) ? (Int64?)null : (Int64)thisUInt64;
        }

        /* 
        Single to Int64: Method omitted.
        Int64 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to Int64: Method omitted.
        Int64 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to Int64: Method omitted.
        Int64 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /// <summary>
        /// Converts and returns this string's value as a nullable Int64.
        /// Null is returned if the value does not successfully parse to Int64.
        /// </summary>
        /// <returns>This string's value converted to a nullable Int64.</returns>
        public static Int64? ToInt64Nullable(this string strThisString)
        {
            Int64 int64Return;
            return Int64.TryParse(strThisString, out int64Return) ? int64Return : (Int64?)null;
        }

        /// <summary>
        /// Converts and returns this string's value as Int64.
        /// The default value passed in is returned if the string does not successfully parse to Int64.
        /// </summary>
        /// <param name="intDefault">Value to return if this string does not parse to Int64.</param>
        /// <returns>This string converted to Int64, or the default value if conversion unsuccessful.</returns>
        public static Int64 ToInt64OrDefault(this string strThisString, Int64 int64Default)
        {
            Int64 int64Return;
            return Int64.TryParse(strThisString, out int64Return) ? int64Return : int64Default;
        }

        /// <summary>
        /// Converts and returns this string's value as Int64.
        /// The default value passed in is returned if the string does not successfully parse to Int64.
        /// </summary>
        /// <returns>This string converted to Int64, or the default value if conversion unsuccessful.</returns>
        public static Int64 ToInt64(this string strThisString, Int64 int64Default = default(Int64))
        {
            Int64 int64Return;
            return Int64.TryParse(strThisString, out int64Return) ? int64Return : int64Default;
        }

    }
}
