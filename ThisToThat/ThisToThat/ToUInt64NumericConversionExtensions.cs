
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToUInt64Extensions
    {

        /// <summary>
        /// Converts this SByte to UInt64 or returns the UInt64 default value
        /// </summary>
        /// <returns>This SByte converted to UInt64</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64 ToUInt64(this SByte thisSByte)
        {
            return thisSByte.ToUInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this SByte to UInt64 or returns the specified default value
        /// </summary>
        /// <returns>This SByte converted to UInt64</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64 ToUInt64OrDefault(this SByte thisSByte, UInt64 defaultValue = default(UInt64))
        {
            return thisSByte.ToUInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this SByte to UInt64?
        /// </summary>
        /// <returns>This SByte converted to UInt64</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64? ToUInt64Nullable(this SByte thisSByte)
        {
            return (thisSByte < (sbyte)0) ? (UInt64?)null : (UInt64)thisSByte;
        }

        /* 
        Byte to UInt64: Method omitted
        There is a predefined implicit conversion from Byte to UInt64
        */

        /// <summary>
        /// Converts this Int16 to UInt64 or returns the UInt64 default value
        /// </summary>
        /// <returns>This Int16 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64 ToUInt64(this Int16 thisInt16)
        {
            return thisInt16.ToUInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int16 to UInt64 or returns the specified default value
        /// </summary>
        /// <returns>This Int16 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64 ToUInt64OrDefault(this Int16 thisInt16, UInt64 defaultValue = default(UInt64))
        {
            return thisInt16.ToUInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int16 to UInt64?
        /// </summary>
        /// <returns>This Int16 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64? ToUInt64Nullable(this Int16 thisInt16)
        {
            return (thisInt16 < (short)0) ? (UInt64?)null : (UInt64)thisInt16;
        }

        /* 
        UInt16 to UInt64: Method omitted
        There is a predefined implicit conversion from UInt16 to UInt64
        */

        /// <summary>
        /// Converts this Int32 to UInt64 or returns the UInt64 default value
        /// </summary>
        /// <returns>This Int32 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64 ToUInt64(this Int32 thisInt32)
        {
            return thisInt32.ToUInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int32 to UInt64 or returns the specified default value
        /// </summary>
        /// <returns>This Int32 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64 ToUInt64OrDefault(this Int32 thisInt32, UInt64 defaultValue = default(UInt64))
        {
            return thisInt32.ToUInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int32 to UInt64?
        /// </summary>
        /// <returns>This Int32 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64? ToUInt64Nullable(this Int32 thisInt32)
        {
            return (thisInt32 < 0) ? (UInt64?)null : (UInt64)thisInt32;
        }

        /* 
        UInt32 to UInt64: Method omitted
        There is a predefined implicit conversion from UInt32 to UInt64
        */

        /// <summary>
        /// Converts this Int64 to UInt64 or returns the UInt64 default value
        /// </summary>
        /// <returns>This Int64 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64 ToUInt64(this Int64 thisInt64)
        {
            return thisInt64.ToUInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int64 to UInt64 or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64 ToUInt64OrDefault(this Int64 thisInt64, UInt64 defaultValue = default(UInt64))
        {
            return thisInt64.ToUInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to UInt64?
        /// </summary>
        /// <returns>This Int64 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        /// </remarks>
        public static UInt64? ToUInt64Nullable(this Int64 thisInt64)
        {
            return (thisInt64 < 0L) ? (UInt64?)null : (UInt64)thisInt64;
        }

        /* 
        Single to UInt64: Method omitted.
        UInt64 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to UInt64: Method omitted.
        UInt64 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to UInt64: Method omitted.
        UInt64 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /// <summary>
        /// Converts and returns this string's value as a nullable UInt64.
        /// Null is returned if the value does not successfully parse to UInt64.
        /// </summary>
        /// <returns>This string's value converted to a nullable UInt64.</returns>
        public static UInt64? ToUInt64Nullable(this string strThisString)
        {
            UInt64 uint64Return;
            return UInt64.TryParse(strThisString, out uint64Return) ? uint64Return : (UInt64?)null;
        }

        /// <summary>
        /// Converts and returns this string's value as UInt64.
        /// The default value passed in is returned if the string does not successfully parse to UInt64.
        /// </summary>
        /// <param name="intDefault">Value to return if this string does not parse to UInt64.</param>
        /// <returns>This string converted to UInt64, or the default value if conversion unsuccessful.</returns>
        public static UInt64 ToUInt64OrDefault(this string strThisString, UInt64 uint64Default)
        {
            UInt64 uint64Return;
            return UInt64.TryParse(strThisString, out uint64Return) ? uint64Return : uint64Default;
        }

        /// <summary>
        /// Converts and returns this string's value as UInt64.
        /// The default value passed in is returned if the string does not successfully parse to UInt64.
        /// </summary>
        /// <returns>This string converted to UInt64, or the default value if conversion unsuccessful.</returns>
        public static UInt64 ToUInt64(this string strThisString, UInt64 uint64Default = default(UInt64))
        {
            UInt64 uint64Return;
            return UInt64.TryParse(strThisString, out uint64Return) ? uint64Return : uint64Default;
        }

    }
}
