
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToUInt32Extensions
    {

        /// <summary>
        /// Converts this SByte to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This SByte converted to UInt32</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32 ToUInt32OrDefault(this SByte thisSByte, UInt32 defaultValue = default(UInt32))
        {
            return thisSByte.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this SByte to UInt32?
        /// </summary>
        /// <returns>This SByte converted to UInt32</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this SByte thisSByte)
        {
            return (thisSByte < (sbyte)0) ? (UInt32?)null : (UInt32)thisSByte;
        }

        /* 
        Byte to UInt32: Method omitted
        There is a predefined implicit conversion from Byte to UInt32
        */

        /// <summary>
        /// Converts this Int16 to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This Int16 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32 ToUInt32OrDefault(this Int16 thisInt16, UInt32 defaultValue = default(UInt32))
        {
            return thisInt16.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int16 to UInt32?
        /// </summary>
        /// <returns>This Int16 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this Int16 thisInt16)
        {
            return (thisInt16 < (short)0) ? (UInt32?)null : (UInt32)thisInt16;
        }

        /* 
        UInt16 to UInt32: Method omitted
        There is a predefined implicit conversion from UInt16 to UInt32
        */

        /// <summary>
        /// Converts this Int32 to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This Int32 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32 ToUInt32OrDefault(this Int32 thisInt32, UInt32 defaultValue = default(UInt32))
        {
            return thisInt32.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int32 to UInt32?
        /// </summary>
        /// <returns>This Int32 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this Int32 thisInt32)
        {
            return (thisInt32 < 0) ? (UInt32?)null : (UInt32)thisInt32;
        }

        /// <summary>
        /// Converts this Int64 to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32 ToUInt32OrDefault(this Int64 thisInt64, UInt32 defaultValue = default(UInt32))
        {
            return thisInt64.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to UInt32?
        /// </summary>
        /// <returns>This Int64 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this Int64 thisInt64)
        {
            return (thisInt64 < 0L || thisInt64 > 4294967295L) ? (UInt32?)null : (UInt32)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to UInt32</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32 ToUInt32OrDefault(this UInt64 thisUInt64, UInt32 defaultValue = default(UInt32))
        {
            return thisUInt64.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt64 to UInt32?
        /// </summary>
        /// <returns>This UInt64 converted to UInt32</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 4294967295UL) ? (UInt32?)null : (UInt32)thisUInt64;
        }

        /* 
        Single to UInt32: Method omitted.
        UInt32 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to UInt32: Method omitted.
        UInt32 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to UInt32: Method omitted.
        UInt32 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /// <summary>
        /// Converts and returns this string's value as a nullable UInt32.
        /// Null is returned if the value does not successfully parse to UInt32.
        /// </summary>
        /// <returns>This string's value converted to a nullable UInt32.</returns>
        public static UInt32? ToUInt32Nullable(this string strThisString)
        {
            UInt32 uint32Return;
            return UInt32.TryParse(strThisString, out uint32Return) ? uint32Return : (UInt32?)null;
        }
        
        /// <summary>
        /// Converts and returns this string's value as UInt32.
        /// The default value passed in is returned if the string does not successfully parse to UInt32.
        /// </summary>
        /// <returns>This string converted to UInt32, or the default value if conversion unsuccessful.</returns>
        public static UInt32 ToUInt32OrDefault(this string strThisString, UInt32 uint32Default = default(UInt32))
        {
            UInt32 uint32Return;
            return UInt32.TryParse(strThisString, out uint32Return) ? uint32Return : uint32Default;
        }

    }
}
