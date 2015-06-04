
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
        public static Byte? ToByte(this SByte thisSByte)
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
        public static Byte? ToByteOrDefault(this SByte thisSByte, Byte defaultValue = default(Byte))
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
        public static Byte? ToByte(this Int16 thisInt16)
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
        public static Byte? ToByteOrDefault(this Int16 thisInt16, Byte defaultValue = default(Byte))
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
            return (thisInt16 < 0 || thisInt16 > 255) ? (Byte?)null : (Byte)thisInt16;
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
        public static Byte? ToByte(this UInt16 thisUInt16)
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
        public static Byte? ToByteOrDefault(this UInt16 thisUInt16, Byte defaultValue = default(Byte))
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
            return (thisUInt16 > 255) ? (Byte?)null : (Byte)thisUInt16;
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
        public static Byte? ToByte(this Int32 thisInt32)
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
        public static Byte? ToByteOrDefault(this Int32 thisInt32, Byte defaultValue = default(Byte))
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
        public static Byte? ToByte(this UInt32 thisUInt32)
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
        public static Byte? ToByteOrDefault(this UInt32 thisUInt32, Byte defaultValue = default(Byte))
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
        public static Byte? ToByte(this Int64 thisInt64)
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
        public static Byte? ToByteOrDefault(this Int64 thisInt64, Byte defaultValue = default(Byte))
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
        public static Byte? ToByte(this UInt64 thisUInt64)
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
        public static Byte? ToByteOrDefault(this UInt64 thisUInt64, Byte defaultValue = default(Byte))
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

        /// <summary>
        /// Converts this Single to Byte or returns the Byte default value
        /// </summary>
        /// <returns>This Single converted to Byte</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByte(this Single thisSingle)
        {
            return thisSingle.ToByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Single to Byte or returns the specified default value
        /// </summary>
        /// <returns>This Single converted to Byte</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteOrDefault(this Single thisSingle, Byte defaultValue = default(Byte))
        {
            return thisSingle.ToByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Single to Byte?
        /// </summary>
        /// <returns>This Single converted to Byte</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this Single thisSingle)
        {
            return (thisSingle < 0f || thisSingle > 255f) ? (Byte?)null : (Byte)thisSingle;
        }

        /// <summary>
        /// Converts this Double to Byte or returns the Byte default value
        /// </summary>
        /// <returns>This Double converted to Byte</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByte(this Double thisDouble)
        {
            return thisDouble.ToByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Double to Byte or returns the specified default value
        /// </summary>
        /// <returns>This Double converted to Byte</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteOrDefault(this Double thisDouble, Byte defaultValue = default(Byte))
        {
            return thisDouble.ToByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Double to Byte?
        /// </summary>
        /// <returns>This Double converted to Byte</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this Double thisDouble)
        {
            return (thisDouble < 0d || thisDouble > 255d) ? (Byte?)null : (Byte)thisDouble;
        }

        /// <summary>
        /// Converts this Decimal to Byte or returns the Byte default value
        /// </summary>
        /// <returns>This Decimal converted to Byte</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByte(this Decimal thisDecimal)
        {
            return thisDecimal.ToByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Decimal to Byte or returns the specified default value
        /// </summary>
        /// <returns>This Decimal converted to Byte</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteOrDefault(this Decimal thisDecimal, Byte defaultValue = default(Byte))
        {
            return thisDecimal.ToByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Decimal to Byte?
        /// </summary>
        /// <returns>This Decimal converted to Byte</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this Decimal thisDecimal)
        {
            return (thisDecimal < 0m || thisDecimal > 255m) ? (Byte?)null : (Byte)thisDecimal;
        }

    }
}
