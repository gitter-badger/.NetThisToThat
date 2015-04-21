using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToInt32Tests
    {


        /* 
        SByte to Int32: Test omitted
        There is a predefined implicit conversion from SByte to Int32
        */

        /* 
        Byte to Int32: Test omitted
        There is a predefined implicit conversion from Byte to Int32
        */

        /* 
        Int16 to Int32: Test omitted
        There is a predefined implicit conversion from Int16 to Int32
        */

        /* 
        UInt16 to Int32: Test omitted
        There is a predefined implicit conversion from UInt16 to Int32
        */


        /// <summary>
        /// Makes multiple UInt32 to Int32 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestUInt32ToInt32OrDefault()
        {
            // Test conversion of source type minimum value
            UInt32 source = UInt32.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            Int32? result = source.ToInt32OrDefault(86);
            Assert.AreEqual(0, result);
            Assert.IsInstanceOfType(result, typeof(Int32));
            // Test conversion of source type value 42 to target type
            source = 42u;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToInt32OrDefault(86);
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = UInt32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's maximum value (4294967295) is greater than the target type's maximum value (2147483647).
            Assert.AreEqual(86, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

        }


        /// <summary>
        /// Makes multiple UInt32 to nullable Int32 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestUInt32ToInt32Nullable()
        {
            // Test conversion of source type minimum value
            UInt32 source = UInt32.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            Int32? result = source.ToInt32Nullable();
            Assert.AreEqual(0, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type value 42 to target type
            source = 42u;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToInt32Nullable();
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = UInt32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (4294967295) is greater than the target type's maximum value (2147483647).
            Assert.IsNull(result);

        }


        /// <summary>
        /// Makes multiple Int64 to Int32 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestInt64ToInt32OrDefault()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            Int32? result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's minimum value (-9.22337203685478E+18) is less than the target type's minimum value (-2147483648).
            Assert.AreEqual(86, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type value 42 to target type
            source = 42l;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt32OrDefault(86);
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's maximum value (9.22337203685478E+18) is greater than the target type's maximum value (2147483647).
            Assert.AreEqual(86, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

        }


        /// <summary>
        /// Makes multiple Int64 to nullable Int32 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestInt64ToInt32Nullable()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            Int32? result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-9.22337203685478E+18) is less than the target type's minimum value (-2147483648).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42l;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt32Nullable();
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (9.22337203685478E+18) is greater than the target type's maximum value (2147483647).
            Assert.IsNull(result);

        }


        /// <summary>
        /// Makes multiple UInt64 to Int32 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestUInt64ToInt32OrDefault()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            Int32? result = source.ToInt32OrDefault(86);
            Assert.AreEqual(0, result);
            Assert.IsInstanceOfType(result, typeof(Int32));
            // Test conversion of source type value 42 to target type
            source = 42ul;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt32OrDefault(86);
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's maximum value (1.84467440737096E+19) is greater than the target type's maximum value (2147483647).
            Assert.AreEqual(86, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

        }


        /// <summary>
        /// Makes multiple UInt64 to nullable Int32 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestUInt64ToInt32Nullable()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            Int32? result = source.ToInt32Nullable();
            Assert.AreEqual(0, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type value 42 to target type
            source = 42ul;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt32Nullable();
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (1.84467440737096E+19) is greater than the target type's maximum value (2147483647).
            Assert.IsNull(result);

        }


        /// <summary>
        /// Makes multiple Single to Int32 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestSingleToInt32OrDefault()
        {
            // Test conversion of source type minimum value
            Single source = Single.MinValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            Int32? result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's minimum value (-3.40282346638529E+38) is less than the target type's minimum value (-2147483648).
            Assert.AreEqual(86, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type value 42 to target type
            source = 42f;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToInt32OrDefault(86);
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = Single.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's maximum value (3.40282346638529E+38) is greater than the target type's maximum value (2147483647).
            Assert.AreEqual(86, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

        }


        /// <summary>
        /// Makes multiple Single to nullable Int32 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestSingleToInt32Nullable()
        {
            // Test conversion of source type minimum value
            Single source = Single.MinValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            Int32? result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-3.40282346638529E+38) is less than the target type's minimum value (-2147483648).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42f;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToInt32Nullable();
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = Single.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (3.40282346638529E+38) is greater than the target type's maximum value (2147483647).
            Assert.IsNull(result);

        }


        /// <summary>
        /// Makes multiple Double to Int32 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestDoubleToInt32OrDefault()
        {
            // Test conversion of source type minimum value
            Double source = Double.MinValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            Int32? result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's minimum value (-1.79769313486232E+308) is less than the target type's minimum value (-2147483648).
            Assert.AreEqual(86, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type value 42 to target type
            source = 42d;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToInt32OrDefault(86);
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = Double.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's maximum value (1.79769313486232E+308) is greater than the target type's maximum value (2147483647).
            Assert.AreEqual(86, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

        }


        /// <summary>
        /// Makes multiple Double to nullable Int32 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestDoubleToInt32Nullable()
        {
            // Test conversion of source type minimum value
            Double source = Double.MinValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            Int32? result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-1.79769313486232E+308) is less than the target type's minimum value (-2147483648).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42d;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToInt32Nullable();
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = Double.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (1.79769313486232E+308) is greater than the target type's maximum value (2147483647).
            Assert.IsNull(result);

        }


        /// <summary>
        /// Makes multiple Decimal to Int32 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestDecimalToInt32OrDefault()
        {
            // Test conversion of source type minimum value
            Decimal source = Decimal.MinValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            Int32? result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's minimum value (-7.92281625142643E+28) is less than the target type's minimum value (-2147483648).
            Assert.AreEqual(86, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type value 42 to target type
            source = 42m;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToInt32OrDefault(86);
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = Decimal.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's maximum value (7.92281625142643E+28) is greater than the target type's maximum value (2147483647).
            Assert.AreEqual(86, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

        }


        /// <summary>
        /// Makes multiple Decimal to nullable Int32 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt32 tests")]
        public void TestDecimalToInt32Nullable()
        {
            // Test conversion of source type minimum value
            Decimal source = Decimal.MinValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            Int32? result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-7.92281625142643E+28) is less than the target type's minimum value (-2147483648).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42m;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToInt32Nullable();
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = Decimal.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (7.92281625142643E+28) is greater than the target type's maximum value (2147483647).
            Assert.IsNull(result);

        }

    }
}
