
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToUInt16Extensions
    {

        /// <summary>
        /// Converts this SByte to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This SByte converted to UInt16</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16 ToUInt16OrDefault(this SByte thisSByte, UInt16 defaultValue = default(UInt16))
        {
            return thisSByte.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this SByte to UInt16?
        /// </summary>
        /// <returns>This SByte converted to UInt16</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this SByte thisSByte)
        {
            return (thisSByte < (sbyte)0) ? (UInt16?)null : (UInt16)thisSByte;
        }

        /* 
        Byte to UInt16: Method omitted
        There is a predefined implicit conversion from Byte to UInt16
        */

        /// <summary>
        /// Converts this Int16 to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This Int16 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16 ToUInt16OrDefault(this Int16 thisInt16, UInt16 defaultValue = default(UInt16))
        {
            return thisInt16.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int16 to UInt16?
        /// </summary>
        /// <returns>This Int16 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this Int16 thisInt16)
        {
            return (thisInt16 < (short)0) ? (UInt16?)null : (UInt16)thisInt16;
        }

        /// <summary>
        /// Converts this Int32 to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This Int32 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16 ToUInt16OrDefault(this Int32 thisInt32, UInt16 defaultValue = default(UInt16))
        {
            return thisInt32.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int32 to UInt16?
        /// </summary>
        /// <returns>This Int32 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this Int32 thisInt32)
        {
            return (thisInt32 < 0 || thisInt32 > 65535) ? (UInt16?)null : (UInt16)thisInt32;
        }

        /// <summary>
        /// Converts this UInt32 to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This UInt32 converted to UInt16</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16 ToUInt16OrDefault(this UInt32 thisUInt32, UInt16 defaultValue = default(UInt16))
        {
            return thisUInt32.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt32 to UInt16?
        /// </summary>
        /// <returns>This UInt32 converted to UInt16</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this UInt32 thisUInt32)
        {
            return (thisUInt32 > 65535u) ? (UInt16?)null : (UInt16)thisUInt32;
        }

        /// <summary>
        /// Converts this Int64 to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16 ToUInt16OrDefault(this Int64 thisInt64, UInt16 defaultValue = default(UInt16))
        {
            return thisInt64.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to UInt16?
        /// </summary>
        /// <returns>This Int64 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this Int64 thisInt64)
        {
            return (thisInt64 < 0L || thisInt64 > 65535L) ? (UInt16?)null : (UInt16)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to UInt16</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16 ToUInt16OrDefault(this UInt64 thisUInt64, UInt16 defaultValue = default(UInt16))
        {
            return thisUInt64.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt64 to UInt16?
        /// </summary>
        /// <returns>This UInt64 converted to UInt16</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 65535UL) ? (UInt16?)null : (UInt16)thisUInt64;
        }

        /* 
        Single to UInt16: Method omitted.
        UInt16 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to UInt16: Method omitted.
        UInt16 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to UInt16: Method omitted.
        UInt16 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /// <summary>
        /// Converts and returns this string's value as a nullable UInt16.
        /// Null is returned if the value does not successfully parse to UInt16.
        /// </summary>
        /// <returns>This string's value converted to a nullable UInt16.</returns>
        public static UInt16? ToUInt16Nullable(this string strThisString)
        {
            UInt16 uint16Return;
            return UInt16.TryParse(strThisString, out uint16Return) ? uint16Return : (UInt16?)null;
        }
        
        /// <summary>
        /// Converts and returns this string's value as UInt16.
        /// The default value passed in is returned if the string does not successfully parse to UInt16.
        /// </summary>
        /// <returns>This string converted to UInt16, or the default value if conversion unsuccessful.</returns>
        public static UInt16 ToUInt16OrDefault(this string strThisString, UInt16 uint16Default = default(UInt16))
        {
            UInt16 uint16Return;
            return UInt16.TryParse(strThisString, out uint16Return) ? uint16Return : uint16Default;
        }

    }
}
