
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToInt32Extensions
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
        /// Converts this UInt32 to Int32 or returns the Int32 default value
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
        public static Int32? ToInt32(this UInt32 thisUInt32)
        {
            return thisUInt32.ToInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt32 to Int32 or returns the specified default value
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
        public static Int32? ToInt32OrDefault(this UInt32 thisUInt32, Int32 defaultValue = default(Int32))
        {
            return thisUInt32.ToInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt32 to Int32?
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
            return (thisUInt32 > 2147483647u) ? (Int32?)null : (Int32)thisUInt32;
        }

        /// <summary>
        /// Converts this Int64 to Int32 or returns the Int32 default value
        /// </summary>
        /// <returns>This Int64 converted to Int32</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32(this Int64 thisInt64)
        {
            return thisInt64.ToInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int64 to Int32 or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to Int32</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32OrDefault(this Int64 thisInt64, Int32 defaultValue = default(Int32))
        {
            return thisInt64.ToInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to Int32?
        /// </summary>
        /// <returns>This Int64 converted to Int32</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9223372036854775808
        /// Max value: 9223372036854775807
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this Int64 thisInt64)
        {
            return (thisInt64 < -2147483648L || thisInt64 > 2147483647L) ? (Int32?)null : (Int32)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to Int32 or returns the Int32 default value
        /// </summary>
        /// <returns>This UInt64 converted to Int32</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32(this UInt64 thisUInt64)
        {
            return thisUInt64.ToInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt64 to Int32 or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to Int32</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32OrDefault(this UInt64 thisUInt64, Int32 defaultValue = default(Int32))
        {
            return thisUInt64.ToInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this UInt64 to Int32?
        /// </summary>
        /// <returns>This UInt64 converted to Int32</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 18446744073709551615
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 2147483647UL) ? (Int32?)null : (Int32)thisUInt64;
        }

        /// <summary>
        /// Converts this Single to Int32 or returns the Int32 default value
        /// </summary>
        /// <returns>This Single converted to Int32</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32(this Single thisSingle)
        {
            return thisSingle.ToInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Single to Int32 or returns the specified default value
        /// </summary>
        /// <returns>This Single converted to Int32</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32OrDefault(this Single thisSingle, Int32 defaultValue = default(Int32))
        {
            return thisSingle.ToInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Single to Int32?
        /// </summary>
        /// <returns>This Single converted to Int32</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this Single thisSingle)
        {
            return (thisSingle < -2147483648f || thisSingle > 2147483647f) ? (Int32?)null : (Int32)thisSingle;
        }

        /// <summary>
        /// Converts this Double to Int32 or returns the Int32 default value
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
        public static Int32? ToInt32(this Double thisDouble)
        {
            return thisDouble.ToInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Double to Int32 or returns the specified default value
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
        public static Int32? ToInt32OrDefault(this Double thisDouble, Int32 defaultValue = default(Int32))
        {
            return thisDouble.ToInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Double to Int32?
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
            return (thisDouble < -2147483648d || thisDouble > 2147483647d) ? (Int32?)null : (Int32)thisDouble;
        }

        /// <summary>
        /// Converts this Decimal to Int32 or returns the Int32 default value
        /// </summary>
        /// <returns>This Decimal converted to Int32</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32(this Decimal thisDecimal)
        {
            return thisDecimal.ToInt32Nullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Decimal to Int32 or returns the specified default value
        /// </summary>
        /// <returns>This Decimal converted to Int32</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32OrDefault(this Decimal thisDecimal, Int32 defaultValue = default(Int32))
        {
            return thisDecimal.ToInt32Nullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Decimal to Int32?
        /// </summary>
        /// <returns>This Decimal converted to Int32</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        ///
        /// Target type: Int32
        /// Min value: -2147483648
        /// Max value: 2147483647
        /// </remarks>
        public static Int32? ToInt32Nullable(this Decimal thisDecimal)
        {
            return (thisDecimal < -2147483648m || thisDecimal > 2147483647m) ? (Int32?)null : (Int32)thisDecimal;
        }

    }
}
