using System;
using System.Collections.Generic;
using System.Text;

namespace ThisToThat
{
    public static class ToDecimalExtensions
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
        /// Converts this Single to Decimal
        /// </summary>
        /// <returns>This Single converted to Decimal</returns>
        /// <remarks>
        /// Source type: Single
        /// Min value: -3.40282346638529E+38
        /// Max value: 3.40282346638529E+38
        ///
        /// Target type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        /// </remarks>
        public static Decimal? ToDecimalNullable(this Single thisSingle)
        {
            return (thisSingle < -7.92281625142643E+28 || thisSingle > 7.92281625142643E+28) ? (Decimal?)null : (Decimal)thisSingle;
        }

        /// <summary>
        /// Converts this Double to Decimal
        /// </summary>
        /// <returns>This Double converted to Decimal</returns>
        /// <remarks>
        /// Source type: Double
        /// Min value: -1.79769313486232E+308
        /// Max value: 1.79769313486232E+308
        ///
        /// Target type: Decimal
        /// Min value: -7.92281625142643E+28
        /// Max value: 7.92281625142643E+28
        /// </remarks>
        public static Decimal? ToDecimalNullable(this Double thisDouble)
        {
            return (thisDouble < -7.92281625142643E+28 || thisDouble > 7.92281625142643E+28) ? (Decimal?)null : (Decimal)thisDouble;
        }

    }
}
