using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static class ToUInt32Extensions
    {


        /// <summary>
        /// Converts this SByte to UInt32 or returns the UInt32 default value
        /// </summary>
        /// <returns>This SByte converted to UInt32</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32(this SByte thisSByte)
        {
            return thisSByte.ToUInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this SByte to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This SByte converted to UInt32</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32OrDefault(this SByte thisSByte, UInt32 defaultValue = default(UInt32))
        {
            return thisSByte.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this SByte to UInt32?
        /// </summary>
        /// <returns>This SByte converted to UInt32</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this SByte thisSByte)
        {
            return (thisSByte < 0) ? (UInt32?)null : (UInt32)thisSByte;
        }

        /* 
        Byte to UInt32: Method omitted
        There is a predefined implicit conversion from Byte to UInt32
        */

        /// <summary>
        /// Converts this Int16 to UInt32 or returns the UInt32 default value
        /// </summary>
        /// <returns>This Int16 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32(this Int16 thisInt16)
        {
            return thisInt16.ToUInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int16 to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This Int16 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32OrDefault(this Int16 thisInt16, UInt32 defaultValue = default(UInt32))
        {
            return thisInt16.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int16 to UInt32?
        /// </summary>
        /// <returns>This Int16 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this Int16 thisInt16)
        {
            return (thisInt16 < 0) ? (UInt32?)null : (UInt32)thisInt16;
        }

        /* 
        UInt16 to UInt32: Method omitted
        There is a predefined implicit conversion from UInt16 to UInt32
        */

        /// <summary>
        /// Converts this Int32 to UInt32 or returns the UInt32 default value
        /// </summary>
        /// <returns>This Int32 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32(this Int32 thisInt32)
        {
            return thisInt32.ToUInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int32 to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This Int32 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32OrDefault(this Int32 thisInt32, UInt32 defaultValue = default(UInt32))
        {
            return thisInt32.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int32 to UInt32?
        /// </summary>
        /// <returns>This Int32 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this Int32 thisInt32)
        {
            return (thisInt32 < 0) ? (UInt32?)null : (UInt32)thisInt32;
        }

        /// <summary>
        /// Converts this Int64 to UInt32 or returns the UInt32 default value
        /// </summary>
        /// <returns>This Int64 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32(this Int64 thisInt64)
        {
            return thisInt64.ToUInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int64 to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32OrDefault(this Int64 thisInt64, UInt32 defaultValue = default(UInt32))
        {
            return thisInt64.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to UInt32?
        /// </summary>
        /// <returns>This Int64 converted to UInt32</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this Int64 thisInt64)
        {
            return (thisInt64 < 0 || thisInt64 > 4294967295) ? (UInt32?)null : (UInt32)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to UInt32 or returns the UInt32 default value
        /// </summary>
        /// <returns>This UInt64 converted to UInt32</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32(this UInt64 thisUInt64)
        {
            return thisUInt64.ToUInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt64 to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to UInt32</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32OrDefault(this UInt64 thisUInt64, UInt32 defaultValue = default(UInt32))
        {
            return thisUInt64.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt64 to UInt32?
        /// </summary>
        /// <returns>This UInt64 converted to UInt32</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 4294967295) ? (UInt32?)null : (UInt32)thisUInt64;
        }

        /// <summary>
        /// Converts this Single to UInt32 or returns the UInt32 default value
        /// </summary>
        /// <returns>This Single converted to UInt32</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32(this Single thisSingle)
        {
            return thisSingle.ToUInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Single to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This Single converted to UInt32</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32OrDefault(this Single thisSingle, UInt32 defaultValue = default(UInt32))
        {
            return thisSingle.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Single to UInt32?
        /// </summary>
        /// <returns>This Single converted to UInt32</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this Single thisSingle)
        {
            return (thisSingle < 0 || thisSingle > 4294967295) ? (UInt32?)null : (UInt32)thisSingle;
        }

        /// <summary>
        /// Converts this Double to UInt32 or returns the UInt32 default value
        /// </summary>
        /// <returns>This Double converted to UInt32</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32(this Double thisDouble)
        {
            return thisDouble.ToUInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Double to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This Double converted to UInt32</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32OrDefault(this Double thisDouble, UInt32 defaultValue = default(UInt32))
        {
            return thisDouble.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Double to UInt32?
        /// </summary>
        /// <returns>This Double converted to UInt32</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this Double thisDouble)
        {
            return (thisDouble < 0 || thisDouble > 4294967295) ? (UInt32?)null : (UInt32)thisDouble;
        }

        /// <summary>
        /// Converts this Decimal to UInt32 or returns the UInt32 default value
        /// </summary>
        /// <returns>This Decimal converted to UInt32</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32(this Decimal thisDecimal)
        {
            return thisDecimal.ToUInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Decimal to UInt32 or returns the specified default value
        /// </summary>
        /// <returns>This Decimal converted to UInt32</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32OrDefault(this Decimal thisDecimal, UInt32 defaultValue = default(UInt32))
        {
            return thisDecimal.ToUInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Decimal to UInt32?
        /// </summary>
        /// <returns>This Decimal converted to UInt32</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        /// </remarks>
        public static UInt32? ToUInt32Nullable(this Decimal thisDecimal)
        {
            return ((double)thisDecimal < 0 || thisDecimal > 4294967295) ? (UInt32?)null : (UInt32)thisDecimal;
        }


    }
}
