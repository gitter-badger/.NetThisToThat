
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToDoubleTests
    {


        /* 
        SByte to Double: Test omitted
        There is a predefined implicit conversion from SByte to Double
        */

        /* 
        Byte to Double: Test omitted
        There is a predefined implicit conversion from Byte to Double
        */

        /* 
        Int16 to Double: Test omitted
        There is a predefined implicit conversion from Int16 to Double
        */

        /* 
        UInt16 to Double: Test omitted
        There is a predefined implicit conversion from UInt16 to Double
        */

        /* 
        Int32 to Double: Test omitted
        There is a predefined implicit conversion from Int32 to Double
        */

        /* 
        UInt32 to Double: Test omitted
        There is a predefined implicit conversion from UInt32 to Double
        */

        /* 
        Int64 to Double: Test omitted
        There is a predefined implicit conversion from Int64 to Double
        */

        /* 
        UInt64 to Double: Test omitted
        There is a predefined implicit conversion from UInt64 to Double
        */

        /* 
        Single to Double: Test omitted
        There is a predefined implicit conversion from Single to Double
        */

        /* 
        Decimal to Double: Test omitted
        Explicit numeric conversion is possible from Decimal to Double.
        Decimal falls within the range of Double.
        To convert, simply cast as Double e.g: 

        Decimal myDecimal = Decimal.MinValue;
        Double myDouble = (Double)myDecimal;
        */

        /// <summary>
        /// Makes multiple String to Double or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToDouble tests")]
        public void TestStringToDoubleOrDefault()
        {
            // Test conversion of target type minimum value
            Double resultMin = "-1.79769313486232E+308".ToDoubleOrDefault();
            Assert.AreEqual(-1.79769313486232E+308d, resultMin);

            // Test conversion of fixed value (42)
            Double result42 = "42".ToDoubleOrDefault();
            Assert.AreEqual(42d, result42);
            
            // Test conversion of target type maximum value
            Double resultMax = "-1.79769313486232E+308".ToDoubleOrDefault();
            Assert.AreEqual(-1.79769313486232E+308d, resultMax);

            // Test conversion of "foo"
            Double resultFoo = "foo".ToDoubleOrDefault(86d);
            Assert.IsNull(resultFoo);

        }

        /// <summary>
        /// Makes multiple String to DoubleNullable conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToDouble tests")]
        public void TestStringToDoubleNullable()
        {
            // Test conversion of target type minimum value
            Double? resultMin = "-1.79769313486232E+308".ToDoubleNullable();
            Assert.AreEqual(-1.79769313486232E+308d, resultMin);

            // Test conversion of fixed value (42)
            Double? result42 = "42".ToDoubleNullable();
            Assert.AreEqual(42d, result42);
            
            // Test conversion of target type maximum value
            Double? resultMax = "-1.79769313486232E+308".ToDoubleNullable();
            Assert.AreEqual(-1.79769313486232E+308d, resultMax);

            // Test conversion of "foo"
            Double? resultFoo = "foo".ToDoubleNullable();
            Assert.AreEqual(86d, resultFoo);

        }
    }
}
