using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToSByteTests
    {


        /// <summary>
        /// Makes multiple Byte to SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestByteToSByteNullable()
        {
            // Test conversion of source type minimum value
            Byte source = Byte.MinValue;
            Assert.IsInstanceOfType(source, typeof(Byte));
            SByte? result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)0, result);

            // Test conversion of source type value 42 to target type
            source = (byte)42;
            Assert.IsInstanceOfType(source, typeof(Byte));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);

            // Test conversion of source type maximum value
            source = Byte.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Byte));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (255) is greater than the target type's maximum value (127).
            Assert.IsNull(result);

        }

        /// <summary>
        /// Makes multiple Int16 to SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestInt16ToSByteNullable()
        {
            // Test conversion of source type minimum value
            Int16 source = Int16.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            SByte? result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-32768) is less than the target type's minimum value (-128).
            Assert.IsNull(result);


            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);

            // Test conversion of source type maximum value
            source = Int16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (32767) is greater than the target type's maximum value (127).
            Assert.IsNull(result);

        }

        /// <summary>
        /// Makes multiple UInt16 to SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestUInt16ToSByteNullable()
        {
            // Test conversion of source type minimum value
            UInt16 source = UInt16.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            SByte? result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)0, result);

            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);

            // Test conversion of source type maximum value
            source = UInt16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (65535) is greater than the target type's maximum value (127).
            Assert.IsNull(result);

        }

        /// <summary>
        /// Makes multiple Int32 to SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestInt32ToSByteNullable()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            SByte? result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (-128).
            Assert.IsNull(result);


            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (2147483647) is greater than the target type's maximum value (127).
            Assert.IsNull(result);

        }

        /// <summary>
        /// Makes multiple UInt32 to SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestUInt32ToSByteNullable()
        {
            // Test conversion of source type minimum value
            UInt32 source = UInt32.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            SByte? result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)0, result);

            // Test conversion of source type value 42 to target type
            source = 42u;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);

            // Test conversion of source type maximum value
            source = UInt32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (4294967295) is greater than the target type's maximum value (127).
            Assert.IsNull(result);

        }

        /// <summary>
        /// Makes multiple Int64 to SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestInt64ToSByteNullable()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            SByte? result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-9.22337203685478E+18) is less than the target type's minimum value (-128).
            Assert.IsNull(result);


            // Test conversion of source type value 42 to target type
            source = 42l;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (9.22337203685478E+18) is greater than the target type's maximum value (127).
            Assert.IsNull(result);

        }

        /// <summary>
        /// Makes multiple UInt64 to SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestUInt64ToSByteNullable()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            SByte? result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)0, result);

            // Test conversion of source type value 42 to target type
            source = 42ul;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (1.84467440737096E+19) is greater than the target type's maximum value (127).
            Assert.IsNull(result);

        }

        /// <summary>
        /// Makes multiple Single to SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestSingleToSByteNullable()
        {
            // Test conversion of source type minimum value
            Single source = Single.MinValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            SByte? result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-3.40282346638529E+38) is less than the target type's minimum value (-128).
            Assert.IsNull(result);


            // Test conversion of source type value 42 to target type
            source = 42f;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);

            // Test conversion of source type maximum value
            source = Single.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Single));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (3.40282346638529E+38) is greater than the target type's maximum value (127).
            Assert.IsNull(result);

        }

        /// <summary>
        /// Makes multiple Double to SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestDoubleToSByteNullable()
        {
            // Test conversion of source type minimum value
            Double source = Double.MinValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            SByte? result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-1.79769313486232E+308) is less than the target type's minimum value (-128).
            Assert.IsNull(result);


            // Test conversion of source type value 42 to target type
            source = 42d;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);

            // Test conversion of source type maximum value
            source = Double.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Double));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (1.79769313486232E+308) is greater than the target type's maximum value (127).
            Assert.IsNull(result);

        }

        /// <summary>
        /// Makes multiple Decimal to SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestDecimalToSByteNullable()
        {
            // Test conversion of source type minimum value
            Decimal source = Decimal.MinValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            SByte? result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-7.92281625142643E+28) is less than the target type's minimum value (-128).
            Assert.IsNull(result);


            // Test conversion of source type value 42 to target type
            source = 42m;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);

            // Test conversion of source type maximum value
            source = Decimal.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Decimal));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (7.92281625142643E+28) is greater than the target type's maximum value (127).
            Assert.IsNull(result);

        }


    }
}
