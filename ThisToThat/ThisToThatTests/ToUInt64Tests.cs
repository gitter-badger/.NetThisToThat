using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToUInt64Tests
    {




        /// <summary>
        /// Makes multiple SByte to UInt64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestSByteToUInt64OrDefault()
        {
            // Test conversion of source type minimum value
            SByte source = SByte.MinValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            UInt64? result = source.ToUInt64OrDefault(86UL);
            // Here we would expect this conversion to fail (and return the default value of 86UL), 
            // since the source type's minimum value (-128) is less than the target type's minimum value (0).
            Assert.AreEqual(86UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type value 42 to target type
            source = (sbyte)42;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt64OrDefault(86UL);
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = SByte.MaxValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt64OrDefault(86UL);
            Assert.AreEqual(127UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));
        }


        /// <summary>
        /// Makes multiple SByte to nullable UInt64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestSByteToUInt64Nullable()
        {
            // Test conversion of source type minimum value
            SByte source = SByte.MinValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            UInt64? result = source.ToUInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-128) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = (sbyte)42;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt64Nullable();
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = SByte.MaxValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt64Nullable();
            Assert.AreEqual(127UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

        }

        /* 
        Byte to UInt64: Test omitted
        There is a predefined implicit conversion from Byte to UInt64
        */


        /// <summary>
        /// Makes multiple Int16 to UInt64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestInt16ToUInt64OrDefault()
        {
            // Test conversion of source type minimum value
            Int16 source = Int16.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            UInt64? result = source.ToUInt64OrDefault(86UL);
            // Here we would expect this conversion to fail (and return the default value of 86UL), 
            // since the source type's minimum value (-32768) is less than the target type's minimum value (0).
            Assert.AreEqual(86UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt64OrDefault(86UL);
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = Int16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt64OrDefault(86UL);
            Assert.AreEqual(32767UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));
        }


        /// <summary>
        /// Makes multiple Int16 to nullable UInt64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestInt16ToUInt64Nullable()
        {
            // Test conversion of source type minimum value
            Int16 source = Int16.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            UInt64? result = source.ToUInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-32768) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt64Nullable();
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = Int16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt64Nullable();
            Assert.AreEqual(32767UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

        }

        /* 
        UInt16 to UInt64: Test omitted
        There is a predefined implicit conversion from UInt16 to UInt64
        */


        /// <summary>
        /// Makes multiple Int32 to UInt64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestInt32ToUInt64OrDefault()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            UInt64? result = source.ToUInt64OrDefault(86UL);
            // Here we would expect this conversion to fail (and return the default value of 86UL), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (0).
            Assert.AreEqual(86UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt64OrDefault(86UL);
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt64OrDefault(86UL);
            Assert.AreEqual(2147483647UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));
        }


        /// <summary>
        /// Makes multiple Int32 to nullable UInt64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestInt32ToUInt64Nullable()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            UInt64? result = source.ToUInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt64Nullable();
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt64Nullable();
            Assert.AreEqual(2147483647UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

        }

        /* 
        UInt32 to UInt64: Test omitted
        There is a predefined implicit conversion from UInt32 to UInt64
        */


        /// <summary>
        /// Makes multiple Int64 to UInt64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestInt64ToUInt64OrDefault()
{
    // Test conversion of source type minimum value
    Int64 source = Int64.MinValue;
    Assert.IsInstanceOfType(source, typeof(Int64));
    UInt64? result = source.ToUInt64OrDefault(86UL);
    // Here we would expect this conversion to fail (and return the default value of 86UL), 
    // since the source type's minimum value (-9.22337203685478E+18) is less than the target type's minimum value (0).
    Assert.AreEqual(86UL, result);
    Assert.IsInstanceOfType(result, typeof(UInt64));

    // Test conversion of source type value 42 to target type
    source = 42L;
    Assert.IsInstanceOfType(source, typeof(Int64));
    result = source.ToUInt64OrDefault(86UL);
    Assert.AreEqual(42UL, result);
    Assert.IsInstanceOfType(result, typeof(UInt64));

    // Test conversion of source type maximum value
    source = Int64.MaxValue;
    Assert.IsInstanceOfType(source, typeof(Int64));
    result = source.ToUInt64OrDefault(86UL);
    Assert.AreEqual(9.22337203685478E+18, result);
    Assert.IsInstanceOfType(result, typeof(UInt64));
}


        /// <summary>
        /// Makes multiple Int64 to nullable UInt64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestInt64ToUInt64Nullable()
{
    // Test conversion of source type minimum value
    Int64 source = Int64.MinValue;
    Assert.IsInstanceOfType(source, typeof(Int64));
    UInt64? result = source.ToUInt64Nullable();
    // Here we would expect this conversion to fail (and return null), 
    // since the source type's minimum value (-9.22337203685478E+18) is less than the target type's minimum value (0).
    Assert.IsNull(result);

    // Test conversion of source type value 42 to target type
    source = 42L;
    Assert.IsInstanceOfType(source, typeof(Int64));
    result = source.ToUInt64Nullable();
    Assert.AreEqual(42UL, result);
    Assert.IsInstanceOfType(result, typeof(UInt64));

    // Test conversion of source type maximum value
    source = Int64.MaxValue;
    Assert.IsInstanceOfType(source, typeof(Int64));
    result = source.ToUInt64Nullable();
    Assert.AreEqual(9.22337203685478E+18, result);
    Assert.IsInstanceOfType(result, typeof(UInt64));

}


        /// <summary>
        /// Makes multiple Single to UInt64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestSingleToUInt64OrDefault()
        {
            // Test conversion of source type minimum value
            Single source = Single.MinValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            UInt64? result = source.ToUInt64OrDefault(86UL);
            // Here we would expect this conversion to fail (and return the default value of 86UL), 
            // since the source type's minimum value (-3.40282346638529E+38) is less than the target type's minimum value (0).
            Assert.AreEqual(86UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type value 42 to target type
            source = 42f;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToUInt64OrDefault(86UL);
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = Single.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToUInt64OrDefault(86UL);
            // Here we would expect this conversion to fail (and return the default value of 86UL), 
            // since the source type's maximum value (3.40282346638529E+38) is greater than the target type's maximum value (1.84467440737096E+19).
            Assert.AreEqual(86UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

        }


        /// <summary>
        /// Makes multiple Single to nullable UInt64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestSingleToUInt64Nullable()
        {
            // Test conversion of source type minimum value
            Single source = Single.MinValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            UInt64? result = source.ToUInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-3.40282346638529E+38) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42f;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToUInt64Nullable();
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = Single.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToUInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (3.40282346638529E+38) is greater than the target type's maximum value (1.84467440737096E+19).
            Assert.IsNull(result);

        }


        /// <summary>
        /// Makes multiple Double to UInt64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestDoubleToUInt64OrDefault()
        {
            // Test conversion of source type minimum value
            Double source = Double.MinValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            UInt64? result = source.ToUInt64OrDefault(86UL);
            // Here we would expect this conversion to fail (and return the default value of 86UL), 
            // since the source type's minimum value (-1.79769313486232E+308) is less than the target type's minimum value (0).
            Assert.AreEqual(86UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type value 42 to target type
            source = 42d;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToUInt64OrDefault(86UL);
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = Double.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToUInt64OrDefault(86UL);
            // Here we would expect this conversion to fail (and return the default value of 86UL), 
            // since the source type's maximum value (1.79769313486232E+308) is greater than the target type's maximum value (1.84467440737096E+19).
            Assert.AreEqual(86UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

        }


        /// <summary>
        /// Makes multiple Double to nullable UInt64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestDoubleToUInt64Nullable()
        {
            // Test conversion of source type minimum value
            Double source = Double.MinValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            UInt64? result = source.ToUInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-1.79769313486232E+308) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42d;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToUInt64Nullable();
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = Double.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToUInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (1.79769313486232E+308) is greater than the target type's maximum value (1.84467440737096E+19).
            Assert.IsNull(result);

        }


        /// <summary>
        /// Makes multiple Decimal to UInt64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestDecimalToUInt64OrDefault()
        {
            // Test conversion of source type minimum value
            Decimal source = Decimal.MinValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            UInt64? result = source.ToUInt64OrDefault(86UL);
            // Here we would expect this conversion to fail (and return the default value of 86UL), 
            // since the source type's minimum value (-7.92281625142643E+28) is less than the target type's minimum value (0).
            Assert.AreEqual(86UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type value 42 to target type
            source = 42m;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToUInt64OrDefault(86UL);
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = Decimal.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToUInt64OrDefault(86UL);
            // Here we would expect this conversion to fail (and return the default value of 86UL), 
            // since the source type's maximum value (7.92281625142643E+28) is greater than the target type's maximum value (1.84467440737096E+19).
            Assert.AreEqual(86UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

        }


        /// <summary>
        /// Makes multiple Decimal to nullable UInt64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestDecimalToUInt64Nullable()
        {
            // Test conversion of source type minimum value
            Decimal source = Decimal.MinValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            UInt64? result = source.ToUInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-7.92281625142643E+28) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42m;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToUInt64Nullable();
            Assert.AreEqual(42UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

            // Test conversion of source type maximum value
            source = Decimal.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToUInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (7.92281625142643E+28) is greater than the target type's maximum value (1.84467440737096E+19).
            Assert.IsNull(result);

        }


    }
}
