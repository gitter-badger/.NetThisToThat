
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
            source = (short)42;
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
            source = (short)42;
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
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (0).
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
            Assert.AreEqual(9223372036854775807UL, result);
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
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (0).
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
            Assert.AreEqual(9223372036854775807UL, result);
            Assert.IsInstanceOfType(result, typeof(UInt64));

        }

        /* 
        Single to UInt64: Method omitted.
        UInt64 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to UInt64: Method omitted.
        UInt64 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to UInt64: Method omitted.
        UInt64 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /// <summary>
        /// Makes multiple String to UInt64 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestStringToUInt64OrDefault()
        {
            // Test conversion of target type minimum value
            UInt64 resultMin = "0".ToUInt64OrDefault();
            Assert.AreEqual(0UL, resultMin);

            // Test conversion of fixed value (42)
            UInt64 result42 = "42".ToUInt64OrDefault();
            Assert.AreEqual(42UL, result42);
            
            // Test conversion of target type maximum value
            UInt64 resultMax = "18446744073709551615".ToUInt64OrDefault();
            Assert.AreEqual(18446744073709551615UL, resultMax);

            // Test conversion of "foo"
            UInt64 resultFoo = "foo".ToUInt64OrDefault(86UL);
            Assert.AreEqual(86UL, resultFoo);

        }

        /// <summary>
        /// Makes multiple String to UInt64Nullable conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt64 tests")]
        public void TestStringToUInt64Nullable()
        {
            // Test conversion of target type minimum value
            UInt64? resultMin = "0".ToUInt64Nullable();
            Assert.AreEqual(0UL, resultMin);

            // Test conversion of fixed value (42)
            UInt64? result42 = "42".ToUInt64Nullable();
            Assert.AreEqual(42UL, result42);
            
            // Test conversion of target type maximum value
            UInt64? resultMax = "18446744073709551615".ToUInt64Nullable();
            Assert.AreEqual(18446744073709551615UL, resultMax);

            // Test conversion of "foo"
            UInt64? resultFoo = "foo".ToUInt64Nullable();
            Assert.IsNull(resultFoo);

        }
    }
}
