
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToUInt32Tests
    {



        /// <summary>
        /// Makes multiple SByte to UInt32 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt32 tests")]
        public void TestSByteToUInt32OrDefault()
        {
            // Test conversion of source type minimum value
            SByte source = SByte.MinValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            UInt32? result = source.ToUInt32OrDefault(86u);
    
            // Here we would expect this conversion to fail (and return the default value of 86u), 
            // since the source type's minimum value (-128) is less than the target type's minimum value (0).
            Assert.AreEqual(86u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));
            // Test conversion of source type value 42 to target type
            source = (sbyte)42;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt32OrDefault(86u);
            Assert.AreEqual(42u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

            // Test conversion of source type maximum value
            source = SByte.MaxValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt32OrDefault(86u);
            Assert.AreEqual(127u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));
        }


        /// <summary>
        /// Makes multiple SByte to nullable UInt32 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt32 tests")]
        public void TestSByteToUInt32Nullable()
        {
            // Test conversion of source type minimum value
            SByte source = SByte.MinValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            UInt32? result = source.ToUInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-128) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = (sbyte)42;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt32Nullable();
            Assert.AreEqual(42u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

            // Test conversion of source type maximum value
            source = SByte.MaxValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt32Nullable();
            Assert.AreEqual(127u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

        }

        /* 
        Byte to UInt32: Test omitted
        There is a predefined implicit conversion from Byte to UInt32
        */


        /// <summary>
        /// Makes multiple Int16 to UInt32 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt32 tests")]
        public void TestInt16ToUInt32OrDefault()
        {
            // Test conversion of source type minimum value
            Int16 source = Int16.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            UInt32? result = source.ToUInt32OrDefault(86u);
    
            // Here we would expect this conversion to fail (and return the default value of 86u), 
            // since the source type's minimum value (-32768) is less than the target type's minimum value (0).
            Assert.AreEqual(86u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));
            // Test conversion of source type value 42 to target type
            source = (short)42;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt32OrDefault(86u);
            Assert.AreEqual(42u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

            // Test conversion of source type maximum value
            source = Int16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt32OrDefault(86u);
            Assert.AreEqual(32767u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));
        }


        /// <summary>
        /// Makes multiple Int16 to nullable UInt32 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt32 tests")]
        public void TestInt16ToUInt32Nullable()
        {
            // Test conversion of source type minimum value
            Int16 source = Int16.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            UInt32? result = source.ToUInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-32768) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = (short)42;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt32Nullable();
            Assert.AreEqual(42u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

            // Test conversion of source type maximum value
            source = Int16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt32Nullable();
            Assert.AreEqual(32767u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

        }

        /* 
        UInt16 to UInt32: Test omitted
        There is a predefined implicit conversion from UInt16 to UInt32
        */


        /// <summary>
        /// Makes multiple Int32 to UInt32 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt32 tests")]
        public void TestInt32ToUInt32OrDefault()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            UInt32? result = source.ToUInt32OrDefault(86u);
    
            // Here we would expect this conversion to fail (and return the default value of 86u), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (0).
            Assert.AreEqual(86u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));
            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt32OrDefault(86u);
            Assert.AreEqual(42u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt32OrDefault(86u);
            Assert.AreEqual(2147483647u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));
        }


        /// <summary>
        /// Makes multiple Int32 to nullable UInt32 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt32 tests")]
        public void TestInt32ToUInt32Nullable()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            UInt32? result = source.ToUInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt32Nullable();
            Assert.AreEqual(42u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt32Nullable();
            Assert.AreEqual(2147483647u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

        }


        /// <summary>
        /// Makes multiple Int64 to UInt32 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt32 tests")]
        public void TestInt64ToUInt32OrDefault()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            UInt32? result = source.ToUInt32OrDefault(86u);
    
            // Here we would expect this conversion to fail (and return the default value of 86u), 
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (0).
            Assert.AreEqual(86u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));
            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToUInt32OrDefault(86u);
            Assert.AreEqual(42u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToUInt32OrDefault(86u);
            // Here we would expect this conversion to fail (and return the default value of 86u), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (4294967295).
            Assert.AreEqual(86u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));
        }


        /// <summary>
        /// Makes multiple Int64 to nullable UInt32 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt32 tests")]
        public void TestInt64ToUInt32Nullable()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            UInt32? result = source.ToUInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToUInt32Nullable();
            Assert.AreEqual(42u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToUInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (4294967295).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple UInt64 to UInt32 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt32 tests")]
        public void TestUInt64ToUInt32OrDefault()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            UInt32? result = source.ToUInt32OrDefault(86u);
    
            Assert.AreEqual(0u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));
            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToUInt32OrDefault(86u);
            Assert.AreEqual(42u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToUInt32OrDefault(86u);
            // Here we would expect this conversion to fail (and return the default value of 86u), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (4294967295).
            Assert.AreEqual(86u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));
        }


        /// <summary>
        /// Makes multiple UInt64 to nullable UInt32 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt32 tests")]
        public void TestUInt64ToUInt32Nullable()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            UInt32? result = source.ToUInt32Nullable();
            Assert.AreEqual(0u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToUInt32Nullable();
            Assert.AreEqual(42u, result);
            Assert.IsInstanceOfType(result, typeof(UInt32));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToUInt32Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (4294967295).
            Assert.IsNull(result);
        }

        /* 
        Single to UInt32: Method omitted.
        UInt32 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to UInt32: Method omitted.
        UInt32 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to UInt32: Method omitted.
        UInt32 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

    }
}
