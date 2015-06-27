
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToUInt16Tests
    {



        /// <summary>
        /// Makes multiple SByte to UInt16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestSByteToUInt16OrDefault()
        {
            // Test conversion of source type minimum value
            SByte source = SByte.MinValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            UInt16? result = source.ToUInt16OrDefault((ushort)86);
    
            // Here we would expect this conversion to fail (and return the default value of (ushort)86), 
            // since the source type's minimum value (-128) is less than the target type's minimum value (0).
            Assert.AreEqual((ushort)86, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
            // Test conversion of source type value 42 to target type
            source = (sbyte)42;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt16OrDefault((ushort)86);
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = SByte.MaxValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt16OrDefault((ushort)86);
            Assert.AreEqual((ushort)127, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
        }


        /// <summary>
        /// Makes multiple SByte to nullable UInt16 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestSByteToUInt16Nullable()
        {
            // Test conversion of source type minimum value
            SByte source = SByte.MinValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            UInt16? result = source.ToUInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-128) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = (sbyte)42;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt16Nullable();
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = SByte.MaxValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToUInt16Nullable();
            Assert.AreEqual((ushort)127, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

        }

        /* 
        Byte to UInt16: Test omitted
        There is a predefined implicit conversion from Byte to UInt16
        */


        /// <summary>
        /// Makes multiple Int16 to UInt16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestInt16ToUInt16OrDefault()
        {
            // Test conversion of source type minimum value
            Int16 source = Int16.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            UInt16? result = source.ToUInt16OrDefault((ushort)86);
    
            // Here we would expect this conversion to fail (and return the default value of (ushort)86), 
            // since the source type's minimum value (-32768) is less than the target type's minimum value (0).
            Assert.AreEqual((ushort)86, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
            // Test conversion of source type value 42 to target type
            source = (short)42;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt16OrDefault((ushort)86);
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = Int16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt16OrDefault((ushort)86);
            Assert.AreEqual((ushort)32767, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
        }


        /// <summary>
        /// Makes multiple Int16 to nullable UInt16 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestInt16ToUInt16Nullable()
        {
            // Test conversion of source type minimum value
            Int16 source = Int16.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            UInt16? result = source.ToUInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-32768) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = (short)42;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt16Nullable();
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = Int16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToUInt16Nullable();
            Assert.AreEqual((ushort)32767, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

        }


        /// <summary>
        /// Makes multiple Int32 to UInt16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestInt32ToUInt16OrDefault()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            UInt16? result = source.ToUInt16OrDefault((ushort)86);
    
            // Here we would expect this conversion to fail (and return the default value of (ushort)86), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (0).
            Assert.AreEqual((ushort)86, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt16OrDefault((ushort)86);
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt16OrDefault((ushort)86);
            // Here we would expect this conversion to fail (and return the default value of (ushort)86), 
            // since the source type's maximum value (2147483647) is greater than the target type's maximum value (65535).
            Assert.AreEqual((ushort)86, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
        }


        /// <summary>
        /// Makes multiple Int32 to nullable UInt16 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestInt32ToUInt16Nullable()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            UInt16? result = source.ToUInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt16Nullable();
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToUInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (2147483647) is greater than the target type's maximum value (65535).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple UInt32 to UInt16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestUInt32ToUInt16OrDefault()
        {
            // Test conversion of source type minimum value
            UInt32 source = UInt32.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            UInt16? result = source.ToUInt16OrDefault((ushort)86);
    
            Assert.AreEqual((ushort)0, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
            // Test conversion of source type value 42 to target type
            source = 42u;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToUInt16OrDefault((ushort)86);
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = UInt32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToUInt16OrDefault((ushort)86);
            // Here we would expect this conversion to fail (and return the default value of (ushort)86), 
            // since the source type's maximum value (4294967295) is greater than the target type's maximum value (65535).
            Assert.AreEqual((ushort)86, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
        }


        /// <summary>
        /// Makes multiple UInt32 to nullable UInt16 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestUInt32ToUInt16Nullable()
        {
            // Test conversion of source type minimum value
            UInt32 source = UInt32.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            UInt16? result = source.ToUInt16Nullable();
            Assert.AreEqual((ushort)0, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type value 42 to target type
            source = 42u;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToUInt16Nullable();
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = UInt32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToUInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (4294967295) is greater than the target type's maximum value (65535).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple Int64 to UInt16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestInt64ToUInt16OrDefault()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            UInt16? result = source.ToUInt16OrDefault((ushort)86);
    
            // Here we would expect this conversion to fail (and return the default value of (ushort)86), 
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (0).
            Assert.AreEqual((ushort)86, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToUInt16OrDefault((ushort)86);
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToUInt16OrDefault((ushort)86);
            // Here we would expect this conversion to fail (and return the default value of (ushort)86), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (65535).
            Assert.AreEqual((ushort)86, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
        }


        /// <summary>
        /// Makes multiple Int64 to nullable UInt16 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestInt64ToUInt16Nullable()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            UInt16? result = source.ToUInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToUInt16Nullable();
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToUInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (65535).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple UInt64 to UInt16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestUInt64ToUInt16OrDefault()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            UInt16? result = source.ToUInt16OrDefault((ushort)86);
    
            Assert.AreEqual((ushort)0, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToUInt16OrDefault((ushort)86);
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToUInt16OrDefault((ushort)86);
            // Here we would expect this conversion to fail (and return the default value of (ushort)86), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (65535).
            Assert.AreEqual((ushort)86, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));
        }


        /// <summary>
        /// Makes multiple UInt64 to nullable UInt16 conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestUInt64ToUInt16Nullable()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            UInt16? result = source.ToUInt16Nullable();
            Assert.AreEqual((ushort)0, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToUInt16Nullable();
            Assert.AreEqual((ushort)42, result);
            Assert.IsInstanceOfType(result, typeof(UInt16));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToUInt16Nullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (65535).
            Assert.IsNull(result);
        }

        /* 
        Single to UInt16: Method omitted.
        UInt16 is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to UInt16: Method omitted.
        UInt16 is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to UInt16: Method omitted.
        UInt16 is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /// <summary>
        /// Makes multiple String to UInt16 or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestStringToUInt16OrDefault()
        {
            // Test conversion of target type minimum value
            UInt16 resultMin = "0".ToUInt16OrDefault();
            Assert.AreEqual((ushort)0, resultMin);

            // Test conversion of fixed value (42)
            UInt16 result42 = "42".ToUInt16OrDefault();
            Assert.AreEqual((ushort)42, result42);
            
            // Test conversion of target type maximum value
            UInt16 resultMax = "0".ToUInt16OrDefault();
            Assert.AreEqual((ushort)0, resultMax);

            // Test conversion of "foo"
            UInt16 resultFoo = "foo".ToUInt16OrDefault((ushort)86);
            Assert.IsNull(resultFoo);

        }

        /// <summary>
        /// Makes multiple String to UInt16Nullable conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToUInt16 tests")]
        public void TestStringToUInt16Nullable()
        {
            // Test conversion of target type minimum value
            UInt16? resultMin = "0".ToUInt16Nullable();
            Assert.AreEqual((ushort)0, resultMin);

            // Test conversion of fixed value (42)
            UInt16? result42 = "42".ToUInt16Nullable();
            Assert.AreEqual((ushort)42, result42);
            
            // Test conversion of target type maximum value
            UInt16? resultMax = "0".ToUInt16Nullable();
            Assert.AreEqual((ushort)0, resultMax);

            // Test conversion of "foo"
            UInt16? resultFoo = "foo".ToUInt16Nullable();
            Assert.AreEqual((ushort)86, resultFoo);

        }
    }
}
