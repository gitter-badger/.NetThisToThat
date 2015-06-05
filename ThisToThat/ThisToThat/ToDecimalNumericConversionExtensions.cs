
using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static partial class ToDecimalExtensions
    {


        /* 
        SByte to Decimal: Method omitted
        There is a predefined implicit conversion from SByte to Decimal
        */

        /* 
        Byte to Decimal: Method omitted
        There is a predefined implicit conversion from Byte to Decimal
        */

        /* 
        Int16 to Decimal: Method omitted
        There is a predefined implicit conversion from Int16 to Decimal
        */

        /* 
        UInt16 to Decimal: Method omitted
        There is a predefined implicit conversion from UInt16 to Decimal
        */

        /* 
        Int32 to Decimal: Method omitted
        There is a predefined implicit conversion from Int32 to Decimal
        */

        /* 
        UInt32 to Decimal: Method omitted
        There is a predefined implicit conversion from UInt32 to Decimal
        */

        /* 
        Int64 to Decimal: Method omitted
        There is a predefined implicit conversion from Int64 to Decimal
        */

        /* 
        UInt64 to Decimal: Method omitted
        There is a predefined implicit conversion from UInt64 to Decimal
        */

        /// <summary>
        /// Converts this Single to Decimal or returns the Decimal default value
        /// </summary>
        /// <returns>This Single converted to Decimal</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        /// </remarks>
        public static Decimal ToDecimal(this Single thisSingle)
        {
            return thisSingle.ToDecimalNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Single to Decimal or returns the specified default value
        /// </summary>
        /// <returns>This Single converted to Decimal</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        /// </remarks>
        public static Decimal ToDecimalOrDefault(this Single thisSingle, Decimal defaultValue = default(Decimal))
        {
            return thisSingle.ToDecimalNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Single to Decimal?
        /// </summary>
        /// <returns>This Single converted to Decimal</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.402823E+38
        /// Max value: 3.402823E+38
        ///
        /// Target type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        /// </remarks>
        public static Decimal? ToDecimalNullable(this Single thisSingle)
        {
            return (thisSingle < -79228162514264337593543950335f || thisSingle > 79228162514264337593543950335f) ? (Decimal?)null : (Decimal)thisSingle;
        }

        /// <summary>
        /// Converts this Double to Decimal or returns the Decimal default value
        /// </summary>
        /// <returns>This Double converted to Decimal</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        /// </remarks>
        public static Decimal ToDecimal(this Double thisDouble)
        {
            return thisDouble.ToDecimalNullable().GetValueOrDefault();
        }

        /// <summary>
        /// Converts this Double to Decimal or returns the specified default value
        /// </summary>
        /// <returns>This Double converted to Decimal</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        /// </remarks>
        public static Decimal ToDecimalOrDefault(this Double thisDouble, Decimal defaultValue = default(Decimal))
        {
            return thisDouble.ToDecimalNullable().GetValueOrDefault(defaultValue);
        }

        /// <summary>
        /// Converts this Double to Decimal?
        /// </summary>
        /// <returns>This Double converted to Decimal</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Decimal
        /// Min value: -79228162514264337593543950335
        /// Max value: 79228162514264337593543950335
        /// </remarks>
        public static Decimal? ToDecimalNullable(this Double thisDouble)
        {
            return (thisDouble < -79228162514264337593543950335d || thisDouble > 79228162514264337593543950335d) ? (Decimal?)null : (Decimal)thisDouble;
        }

    }
}
