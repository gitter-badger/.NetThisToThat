using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static class ToByteExtensions
    {

        /// <summary>
        /// Converts this SByte to Byte
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
            return (thisSByte < 0) ? (Byte?)null : (Byte)thisSByte;
        }

        /// <summary>
        /// Converts this Int16 to Byte
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
        /// Converts this UInt16 to Byte
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
        /// Converts this Int32 to Byte
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
        /// Converts this UInt32 to Byte
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
            return (thisUInt32 > 255) ? (Byte?)null : (Byte)thisUInt32;
        }

        /// <summary>
        /// Converts this Int64 to Byte
        /// </summary>
        /// <returns>This Int64 converted to Byte</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this Int64 thisInt64)
        {
            return (thisInt64 < 0 || thisInt64 > 255) ? (Byte?)null : (Byte)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to Byte
        /// </summary>
        /// <returns>This UInt64 converted to Byte</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 255) ? (Byte?)null : (Byte)thisUInt64;
        }

        /// <summary>
        /// Converts this Single to Byte
        /// </summary>
        /// <returns>This Single converted to Byte</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this Single thisSingle)
        {
            return (thisSingle < 0 || thisSingle > 255) ? (Byte?)null : (Byte)thisSingle;
        }

        /// <summary>
        /// Converts this Double to Byte
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
            return (thisDouble < 0 || thisDouble > 255) ? (Byte?)null : (Byte)thisDouble;
        }

        /// <summary>
        /// Converts this Decimal to Byte
        /// </summary>
        /// <returns>This Decimal converted to Byte</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: Byte
        /// Min value: 0
        /// Max value: 255
        /// </remarks>
        public static Byte? ToByteNullable(this Decimal thisDecimal)
        {
            return (thisDecimal < 0 || thisDecimal > 255) ? (Byte?)null : (Byte)thisDecimal;
        }

    }
}
