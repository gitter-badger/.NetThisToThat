
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToUInt16Extensions
    {


        /// <summary>
        /// Converts this SByte to UInt16 or returns the UInt16 default value
        /// </summary>
        /// <returns>This SByte converted to UInt16</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16(this SByte thisSByte)
        {
            return thisSByte.ToUInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this SByte to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This SByte converted to UInt16</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16OrDefault(this SByte thisSByte, UInt16 defaultValue = default(UInt16))
        {
            return thisSByte.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this SByte to UInt16?
        /// </summary>
        /// <returns>This SByte converted to UInt16</returns>
        /// <remarks>
        /// Source type: SByte
        /// Min value: -128
        /// Max value: 127
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this SByte thisSByte)
        {
            return (thisSByte < (sbyte)0) ? (UInt16?)null : (UInt16)thisSByte;
        }

        /* 
        Byte to UInt16: Method omitted
        There is a predefined implicit conversion from Byte to UInt16
        */

        /// <summary>
        /// Converts this Int16 to UInt16 or returns the UInt16 default value
        /// </summary>
        /// <returns>This Int16 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16(this Int16 thisInt16)
        {
            return thisInt16.ToUInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int16 to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This Int16 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16OrDefault(this Int16 thisInt16, UInt16 defaultValue = default(UInt16))
        {
            return thisInt16.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int16 to UInt16?
        /// </summary>
        /// <returns>This Int16 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int16
        /// Min value: -32768
        /// Max value: 32767
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this Int16 thisInt16)
        {
            return (thisInt16 < 0) ? (UInt16?)null : (UInt16)thisInt16;
        }

        /// <summary>
        /// Converts this Int32 to UInt16 or returns the UInt16 default value
        /// </summary>
        /// <returns>This Int32 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16(this Int32 thisInt32)
        {
            return thisInt32.ToUInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int32 to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This Int32 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16OrDefault(this Int32 thisInt32, UInt16 defaultValue = default(UInt16))
        {
            return thisInt32.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int32 to UInt16?
        /// </summary>
        /// <returns>This Int32 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this Int32 thisInt32)
        {
            return (thisInt32 < 0 || thisInt32 > 65535) ? (UInt16?)null : (UInt16)thisInt32;
        }

        /// <summary>
        /// Converts this UInt32 to UInt16 or returns the UInt16 default value
        /// </summary>
        /// <returns>This UInt32 converted to UInt16</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16(this UInt32 thisUInt32)
        {
            return thisUInt32.ToUInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt32 to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This UInt32 converted to UInt16</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16OrDefault(this UInt32 thisUInt32, UInt16 defaultValue = default(UInt16))
        {
            return thisUInt32.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt32 to UInt16?
        /// </summary>
        /// <returns>This UInt32 converted to UInt16</returns>
        /// <remarks>
        /// Source type: UInt32
        /// Min value: 0
        /// Max value: 4294967295
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this UInt32 thisUInt32)
        {
            return (thisUInt32 > 65535u) ? (UInt16?)null : (UInt16)thisUInt32;
        }

        /// <summary>
        /// Converts this Int64 to UInt16 or returns the UInt16 default value
        /// </summary>
        /// <returns>This Int64 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16(this Int64 thisInt64)
        {
            return thisInt64.ToUInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int64 to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16OrDefault(this Int64 thisInt64, UInt16 defaultValue = default(UInt16))
        {
            return thisInt64.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to UInt16?
        /// </summary>
        /// <returns>This Int64 converted to UInt16</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this Int64 thisInt64)
        {
            return (thisInt64 < 0L || thisInt64 > 65535L) ? (UInt16?)null : (UInt16)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to UInt16 or returns the UInt16 default value
        /// </summary>
        /// <returns>This UInt64 converted to UInt16</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16(this UInt64 thisUInt64)
        {
            return thisUInt64.ToUInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt64 to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to UInt16</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16OrDefault(this UInt64 thisUInt64, UInt16 defaultValue = default(UInt16))
        {
            return thisUInt64.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt64 to UInt16?
        /// </summary>
        /// <returns>This UInt64 converted to UInt16</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 65535UL) ? (UInt16?)null : (UInt16)thisUInt64;
        }

        /// <summary>
        /// Converts this Single to UInt16 or returns the UInt16 default value
        /// </summary>
        /// <returns>This Single converted to UInt16</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16(this Single thisSingle)
        {
            return thisSingle.ToUInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Single to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This Single converted to UInt16</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16OrDefault(this Single thisSingle, UInt16 defaultValue = default(UInt16))
        {
            return thisSingle.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Single to UInt16?
        /// </summary>
        /// <returns>This Single converted to UInt16</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this Single thisSingle)
        {
            return (thisSingle < 0f || thisSingle > 65535f) ? (UInt16?)null : (UInt16)thisSingle;
        }

        /// <summary>
        /// Converts this Double to UInt16 or returns the UInt16 default value
        /// </summary>
        /// <returns>This Double converted to UInt16</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16(this Double thisDouble)
        {
            return thisDouble.ToUInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Double to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This Double converted to UInt16</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16OrDefault(this Double thisDouble, UInt16 defaultValue = default(UInt16))
        {
            return thisDouble.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Double to UInt16?
        /// </summary>
        /// <returns>This Double converted to UInt16</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this Double thisDouble)
        {
            return (thisDouble < 0d || thisDouble > 65535d) ? (UInt16?)null : (UInt16)thisDouble;
        }

        /// <summary>
        /// Converts this Decimal to UInt16 or returns the UInt16 default value
        /// </summary>
        /// <returns>This Decimal converted to UInt16</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16(this Decimal thisDecimal)
        {
            return thisDecimal.ToUInt16Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Decimal to UInt16 or returns the specified default value
        /// </summary>
        /// <returns>This Decimal converted to UInt16</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16OrDefault(this Decimal thisDecimal, UInt16 defaultValue = default(UInt16))
        {
            return thisDecimal.ToUInt16Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Decimal to UInt16?
        /// </summary>
        /// <returns>This Decimal converted to UInt16</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        ///
        /// Target type: UInt16
        /// Min value: 0
        /// Max value: 65535
        /// </remarks>
        public static UInt16? ToUInt16Nullable(this Decimal thisDecimal)
        {
            return (thisDecimal < 0m || thisDecimal > 65535m) ? (UInt16?)null : (UInt16)thisDecimal;
        }

    }
}
