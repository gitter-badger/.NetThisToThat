
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToSByteExtensions
    {

        /// <summary>
        /// Converts this Byte to SByte or returns the specified default value
        /// </summary>
        /// <returns>This Byte converted to SByte</returns>
        /// <remarks>
        /// Source type: Byte
        /// Min value: 0
        /// Max value: 255
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte ToSByteOrDefault(this Byte thisByte, SByte defaultValue = default(SByte))
        {
            return thisByte.ToSByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Byte to SByte?
        /// </summary>
        /// <returns>This Byte converted to SByte</returns>
        /// <remarks>
        /// Source type: Byte
        /// Min value: 0
        /// Max value: 255
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this Byte thisByte)
        {
            return (thisByte > (byte)127) ? (SByte?)null : (SByte)thisByte;
        }

        /// <summary>
        /// Converts this Int16 to SByte or returns the specified default value
        /// </summary>
        /// <returns>This Int16 converted to SByte</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte ToSByteOrDefault(this Int16 thisInt16, SByte defaultValue = default(SByte))
        {
            return thisInt16.ToSByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int16 to SByte?
        /// </summary>
        /// <returns>This Int16 converted to SByte</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this Int16 thisInt16)
        {
            return (thisInt16 < (short)-128 || thisInt16 > (short)127) ? (SByte?)null : (SByte)thisInt16;
        }

        /// <summary>
        /// Converts this UInt16 to SByte or returns the specified default value
        /// </summary>
        /// <returns>This UInt16 converted to SByte</returns>
        /// <remarks>
        /// Source type: UInt16
        /// Min value: 0
        /// Max value: 65535
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte ToSByteOrDefault(this UInt16 thisUInt16, SByte defaultValue = default(SByte))
        {
            return thisUInt16.ToSByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt16 to SByte?
        /// </summary>
        /// <returns>This UInt16 converted to SByte</returns>
        /// <remarks>
        /// Source type: UInt16
        /// Min value: 0
        /// Max value: 65535
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this UInt16 thisUInt16)
        {
            return (thisUInt16 > (ushort)127) ? (SByte?)null : (SByte)thisUInt16;
        }

        /// <summary>
        /// Converts this Int32 to SByte or returns the specified default value
        /// </summary>
        /// <returns>This Int32 converted to SByte</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte ToSByteOrDefault(this Int32 thisInt32, SByte defaultValue = default(SByte))
        {
            return thisInt32.ToSByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int32 to SByte?
        /// </summary>
        /// <returns>This Int32 converted to SByte</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this Int32 thisInt32)
        {
            return (thisInt32 < -128 || thisInt32 > 127) ? (SByte?)null : (SByte)thisInt32;
        }

        /// <summary>
        /// Converts this UInt32 to SByte or returns the specified default value
        /// </summary>
        /// <returns>This UInt32 converted to SByte</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte ToSByteOrDefault(this UInt32 thisUInt32, SByte defaultValue = default(SByte))
        {
            return thisUInt32.ToSByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt32 to SByte?
        /// </summary>
        /// <returns>This UInt32 converted to SByte</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this UInt32 thisUInt32)
        {
            return (thisUInt32 > 127u) ? (SByte?)null : (SByte)thisUInt32;
        }

        /// <summary>
        /// Converts this Int64 to SByte or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to SByte</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte ToSByteOrDefault(this Int64 thisInt64, SByte defaultValue = default(SByte))
        {
            return thisInt64.ToSByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to SByte?
        /// </summary>
        /// <returns>This Int64 converted to SByte</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this Int64 thisInt64)
        {
            return (thisInt64 < -128L || thisInt64 > 127L) ? (SByte?)null : (SByte)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to SByte or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to SByte</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte ToSByteOrDefault(this UInt64 thisUInt64, SByte defaultValue = default(SByte))
        {
            return thisUInt64.ToSByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt64 to SByte?
        /// </summary>
        /// <returns>This UInt64 converted to SByte</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 127UL) ? (SByte?)null : (SByte)thisUInt64;
        }

        /* 
        Single to SByte: Method omitted.
        SByte is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to SByte: Method omitted.
        SByte is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to SByte: Method omitted.
        SByte is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /// <summary>
        /// Converts and returns this string's value as a nullable SByte.
        /// Null is returned if the value does not successfully parse to SByte.
        /// </summary>
        /// <returns>This string's value converted to a nullable SByte.</returns>
        public static SByte? ToSByteNullable(this string strThisString)
        {
            SByte sbyteReturn;
            return SByte.TryParse(strThisString, out sbyteReturn) ? sbyteReturn : (SByte?)null;
        }
        
        /// <summary>
        /// Converts and returns this string's value as SByte.
        /// The default value passed in is returned if the string does not successfully parse to SByte.
        /// </summary>
        /// <returns>This string converted to SByte, or the default value if conversion unsuccessful.</returns>
        public static SByte ToSByteOrDefault(this string strThisString, SByte sbyteDefault = default(SByte))
        {
            SByte sbyteReturn;
            return SByte.TryParse(strThisString, out sbyteReturn) ? sbyteReturn : sbyteDefault;
        }

    }
}
