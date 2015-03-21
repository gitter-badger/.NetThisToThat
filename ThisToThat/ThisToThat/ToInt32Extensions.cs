using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static class ToInt32Extensions
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
        /// Converts this UInt32 to Int32
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
            return (thisUInt32 > 2147483647) ? (Int32?)null : (Int32)thisUInt32;
        }

        /// <summary>
        /// Converts this Int64 to Int32
        /// </summary>
        /// <returns>This Int64 converted to Int32</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this Int64 thisInt64)
        {
            return (thisInt64 < -2147483648 || thisInt64 > 2147483647) ? (Int32?)null : (Int32)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to Int32
        /// </summary>
        /// <returns>This UInt64 converted to Int32</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 2147483647) ? (Int32?)null : (Int32)thisUInt64;
        }

        /// <summary>
        /// Converts this Single to Int32
        /// </summary>
        /// <returns>This Single converted to Int32</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this Single thisSingle)
        {
            return (thisSingle < -2147483648 || thisSingle > 2147483647) ? (Int32?)null : (Int32)thisSingle;
        }

        /// <summary>
        /// Converts this Double to Int32
        /// </summary>
        /// <returns>This Double converted to Int32</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this Double thisDouble)
        {
            return (thisDouble < -2147483648 || thisDouble > 2147483647) ? (Int32?)null : (Int32)thisDouble;
        }

        /// <summary>
        /// Converts this Decimal to Int32
        /// </summary>
        /// <returns>This Decimal converted to Int32</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this Decimal thisDecimal)
        {
            return (thisDecimal < -2147483648 || thisDecimal > 2147483647) ? (Int32?)null : (Int32)thisDecimal;
        }

    }
}
