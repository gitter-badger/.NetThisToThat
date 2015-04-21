using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static class ToUInt64Extensions
    {


        /// <summary>
        /// Converts this SByte to UInt64 or returns the UInt64 default value
        /// </summary>
        /// <returns>This SByte converted to UInt64</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64(this SByte thisSByte)
        {
            return thisSByte.ToUInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this SByte to UInt64 or returns the specified default value
        /// </summary>
        /// <returns>This SByte converted to UInt64</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64OrDefault(this SByte thisSByte, UInt64 defaultValue = default(UInt64))
        {
            return thisSByte.ToUInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this SByte to UInt64?
        /// </summary>
        /// <returns>This SByte converted to UInt64</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64Nullable(this SByte thisSByte)
        {
            return (thisSByte < 0) ? (UInt64?)null : (UInt64)thisSByte;
        }

        /* 
        Byte to UInt64: Method omitted
        There is a predefined implicit conversion from Byte to UInt64
        */

        /// <summary>
        /// Converts this Int16 to UInt64 or returns the UInt64 default value
        /// </summary>
        /// <returns>This Int16 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64(this Int16 thisInt16)
        {
            return thisInt16.ToUInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int16 to UInt64 or returns the specified default value
        /// </summary>
        /// <returns>This Int16 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64OrDefault(this Int16 thisInt16, UInt64 defaultValue = default(UInt64))
        {
            return thisInt16.ToUInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int16 to UInt64?
        /// </summary>
        /// <returns>This Int16 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64Nullable(this Int16 thisInt16)
        {
            return (thisInt16 < 0) ? (UInt64?)null : (UInt64)thisInt16;
        }

        /* 
        UInt16 to UInt64: Method omitted
        There is a predefined implicit conversion from UInt16 to UInt64
        */

        /// <summary>
        /// Converts this Int32 to UInt64 or returns the UInt64 default value
        /// </summary>
        /// <returns>This Int32 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64(this Int32 thisInt32)
        {
            return thisInt32.ToUInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int32 to UInt64 or returns the specified default value
        /// </summary>
        /// <returns>This Int32 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64OrDefault(this Int32 thisInt32, UInt64 defaultValue = default(UInt64))
        {
            return thisInt32.ToUInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int32 to UInt64?
        /// </summary>
        /// <returns>This Int32 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64Nullable(this Int32 thisInt32)
        {
            return (thisInt32 < 0) ? (UInt64?)null : (UInt64)thisInt32;
        }

        /* 
        UInt32 to UInt64: Method omitted
        There is a predefined implicit conversion from UInt32 to UInt64
        */

        /// <summary>
        /// Converts this Int64 to UInt64 or returns the UInt64 default value
        /// </summary>
        /// <returns>This Int64 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64(this Int64 thisInt64)
        {
            return thisInt64.ToUInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int64 to UInt64 or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64OrDefault(this Int64 thisInt64, UInt64 defaultValue = default(UInt64))
        {
            return thisInt64.ToUInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to UInt64?
        /// </summary>
        /// <returns>This Int64 converted to UInt64</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64Nullable(this Int64 thisInt64)
        {
            return (thisInt64 < 0) ? (UInt64?)null : (UInt64)thisInt64;
        }

        /// <summary>
        /// Converts this Single to UInt64 or returns the UInt64 default value
        /// </summary>
        /// <returns>This Single converted to UInt64</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64(this Single thisSingle)
        {
            return thisSingle.ToUInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Single to UInt64 or returns the specified default value
        /// </summary>
        /// <returns>This Single converted to UInt64</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64OrDefault(this Single thisSingle, UInt64 defaultValue = default(UInt64))
        {
            return thisSingle.ToUInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Single to UInt64?
        /// </summary>
        /// <returns>This Single converted to UInt64</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64Nullable(this Single thisSingle)
        {
            return (thisSingle < 0 || thisSingle > 1.84467440737096E+19) ? (UInt64?)null : (UInt64)thisSingle;
        }

        /// <summary>
        /// Converts this Double to UInt64 or returns the UInt64 default value
        /// </summary>
        /// <returns>This Double converted to UInt64</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64(this Double thisDouble)
        {
            return thisDouble.ToUInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Double to UInt64 or returns the specified default value
        /// </summary>
        /// <returns>This Double converted to UInt64</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64OrDefault(this Double thisDouble, UInt64 defaultValue = default(UInt64))
        {
            return thisDouble.ToUInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Double to UInt64?
        /// </summary>
        /// <returns>This Double converted to UInt64</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64Nullable(this Double thisDouble)
        {
            return (thisDouble < 0 || thisDouble > 1.84467440737096E+19) ? (UInt64?)null : (UInt64)thisDouble;
        }

        /// <summary>
        /// Converts this Decimal to UInt64 or returns the UInt64 default value
        /// </summary>
        /// <returns>This Decimal converted to UInt64</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64(this Decimal thisDecimal)
        {
            return thisDecimal.ToUInt64Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Decimal to UInt64 or returns the specified default value
        /// </summary>
        /// <returns>This Decimal converted to UInt64</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64OrDefault(this Decimal thisDecimal, UInt64 defaultValue = default(UInt64))
        {
            return thisDecimal.ToUInt64Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Decimal to UInt64?
        /// </summary>
        /// <returns>This Decimal converted to UInt64</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        /// </remarks>
        public static UInt64? ToUInt64Nullable(this Decimal thisDecimal)
        {
            return ((double)thisDecimal < 0 || (double)thisDecimal > 1.84467440737096E+19) ? (UInt64?)null : (UInt64)thisDecimal;
        }

    }
}
