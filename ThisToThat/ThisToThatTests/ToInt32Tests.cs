
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
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (-2147483648).
            Assert.AreEqual(86, result);
            Assert.IsInstanceOfType(result, typeof(Int32));
            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt32OrDefault(86);
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (2147483647).
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
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (-2147483648).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt32Nullable();
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (2147483647).
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
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt32OrDefault(86);
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt32OrDefault(86);
            // Here we would expect this conversion to fail (and return the default value of 86), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (2147483647).
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
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt32Nullable();
            Assert.AreEqual(42, result);
            Assert.IsInstanceOfType(result, typeof(Int32));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (2147483647).
            Assert.IsNull(result);
        }

        /* 
        Single to Int32: Method omitted.
        Int32 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to Int32: Method omitted.
        Int32 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to Int32: Method omitted.
        Int32 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

    }
}
