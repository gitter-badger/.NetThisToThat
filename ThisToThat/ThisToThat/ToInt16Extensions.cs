using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static class ToInt16Extensions
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
        /// Converts this UInt16 to Int16
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
            return (thisUInt16 > 32767) ? (Int16?)null : (Int16)thisUInt16;
        }

        /// <summary>
        /// Converts this Int32 to Int16
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
        /// Converts this UInt32 to Int16
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
            return (thisUInt32 > 32767) ? (Int16?)null : (Int16)thisUInt32;
        }

        /// <summary>
        /// Converts this Int64 to Int16
        /// </summary>
        /// <returns>This Int64 converted to Int16</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16? ToInt16Nullable(this Int64 thisInt64)
        {
            return (thisInt64 < -32768 || thisInt64 > 32767) ? (Int16?)null : (Int16)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to Int16
        /// </summary>
        /// <returns>This UInt64 converted to Int16</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16? ToInt16Nullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 32767) ? (Int16?)null : (Int16)thisUInt64;
        }

        /// <summary>
        /// Converts this Single to Int16
        /// </summary>
        /// <returns>This Single converted to Int16</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16? ToInt16Nullable(this Single thisSingle)
        {
            return (thisSingle < -32768 || thisSingle > 32767) ? (Int16?)null : (Int16)thisSingle;
        }

        /// <summary>
        /// Converts this Double to Int16
        /// </summary>
        /// <returns>This Double converted to Int16</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16? ToInt16Nullable(this Double thisDouble)
        {
            return (thisDouble < -32768 || thisDouble > 32767) ? (Int16?)null : (Int16)thisDouble;
        }

        /// <summary>
        /// Converts this Decimal to Int16
        /// </summary>
        /// <returns>This Decimal converted to Int16</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: Int16
        /// Min value: -32768
        /// Max value: 32767
        /// </remarks>
        public static Int16? ToInt16Nullable(this Decimal thisDecimal)
        {
            return (thisDecimal < -32768 || thisDecimal > 32767) ? (Int16?)null : (Int16)thisDecimal;
        }

    }
}
