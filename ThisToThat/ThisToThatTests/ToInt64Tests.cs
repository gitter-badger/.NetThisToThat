
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToInt64Tests
    {


        /* 
        SByte to Int64: Test omitted
        There is a predefined implicit conversion from SByte to Int64
        */

        /* 
        Byte to Int64: Test omitted
        There is a predefined implicit conversion from Byte to Int64
        */

        /* 
        Int16 to Int64: Test omitted
        There is a predefined implicit conversion from Int16 to Int64
        */

        /* 
        UInt16 to Int64: Test omitted
        There is a predefined implicit conversion from UInt16 to Int64
        */

        /* 
        Int32 to Int64: Test omitted
        There is a predefined implicit conversion from Int32 to Int64
        */

        /* 
        UInt32 to Int64: Test omitted
        There is a predefined implicit conversion from UInt32 to Int64
        */


        /// <summary>
        /// Makes multiple UInt64 to Int64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt64 tests")]
        public void TestUInt64ToInt64OrDefault()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            Int64? result = source.ToInt64OrDefault(86L);
    
            Assert.AreEqual(0L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));
            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt64OrDefault(86L);
            Assert.AreEqual(42L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt64OrDefault(86L);
            // Here we would expect this conversion to fail (and return the default value of 86L), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (9223372036854775807).
            Assert.AreEqual(86L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));
        }


        /// <summary>
        /// Makes multiple UInt64 to nullable Int64 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToInt64 tests")]
        public void TestUInt64ToInt64Nullable()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            Int64? result = source.ToInt64Nullable();
            Assert.AreEqual(0L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt64Nullable();
            Assert.AreEqual(42L, result);
            Assert.IsInstanceOfType(result, typeof(Int64));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToInt64Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (9223372036854775807).
            Assert.IsNull(result);
        }

        /* 
        Single to Int64: Method omitted.
        Int64 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to Int64: Method omitted.
        Int64 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to Int64: Method omitted.
        Int64 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

    }
}
