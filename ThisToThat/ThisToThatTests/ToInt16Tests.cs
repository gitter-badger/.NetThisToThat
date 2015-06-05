
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToInt16Tests
    {


        /* 
        SByte to Int16: Test omitted
        There is a predefined implicit conversion from SByte to Int16
        */

        /* 
        Byte to Int16: Test omitted
        There is a predefined implicit conversion from Byte to Int16
        */


        /// <summary>
        /// Makes multiple UInt16 to Int16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt16 tests")]
        public void TestUInt16ToInt16OrDefault()
        {
            // Test conversion of source type minimum value
            UInt16 source = UInt16.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            Int16? result = source.ToInt16OrDefault((short)86);
    
            Assert.AreEqual((short)0, result);
            Assert.IsInstanceOfType(result, typeof(Int16));
            // Test conversion of source type value 42 to target type
            source = (ushort)42;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToInt16OrDefault((short)86);
            Assert.AreEqual((short)42, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type maximum value
            source = UInt16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToInt16OrDefault((short)86);
            // Here we would expect this conversion to fail (and return the default value of (short)86), 
            // since the source type's maximum value (65535) is greater than the target type's maximum value (32767).
            Assert.AreEqual((short)86, result);
            Assert.IsInstanceOfType(result, typeof(Int16));
        }


        /// <summary>
        /// Makes multiple UInt16 to nullable Int16 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt16 tests")]
        public void TestUInt16ToInt16Nullable()
        {
            // Test conversion of source type minimum value
            UInt16 source = UInt16.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            Int16? result = source.ToInt16Nullable();
            Assert.AreEqual((short)0, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type value 42 to target type
            source = (ushort)42;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToInt16Nullable();
            Assert.AreEqual((short)42, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type maximum value
            source = UInt16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (65535) is greater than the target type's maximum value (32767).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple Int32 to Int16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt16 tests")]
        public void TestInt32ToInt16OrDefault()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            Int16? result = source.ToInt16OrDefault((short)86);
    
            // Here we would expect this conversion to fail (and return the default value of (short)86), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (-32768).
            Assert.AreEqual((short)86, result);
            Assert.IsInstanceOfType(result, typeof(Int16));
            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToInt16OrDefault((short)86);
            Assert.AreEqual((short)42, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToInt16OrDefault((short)86);
            // Here we would expect this conversion to fail (and return the default value of (short)86), 
            // since the source type's maximum value (2147483647) is greater than the target type's maximum value (32767).
            Assert.AreEqual((short)86, result);
            Assert.IsInstanceOfType(result, typeof(Int16));
        }


        /// <summary>
        /// Makes multiple Int32 to nullable Int16 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt16 tests")]
        public void TestInt32ToInt16Nullable()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            Int16? result = source.ToInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (-32768).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToInt16Nullable();
            Assert.AreEqual((short)42, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (2147483647) is greater than the target type's maximum value (32767).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple UInt32 to Int16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt16 tests")]
        public void TestUInt32ToInt16OrDefault()
        {
            // Test conversion of source type minimum value
            UInt32 source = UInt32.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            Int16? result = source.ToInt16OrDefault((short)86);
    
            Assert.AreEqual((short)0, result);
            Assert.IsInstanceOfType(result, typeof(Int16));
            // Test conversion of source type value 42 to target type
            source = 42u;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToInt16OrDefault((short)86);
            Assert.AreEqual((short)42, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type maximum value
            source = UInt32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToInt16OrDefault((short)86);
            // Here we would expect this conversion to fail (and return the default value of (short)86), 
            // since the source type's maximum value (4294967295) is greater than the target type's maximum value (32767).
            Assert.AreEqual((short)86, result);
            Assert.IsInstanceOfType(result, typeof(Int16));
        }


        /// <summary>
        /// Makes multiple UInt32 to nullable Int16 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt16 tests")]
        public void TestUInt32ToInt16Nullable()
        {
            // Test conversion of source type minimum value
            UInt32 source = UInt32.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            Int16? result = source.ToInt16Nullable();
            Assert.AreEqual((short)0, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type value 42 to target type
            source = 42u;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToInt16Nullable();
            Assert.AreEqual((short)42, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type maximum value
            source = UInt32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (4294967295) is greater than the target type's maximum value (32767).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple Int64 to Int16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt16 tests")]
        public void TestInt64ToInt16OrDefault()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            Int16? result = source.ToInt16OrDefault((short)86);
    
            // Here we would expect this conversion to fail (and return the default value of (short)86), 
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (-32768).
            Assert.AreEqual((short)86, result);
            Assert.IsInstanceOfType(result, typeof(Int16));
            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt16OrDefault((short)86);
            Assert.AreEqual((short)42, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt16OrDefault((short)86);
            // Here we would expect this conversion to fail (and return the default value of (short)86), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (32767).
            Assert.AreEqual((short)86, result);
            Assert.IsInstanceOfType(result, typeof(Int16));
        }


        /// <summary>
        /// Makes multiple Int64 to nullable Int16 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt16 tests")]
        public void TestInt64ToInt16Nullable()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            Int16? result = source.ToInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (-32768).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt16Nullable();
            Assert.AreEqual((short)42, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (32767).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple UInt64 to Int16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt16 tests")]
        public void TestUInt64ToInt16OrDefault()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            Int16? result = source.ToInt16OrDefault((short)86);
    
            Assert.AreEqual((short)0, result);
            Assert.IsInstanceOfType(result, typeof(Int16));
            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt16OrDefault((short)86);
            Assert.AreEqual((short)42, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt16OrDefault((short)86);
            // Here we would expect this conversion to fail (and return the default value of (short)86), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (32767).
            Assert.AreEqual((short)86, result);
            Assert.IsInstanceOfType(result, typeof(Int16));
        }


        /// <summary>
        /// Makes multiple UInt64 to nullable Int16 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt16 tests")]
        public void TestUInt64ToInt16Nullable()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            Int16? result = source.ToInt16Nullable();
            Assert.AreEqual((short)0, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt16Nullable();
            Assert.AreEqual((short)42, result);
            Assert.IsInstanceOfType(result, typeof(Int16));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (32767).
            Assert.IsNull(result);
        }

        /* 
        Single to Int16: Method omitted.
        Int16 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to Int16: Method omitted.
        Int16 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to Int16: Method omitted.
        Int16 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

    }
}
