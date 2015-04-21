using System;
using System.Collections.Generic;
using System.Text;


namespace ThisToThat
{
    public static class ToSByteExtensions
    {




        /// <summary>
        /// Converts this Byte to SByte or returns the SByte default value
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
        public static SByte? ToSByte(this Byte thisByte)
        {
            return thisByte.ToSByteNullable().GetValueOrDefault();
        }

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
        public static SByte? ToSByteOrDefault(this Byte thisByte, SByte defaultValue = default(SByte))
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
            return (thisByte > 127) ? (SByte?)null : (SByte)thisByte;
        }

        /// <summary>
        /// Converts this Int16 to SByte or returns the SByte default value
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
        public static SByte? ToSByte(this Int16 thisInt16)
        {
            return thisInt16.ToSByteNullable().GetValueOrDefault();
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
        public static SByte? ToSByteOrDefault(this Int16 thisInt16, SByte defaultValue = default(SByte))
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
            return (thisInt16 < -128 || thisInt16 > 127) ? (SByte?)null : (SByte)thisInt16;
        }

        /// <summary>
        /// Converts this UInt16 to SByte or returns the SByte default value
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
        public static SByte? ToSByte(this UInt16 thisUInt16)
        {
            return thisUInt16.ToSByteNullable().GetValueOrDefault();
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
        public static SByte? ToSByteOrDefault(this UInt16 thisUInt16, SByte defaultValue = default(SByte))
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
            return (thisUInt16 > 127) ? (SByte?)null : (SByte)thisUInt16;
        }

        /// <summary>
        /// Converts this Int32 to SByte or returns the SByte default value
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
        public static SByte? ToSByte(this Int32 thisInt32)
        {
            return thisInt32.ToSByteNullable().GetValueOrDefault();
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
        public static SByte? ToSByteOrDefault(this Int32 thisInt32, SByte defaultValue = default(SByte))
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
        /// Converts this UInt32 to SByte or returns the SByte default value
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
        public static SByte? ToSByte(this UInt32 thisUInt32)
        {
            return thisUInt32.ToSByteNullable().GetValueOrDefault();
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
        public static SByte? ToSByteOrDefault(this UInt32 thisUInt32, SByte defaultValue = default(SByte))
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
            return (thisUInt32 > 127) ? (SByte?)null : (SByte)thisUInt32;
        }

        /// <summary>
        /// Converts this Int64 to SByte or returns the SByte default value
        /// </summary>
        /// <returns>This Int64 converted to SByte</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByte(this Int64 thisInt64)
        {
            return thisInt64.ToSByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Int64 to SByte or returns the specified default value
        /// </summary>
        /// <returns>This Int64 converted to SByte</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteOrDefault(this Int64 thisInt64, SByte defaultValue = default(SByte))
        {
            return thisInt64.ToSByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Int64 to SByte?
        /// </summary>
        /// <returns>This Int64 converted to SByte</returns>
        /// <remarks>
        /// Source type: Int64
        /// Min value: -9.22337203685478E+18
        /// Max value: 9.22337203685478E+18
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this Int64 thisInt64)
        {
            return (thisInt64 < -128 || thisInt64 > 127) ? (SByte?)null : (SByte)thisInt64;
        }

        /// <summary>
        /// Converts this UInt64 to SByte or returns the SByte default value
        /// </summary>
        /// <returns>This UInt64 converted to SByte</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByte(this UInt64 thisUInt64)
        {
            return thisUInt64.ToSByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this UInt64 to SByte or returns the specified default value
        /// </summary>
        /// <returns>This UInt64 converted to SByte</returns>
        /// <remarks>
        /// Source type: UInt64
        /// Min value: 0
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteOrDefault(this UInt64 thisUInt64, SByte defaultValue = default(SByte))
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
        /// Max value: 1.84467440737096E+19
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this UInt64 thisUInt64)
        {
            return (thisUInt64 > 127) ? (SByte?)null : (SByte)thisUInt64;
        }

        /// <summary>
        /// Converts this Single to SByte or returns the SByte default value
        /// </summary>
        /// <returns>This Single converted to SByte</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByte(this Single thisSingle)
        {
            return thisSingle.ToSByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Single to SByte or returns the specified default value
        /// </summary>
        /// <returns>This Single converted to SByte</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteOrDefault(this Single thisSingle, SByte defaultValue = default(SByte))
        {
            return thisSingle.ToSByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Single to SByte?
        /// </summary>
        /// <returns>This Single converted to SByte</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this Single thisSingle)
        {
            return (thisSingle < -128 || thisSingle > 127) ? (SByte?)null : (SByte)thisSingle;
        }

        /// <summary>
        /// Converts this Double to SByte or returns the SByte default value
        /// </summary>
        /// <returns>This Double converted to SByte</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByte(this Double thisDouble)
        {
            return thisDouble.ToSByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Double to SByte or returns the specified default value
        /// </summary>
        /// <returns>This Double converted to SByte</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteOrDefault(this Double thisDouble, SByte defaultValue = default(SByte))
        {
            return thisDouble.ToSByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Double to SByte?
        /// </summary>
        /// <returns>This Double converted to SByte</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this Double thisDouble)
        {
            return (thisDouble < -128 || thisDouble > 127) ? (SByte?)null : (SByte)thisDouble;
        }

        /// <summary>
        /// Converts this Decimal to SByte or returns the SByte default value
        /// </summary>
        /// <returns>This Decimal converted to SByte</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByte(this Decimal thisDecimal)
        {
            return thisDecimal.ToSByteNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Decimal to SByte or returns the specified default value
        /// </summary>
        /// <returns>This Decimal converted to SByte</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteOrDefault(this Decimal thisDecimal, SByte defaultValue = default(SByte))
        {
            return thisDecimal.ToSByteNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Decimal to SByte?
        /// </summary>
        /// <returns>This Decimal converted to SByte</returns>
        /// <remarks>
        /// Source type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        ///
        /// Target type: SByte
        /// Min value: -128
        /// Max value: 127
        /// </remarks>
        public static SByte? ToSByteNullable(this Decimal thisDecimal)
        {
            return ((double)thisDecimal < -128 || thisDecimal > 127) ? (SByte?)null : (SByte)thisDecimal;
        }


    }
}
