
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToInt32Extensions
    {

        /* 
        SByte to Int32: Method omitted
        There is a predefined implicit conversion from SByte to Int32
        */

        /* 
        Byte to Int32: Method omitted
        There is a predefined implicit conversion from Byte to Int32
        */

        /* 
        Int16 to Int32: Method omitted
        There is a predefined implicit conversion from Int16 to Int32
        */

        /* 
        UInt16 to Int32: Method omitted
        There is a predefined implicit conversion from UInt16 to Int32
        */

        /// <summary>
        /// Converts this UInt32 to Int32 or returns the specified default value
        /// </summary>
        /// <returns>This UInt32 converted to Int32</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32 ToInt32OrDefault(this UInt32 thisUInt32, Int32 defaultValue = default(Int32))
        {
            return thisUInt32.ToInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt32 to Int32?
        /// </summary>
        /// <returns>This UInt32 converted to Int32</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this UInt32 thisUInt32)
        {
            return (thisUInt32 > 2147483647u) ? (Int32?)null : (Int32)thisUInt32;
        }

        /// <summary>
        /// Converts this Int64 to Int32 or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to Int32</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32 ToInt32OrDefault(this Int64 thisInt64, Int32 defaultValue = default(Int32))
        {
            return thisInt64.ToInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to Int32?
        /// </summary>
        /// <returns>This Int64 converted to Int32</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this Int64 thisInt64)
        {
            return (thisInt64 < -2147483648L || thisInt64 > 2147483647L) ? (Int32?)null : (Int32)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to Int32 or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to Int32</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32 ToInt32OrDefault(this UInt64 thisUInt64, Int32 defaultValue = default(Int32))
        {
            return thisUInt64.ToInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt64 to Int32?
        /// </summary>
        /// <returns>This UInt64 converted to Int32</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 2147483647UL) ? (Int32?)null : (Int32)thisUInt64;
        }

        /* 
        Single to Int32: Method omitted.
        Int32 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to Int32: Method omitted.
        Int32 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to Int32: Method omitted.
        Int32 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /// <summary>
        /// Converts and returns this string's value as a nullable Int32.
        /// Null is returned if the value does not successfully parse to Int32.
        /// </summary>
        /// <returns>This string's value converted to a nullable Int32.</returns>
        public static Int32? ToInt32Nullable(this string strThisString)
        {
            Int32 int32Return;
            return Int32.TryParse(strThisString, out int32Return) ? int32Return : (Int32?)null;
        }
        
        /// <summary>
        /// Converts and returns this string's value as Int32.
        /// The default value passed in is returned if the string does not successfully parse to Int32.
        /// </summary>
        /// <returns>This string converted to Int32, or the default value if conversion unsuccessful.</returns>
        public static Int32 ToInt32OrDefault(this string strThisString, Int32 int32Default = default(Int32))
        {
            Int32 int32Return;
            return Int32.TryParse(strThisString, out int32Return) ? int32Return : int32Default;
        }

    }
}
