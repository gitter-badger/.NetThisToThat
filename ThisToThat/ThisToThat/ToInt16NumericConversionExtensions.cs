
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToInt16Extensions
    {


        /* 
        SByte to Int16: Method omitted
        There is a predefined implicit conversion from SByte to Int16
        */

        /* 
        Byte to Int16: Method omitted
        There is a predefined implicit conversion from Byte to Int16
        */

        /// <summary>
        /// Converts this UInt16 to Int16 or returns the Int16 default value
        /// </summary>
        /// <returns>This UInt16 converted to Int16</returns>
        /// <remarks>
        /// Source type: UInt16
        /// Min value: 0
        /// Max value: 65535
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16 ToInt16(this UInt16 thisUInt16)
        {
            return thisUInt16.ToInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt16 to Int16 or returns the specified default value
        /// </summary>
        /// <returns>This UInt16 converted to Int16</returns>
        /// <remarks>
        /// Source type: UInt16
        /// Min value: 0
        /// Max value: 65535
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16 ToInt16OrDefault(this UInt16 thisUInt16, Int16 defaultValue = default(Int16))
        {
            return thisUInt16.ToInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt16 to Int16?
        /// </summary>
        /// <returns>This UInt16 converted to Int16</returns>
        /// <remarks>
        /// Source type: UInt16
        /// Min value: 0
        /// Max value: 65535
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16? ToInt16Nullable(this UInt16 thisUInt16)
        {
            return (thisUInt16 > (ushort)32767) ? (Int16?)null : (Int16)thisUInt16;
        }

        /// <summary>
        /// Converts this Int32 to Int16 or returns the Int16 default value
        /// </summary>
        /// <returns>This Int32 converted to Int16</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16 ToInt16(this Int32 thisInt32)
        {
            return thisInt32.ToInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int32 to Int16 or returns the specified default value
        /// </summary>
        /// <returns>This Int32 converted to Int16</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16 ToInt16OrDefault(this Int32 thisInt32, Int16 defaultValue = default(Int16))
        {
            return thisInt32.ToInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int32 to Int16?
        /// </summary>
        /// <returns>This Int32 converted to Int16</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16? ToInt16Nullable(this Int32 thisInt32)
        {
            return (thisInt32 < -32768 || thisInt32 > 32767) ? (Int16?)null : (Int16)thisInt32;
        }

        /// <summary>
        /// Converts this UInt32 to Int16 or returns the Int16 default value
        /// </summary>
        /// <returns>This UInt32 converted to Int16</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16 ToInt16(this UInt32 thisUInt32)
        {
            return thisUInt32.ToInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt32 to Int16 or returns the specified default value
        /// </summary>
        /// <returns>This UInt32 converted to Int16</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16 ToInt16OrDefault(this UInt32 thisUInt32, Int16 defaultValue = default(Int16))
        {
            return thisUInt32.ToInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt32 to Int16?
        /// </summary>
        /// <returns>This UInt32 converted to Int16</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16? ToInt16Nullable(this UInt32 thisUInt32)
        {
            return (thisUInt32 > 32767u) ? (Int16?)null : (Int16)thisUInt32;
        }

        /// <summary>
        /// Converts this Int64 to Int16 or returns the Int16 default value
        /// </summary>
        /// <returns>This Int64 converted to Int16</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16 ToInt16(this Int64 thisInt64)
        {
            return thisInt64.ToInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int64 to Int16 or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to Int16</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16 ToInt16OrDefault(this Int64 thisInt64, Int16 defaultValue = default(Int16))
        {
            return thisInt64.ToInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to Int16?
        /// </summary>
        /// <returns>This Int64 converted to Int16</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16? ToInt16Nullable(this Int64 thisInt64)
        {
            return (thisInt64 < -32768L || thisInt64 > 32767L) ? (Int16?)null : (Int16)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to Int16 or returns the Int16 default value
        /// </summary>
        /// <returns>This UInt64 converted to Int16</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16 ToInt16(this UInt64 thisUInt64)
        {
            return thisUInt64.ToInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt64 to Int16 or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to Int16</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16 ToInt16OrDefault(this UInt64 thisUInt64, Int16 defaultValue = default(Int16))
        {
            return thisUInt64.ToInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt64 to Int16?
        /// </summary>
        /// <returns>This UInt64 converted to Int16</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16? ToInt16Nullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 32767UL) ? (Int16?)null : (Int16)thisUInt64;
        }

        /* 
        Single to Int16: Method omitted.
        Int16 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to Int16: Method omitted.
        Int16 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to Int16: Method omitted.
        Int16 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

    }
}
