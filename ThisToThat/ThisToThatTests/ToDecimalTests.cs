
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToDecimalTests
    {


        /* 
        SByte to Decimal: Test omitted
        There is a predefined implicit conversion from SByte to Decimal
        */

        /* 
        Byte to Decimal: Test omitted
        There is a predefined implicit conversion from Byte to Decimal
        */

        /* 
        Int16 to Decimal: Test omitted
        There is a predefined implicit conversion from Int16 to Decimal
        */

        /* 
        UInt16 to Decimal: Test omitted
        There is a predefined implicit conversion from UInt16 to Decimal
        */

        /* 
        Int32 to Decimal: Test omitted
        There is a predefined implicit conversion from Int32 to Decimal
        */

        /* 
        UInt32 to Decimal: Test omitted
        There is a predefined implicit conversion from UInt32 to Decimal
        */

        /* 
        Int64 to Decimal: Test omitted
        There is a predefined implicit conversion from Int64 to Decimal
        */

        /* 
        UInt64 to Decimal: Test omitted
        There is a predefined implicit conversion from UInt64 to Decimal
        */


        /// <summary>
        /// Makes multiple Single to Decimal or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToDecimal tests")]
        public void TestSingleToDecimalOrDefault()
        {
            // Test conversion of source type minimum value
            Single source = Single.MinValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            Decimal? result = source.ToDecimalOrDefault(86m);
    
            // Here we would expect this conversion to fail (and return the default value of 86m), 
            // since the source type's minimum value (-3.40282347E+38) is less than the target type's minimum value (-79228162514264337593543950335).
            Assert.AreEqual(86m, result);
            Assert.IsInstanceOfType(result, typeof(Decimal));
            // Test conversion of source type value 42 to target type
            source = 42f;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToDecimalOrDefault(86m);
            Assert.AreEqual(42m, result);
            Assert.IsInstanceOfType(result, typeof(Decimal));

            // Test conversion of source type maximum value
            source = Single.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToDecimalOrDefault(86m);
            // Here we would expect this conversion to fail (and return the default value of 86m), 
            // since the source type's maximum value (3.40282347E+38) is greater than the target type's maximum value (79228162514264337593543950335).
            Assert.AreEqual(86m, result);
            Assert.IsInstanceOfType(result, typeof(Decimal));
        }


        /// <summary>
        /// Makes multiple Single to nullable Decimal conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToDecimal tests")]
        public void TestSingleToDecimalNullable()
        {
            // Test conversion of source type minimum value
            Single source = Single.MinValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            Decimal? result = source.ToDecimalNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-3.40282347E+38) is less than the target type's minimum value (-79228162514264337593543950335).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42f;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToDecimalNullable();
            Assert.AreEqual(42m, result);
            Assert.IsInstanceOfType(result, typeof(Decimal));

            // Test conversion of source type maximum value
            source = Single.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToDecimalNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (3.40282347E+38) is greater than the target type's maximum value (79228162514264337593543950335).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple Double to Decimal or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToDecimal tests")]
        public void TestDoubleToDecimalOrDefault()
        {
            // Test conversion of source type minimum value
            Double source = Double.MinValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            Decimal? result = source.ToDecimalOrDefault(86m);
    
            // Here we would expect this conversion to fail (and return the default value of 86m), 
            // since the source type's minimum value (-1.7976931348623157E+308) is less than the target type's minimum value (-79228162514264337593543950335).
            Assert.AreEqual(86m, result);
            Assert.IsInstanceOfType(result, typeof(Decimal));
            // Test conversion of source type value 42 to target type
            source = 42d;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToDecimalOrDefault(86m);
            Assert.AreEqual(42m, result);
            Assert.IsInstanceOfType(result, typeof(Decimal));

            // Test conversion of source type maximum value
            source = Double.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToDecimalOrDefault(86m);
            // Here we would expect this conversion to fail (and return the default value of 86m), 
            // since the source type's maximum value (1.7976931348623157E+308) is greater than the target type's maximum value (79228162514264337593543950335).
            Assert.AreEqual(86m, result);
            Assert.IsInstanceOfType(result, typeof(Decimal));
        }


        /// <summary>
        /// Makes multiple Double to nullable Decimal conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToDecimal tests")]
        public void TestDoubleToDecimalNullable()
        {
            // Test conversion of source type minimum value
            Double source = Double.MinValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            Decimal? result = source.ToDecimalNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-1.7976931348623157E+308) is less than the target type's minimum value (-79228162514264337593543950335).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42d;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToDecimalNullable();
            Assert.AreEqual(42m, result);
            Assert.IsInstanceOfType(result, typeof(Decimal));

            // Test conversion of source type maximum value
            source = Double.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToDecimalNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (1.7976931348623157E+308) is greater than the target type's maximum value (79228162514264337593543950335).
            Assert.IsNull(result);
        }

        /// <summary>
        /// Makes multiple String to Decimal or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToDecimal tests")]
        public void TestStringToDecimalOrDefault()
        {
            // Test conversion of target type minimum value
            Decimal resultMin = "-79228162514264337593543950335".ToDecimalOrDefault();
            Assert.AreEqual(-79228162514264337593543950335m, resultMin);

            // Test conversion of fixed value (42)
            Decimal result42 = "42".ToDecimalOrDefault();
            Assert.AreEqual(42m, result42);
            
            // Test conversion of target type maximum value
            Decimal resultMax = "79228162514264337593543950335".ToDecimalOrDefault();
            Assert.AreEqual(79228162514264337593543950335m, resultMax);

            // Test conversion of "foo"
            Decimal resultFoo = "foo".ToDecimalOrDefault(86m);
            Assert.AreEqual(86m, resultFoo);

        }

        /// <summary>
        /// Makes multiple String to DecimalNullable conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToDecimal tests")]
        public void TestStringToDecimalNullable()
        {
            // Test conversion of target type minimum value
            Decimal? resultMin = "-79228162514264337593543950335".ToDecimalNullable();
            Assert.AreEqual(-79228162514264337593543950335m, resultMin);

            // Test conversion of fixed value (42)
            Decimal? result42 = "42".ToDecimalNullable();
            Assert.AreEqual(42m, result42);
            
            // Test conversion of target type maximum value
            Decimal? resultMax = "79228162514264337593543950335".ToDecimalNullable();
            Assert.AreEqual(79228162514264337593543950335m, resultMax);

            // Test conversion of "foo"
            Decimal? resultFoo = "foo".ToDecimalNullable();
            Assert.IsNull(resultFoo);

        }
    }
}
