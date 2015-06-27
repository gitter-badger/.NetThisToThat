
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToSingleTests
    {


        /* 
        SByte to Single: Test omitted
        There is a predefined implicit conversion from SByte to Single
        */

        /* 
        Byte to Single: Test omitted
        There is a predefined implicit conversion from Byte to Single
        */

        /* 
        Int16 to Single: Test omitted
        There is a predefined implicit conversion from Int16 to Single
        */

        /* 
        UInt16 to Single: Test omitted
        There is a predefined implicit conversion from UInt16 to Single
        */

        /* 
        Int32 to Single: Test omitted
        There is a predefined implicit conversion from Int32 to Single
        */

        /* 
        UInt32 to Single: Test omitted
        There is a predefined implicit conversion from UInt32 to Single
        */

        /* 
        Int64 to Single: Test omitted
        There is a predefined implicit conversion from Int64 to Single
        */

        /* 
        UInt64 to Single: Test omitted
        There is a predefined implicit conversion from UInt64 to Single
        */


        /// <summary>
        /// Makes multiple Double to Single or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSingle tests")]
        public void TestDoubleToSingleOrDefault()
        {
            // Test conversion of source type minimum value
            Double source = Double.MinValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            Single? result = source.ToSingleOrDefault(86f);
    
            // Here we would expect this conversion to fail (and return the default value of 86f), 
            // since the source type's minimum value (-1.79769313486232E+308) is less than the target type's minimum value (-3.402823E+38).
            Assert.AreEqual(86f, result);
            Assert.IsInstanceOfType(result, typeof(Single));
            // Test conversion of source type value 42 to target type
            source = 42d;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToSingleOrDefault(86f);
            Assert.AreEqual(42f, result);
            Assert.IsInstanceOfType(result, typeof(Single));

            // Test conversion of source type maximum value
            source = Double.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToSingleOrDefault(86f);
            // Here we would expect this conversion to fail (and return the default value of 86f), 
            // since the source type's maximum value (1.79769313486232E+308) is greater than the target type's maximum value (3.402823E+38).
            Assert.AreEqual(86f, result);
            Assert.IsInstanceOfType(result, typeof(Single));
        }


        /// <summary>
        /// Makes multiple Double to nullable Single conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSingle tests")]
        public void TestDoubleToSingleNullable()
        {
            // Test conversion of source type minimum value
            Double source = Double.MinValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            Single? result = source.ToSingleNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-1.79769313486232E+308) is less than the target type's minimum value (-3.402823E+38).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42d;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToSingleNullable();
            Assert.AreEqual(42f, result);
            Assert.IsInstanceOfType(result, typeof(Single));

            // Test conversion of source type maximum value
            source = Double.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToSingleNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (1.79769313486232E+308) is greater than the target type's maximum value (3.402823E+38).
            Assert.IsNull(result);
        }

        /* 
        Decimal to Single: Test omitted
        Explicit numeric conversion is possible from Decimal to Single.
        Decimal falls within the range of Single.
        To convert, simply cast as Single e.g: 

        Decimal myDecimal = Decimal.MinValue;
        Single mySingle = (Single)myDecimal;
        */

        /// <summary>
        /// Makes multiple String to Single or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSingle tests")]
        public void TestStringToSingleOrDefault()
        {
            // Test conversion of target type minimum value
            Single resultMin = "-3.402823E+38".ToSingleOrDefault();
            Assert.AreEqual(-3.402823E+38f, resultMin);

            // Test conversion of fixed value (42)
            Single result42 = "42".ToSingleOrDefault();
            Assert.AreEqual(42f, result42);
            
            // Test conversion of target type maximum value
            Single resultMax = "-3.402823E+38".ToSingleOrDefault();
            Assert.AreEqual(-3.402823E+38f, resultMax);

            // Test conversion of "foo"
            Single resultFoo = "foo".ToSingleOrDefault(86f);
            Assert.IsNull(resultFoo);

        }

        /// <summary>
        /// Makes multiple String to SingleNullable conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSingle tests")]
        public void TestStringToSingleNullable()
        {
            // Test conversion of target type minimum value
            Single? resultMin = "-3.402823E+38".ToSingleNullable();
            Assert.AreEqual(-3.402823E+38f, resultMin);

            // Test conversion of fixed value (42)
            Single? result42 = "42".ToSingleNullable();
            Assert.AreEqual(42f, result42);
            
            // Test conversion of target type maximum value
            Single? resultMax = "-3.402823E+38".ToSingleNullable();
            Assert.AreEqual(-3.402823E+38f, resultMax);

            // Test conversion of "foo"
            Single? resultFoo = "foo".ToSingleNullable();
            Assert.AreEqual(86f, resultFoo);

        }
    }
}
