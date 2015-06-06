
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToByteExtensions
    {

        /// <summary>
        /// Converts this SByte to Byte or returns the Byte default value
        /// </summary>
        /// <returns>This SByte converted to Byte</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByte(this SByte thisSByte)
        {
            return thisSByte.ToByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this SByte to Byte or returns the specified default value
        /// </summary>
        /// <returns>This SByte converted to Byte</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByteOrDefault(this SByte thisSByte, Byte defaultValue = default(Byte))
        {
            return thisSByte.ToByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this SByte to Byte?
        /// </summary>
        /// <returns>This SByte converted to Byte</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this SByte thisSByte)
        {
            return (thisSByte < (sbyte)0) ? (Byte?)null : (Byte)thisSByte;
        }

        /// <summary>
        /// Converts this Int16 to Byte or returns the Byte default value
        /// </summary>
        /// <returns>This Int16 converted to Byte</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByte(this Int16 thisInt16)
        {
            return thisInt16.ToByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int16 to Byte or returns the specified default value
        /// </summary>
        /// <returns>This Int16 converted to Byte</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByteOrDefault(this Int16 thisInt16, Byte defaultValue = default(Byte))
        {
            return thisInt16.ToByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int16 to Byte?
        /// </summary>
        /// <returns>This Int16 converted to Byte</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this Int16 thisInt16)
        {
            return (thisInt16 < (short)0 || thisInt16 > (short)255) ? (Byte?)null : (Byte)thisInt16;
        }

        /// <summary>
        /// Converts this UInt16 to Byte or returns the Byte default value
        /// </summary>
        /// <returns>This UInt16 converted to Byte</returns>
        /// <remarks>
        /// Source type: UInt16
        /// Min value: 0
        /// Max value: 65535
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByte(this UInt16 thisUInt16)
        {
            return thisUInt16.ToByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt16 to Byte or returns the specified default value
        /// </summary>
        /// <returns>This UInt16 converted to Byte</returns>
        /// <remarks>
        /// Source type: UInt16
        /// Min value: 0
        /// Max value: 65535
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByteOrDefault(this UInt16 thisUInt16, Byte defaultValue = default(Byte))
        {
            return thisUInt16.ToByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt16 to Byte?
        /// </summary>
        /// <returns>This UInt16 converted to Byte</returns>
        /// <remarks>
        /// Source type: UInt16
        /// Min value: 0
        /// Max value: 65535
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this UInt16 thisUInt16)
        {
            return (thisUInt16 > (ushort)255) ? (Byte?)null : (Byte)thisUInt16;
        }

        /// <summary>
        /// Converts this Int32 to Byte or returns the Byte default value
        /// </summary>
        /// <returns>This Int32 converted to Byte</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByte(this Int32 thisInt32)
        {
            return thisInt32.ToByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int32 to Byte or returns the specified default value
        /// </summary>
        /// <returns>This Int32 converted to Byte</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByteOrDefault(this Int32 thisInt32, Byte defaultValue = default(Byte))
        {
            return thisInt32.ToByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int32 to Byte?
        /// </summary>
        /// <returns>This Int32 converted to Byte</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this Int32 thisInt32)
        {
            return (thisInt32 < 0 || thisInt32 > 255) ? (Byte?)null : (Byte)thisInt32;
        }

        /// <summary>
        /// Converts this UInt32 to Byte or returns the Byte default value
        /// </summary>
        /// <returns>This UInt32 converted to Byte</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByte(this UInt32 thisUInt32)
        {
            return thisUInt32.ToByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt32 to Byte or returns the specified default value
        /// </summary>
        /// <returns>This UInt32 converted to Byte</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByteOrDefault(this UInt32 thisUInt32, Byte defaultValue = default(Byte))
        {
            return thisUInt32.ToByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt32 to Byte?
        /// </summary>
        /// <returns>This UInt32 converted to Byte</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this UInt32 thisUInt32)
        {
            return (thisUInt32 > 255u) ? (Byte?)null : (Byte)thisUInt32;
        }

        /// <summary>
        /// Converts this Int64 to Byte or returns the Byte default value
        /// </summary>
        /// <returns>This Int64 converted to Byte</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByte(this Int64 thisInt64)
        {
            return thisInt64.ToByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int64 to Byte or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to Byte</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByteOrDefault(this Int64 thisInt64, Byte defaultValue = default(Byte))
        {
            return thisInt64.ToByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to Byte?
        /// </summary>
        /// <returns>This Int64 converted to Byte</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this Int64 thisInt64)
        {
            return (thisInt64 < 0L || thisInt64 > 255L) ? (Byte?)null : (Byte)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to Byte or returns the Byte default value
        /// </summary>
        /// <returns>This UInt64 converted to Byte</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByte(this UInt64 thisUInt64)
        {
            return thisUInt64.ToByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt64 to Byte or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to Byte</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte ToByteOrDefault(this UInt64 thisUInt64, Byte defaultValue = default(Byte))
        {
            return thisUInt64.ToByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt64 to Byte?
        /// </summary>
        /// <returns>This UInt64 converted to Byte</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 255UL) ? (Byte?)null : (Byte)thisUInt64;
        }

        /* 
        Single to Byte: Method omitted.
        Byte is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to Byte: Method omitted.
        Byte is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to Byte: Method omitted.
        Byte is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /// <summary>
        /// Converts and returns this string's value as a nullable Byte.
        /// Null is returned if the value does not successfully parse to Byte.
        /// </summary>
        /// <returns>This string's value converted to a nullable Byte.</returns>
        public static Byte? ToByteNullable(this string strThisString)
        {
            Byte byteReturn;
            return Byte.TryParse(strThisString, out byteReturn) ? byteReturn : (Byte?)null;
        }

        /// <summary>
        /// Converts and returns this string's value as Byte.
        /// The default value passed in is returned if the string does not successfully parse to Byte.
        /// </summary>
        /// <param name="intDefault">Value to return if this string does not parse to Byte.</param>
        /// <returns>This string converted to Byte, or the default value if conversion unsuccessful.</returns>
        public static Byte ToByteOrDefault(this string strThisString, Byte byteDefault)
        {
            Byte byteReturn;
            return Byte.TryParse(strThisString, out byteReturn) ? byteReturn : byteDefault;
        }

        /// <summary>
        /// Converts and returns this string's value as Byte.
        /// The default value passed in is returned if the string does not successfully parse to Byte.
        /// </summary>
        /// <returns>This string converted to Byte, or the default value if conversion unsuccessful.</returns>
        public static Byte ToByte(this string strThisString, Byte byteDefault = default(Byte))
        {
            Byte byteReturn;
            return Byte.TryParse(strThisString, out byteReturn) ? byteReturn : byteDefault;
        }

    }
}
