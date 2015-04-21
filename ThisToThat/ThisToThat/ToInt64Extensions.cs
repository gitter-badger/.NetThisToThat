using System;
using System.Collections.Generic;
using System.Text;


namespace ThisToThat
{
    public static class ToInt64Extensions
    {
        /* 
        SByte to Int64: Method omitted
        There is a predefined implicit conversion from SByte to Int64
        */

        /* 
        Byte to Int64: Method omitted
        There is a predefined implicit conversion from Byte to Int64
        */

        /* 
        Int16 to Int64: Method omitted
        There is a predefined implicit conversion from Int16 to Int64
        */

        /* 
        UInt16 to Int64: Method omitted
        There is a predefined implicit conversion from UInt16 to Int64
        */

        /* 
        Int32 to Int64: Method omitted
        There is a predefined implicit conversion from Int32 to Int64
        */

        /* 
        UInt32 to Int64: Method omitted
        There is a predefined implicit conversion from UInt32 to Int64
        */

        /// <summary>
        /// Converts this UInt64 to Int64 or returns the Int64 default value
        /// </summary>
        /// <returns>This UInt64 converted to Int64</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64(this UInt64 thisUInt64)
        {
            return thisUInt64.ToInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt64 to Int64 or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to Int64</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64OrDefault(this UInt64 thisUInt64, Int64 defaultValue = default(Int64))
        {
            return thisUInt64.ToInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt64 to Int64?
        /// </summary>
        /// <returns>This UInt64 converted to Int64</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64Nullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 9.22337203685478E+18) ? (Int64?)null : (Int64)thisUInt64;
        }

        /// <summary>
        /// Converts this Single to Int64 or returns the Int64 default value
        /// </summary>
        /// <returns>This Single converted to Int64</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64(this Single thisSingle)
        {
            return thisSingle.ToInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Single to Int64 or returns the specified default value
        /// </summary>
        /// <returns>This Single converted to Int64</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64OrDefault(this Single thisSingle, Int64 defaultValue = default(Int64))
        {
            return thisSingle.ToInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Single to Int64?
        /// </summary>
        /// <returns>This Single converted to Int64</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64Nullable(this Single thisSingle)
        {
            return (thisSingle < -9.22337203685478E+18 || thisSingle > 9.22337203685478E+18) ? (Int64?)null : (Int64)thisSingle;
        }

        /// <summary>
        /// Converts this Double to Int64 or returns the Int64 default value
        /// </summary>
        /// <returns>This Double converted to Int64</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64(this Double thisDouble)
        {
            return thisDouble.ToInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Double to Int64 or returns the specified default value
        /// </summary>
        /// <returns>This Double converted to Int64</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64OrDefault(this Double thisDouble, Int64 defaultValue = default(Int64))
        {
            return thisDouble.ToInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Double to Int64?
        /// </summary>
        /// <returns>This Double converted to Int64</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64Nullable(this Double thisDouble)
        {
            return (thisDouble < -9.22337203685478E+18 || thisDouble > 9.22337203685478E+18) ? (Int64?)null : (Int64)thisDouble;
        }

        /// <summary>
        /// Converts this Decimal to Int64 or returns the Int64 default value
        /// </summary>
        /// <returns>This Decimal converted to Int64</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64(this Decimal thisDecimal)
        {
            return thisDecimal.ToInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Decimal to Int64 or returns the specified default value
        /// </summary>
        /// <returns>This Decimal converted to Int64</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64OrDefault(this Decimal thisDecimal, Int64 defaultValue = default(Int64))
        {
            return thisDecimal.ToInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Decimal to Int64?
        /// </summary>
        /// <returns>This Decimal converted to Int64</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        /// </remarks>
        public static Int64? ToInt64Nullable(this Decimal thisDecimal)
        {
            return ((double)thisDecimal < -9.22337203685478E+18 || (double)thisDecimal > 9.22337203685478E+18) ? (Int64?)null : (Int64)thisDecimal;
        }


    }
}
