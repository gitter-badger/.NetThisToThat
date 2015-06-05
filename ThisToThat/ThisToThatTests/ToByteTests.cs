
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToByteTests
    {



        /// <summary>
        /// Makes multiple SByte to Byte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestSByteToByteOrDefault()
        {
            // Test conversion of source type minimum value
            SByte source = SByte.MinValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            Byte? result = source.ToByteOrDefault((byte)86);
    
            // Here we would expect this conversion to fail (and return the default value of (byte)86), 
            // since the source type's minimum value (-128) is less than the target type's minimum value (0).
            Assert.AreEqual((byte)86, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
            // Test conversion of source type value 42 to target type
            source = (sbyte)42;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToByteOrDefault((byte)86);
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = SByte.MaxValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToByteOrDefault((byte)86);
            Assert.AreEqual((byte)127, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
        }


        /// <summary>
        /// Makes multiple SByte to nullable Byte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestSByteToByteNullable()
        {
            // Test conversion of source type minimum value
            SByte source = SByte.MinValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            Byte? result = source.ToByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-128) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = (sbyte)42;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToByteNullable();
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = SByte.MaxValue;
            Assert.IsInstanceOfType(source, typeof(SByte));
            result = source.ToByteNullable();
            Assert.AreEqual((byte)127, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

        }


        /// <summary>
        /// Makes multiple Int16 to Byte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestInt16ToByteOrDefault()
        {
            // Test conversion of source type minimum value
            Int16 source = Int16.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            Byte? result = source.ToByteOrDefault((byte)86);
    
            // Here we would expect this conversion to fail (and return the default value of (byte)86), 
            // since the source type's minimum value (-32768) is less than the target type's minimum value (0).
            Assert.AreEqual((byte)86, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
            // Test conversion of source type value 42 to target type
            source = (short)42;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToByteOrDefault((byte)86);
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = Int16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToByteOrDefault((byte)86);
            // Here we would expect this conversion to fail (and return the default value of (byte)86), 
            // since the source type's maximum value (32767) is greater than the target type's maximum value (255).
            Assert.AreEqual((byte)86, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
        }


        /// <summary>
        /// Makes multiple Int16 to nullable Byte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestInt16ToByteNullable()
        {
            // Test conversion of source type minimum value
            Int16 source = Int16.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            Byte? result = source.ToByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-32768) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = (short)42;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToByteNullable();
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = Int16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (32767) is greater than the target type's maximum value (255).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple UInt16 to Byte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestUInt16ToByteOrDefault()
        {
            // Test conversion of source type minimum value
            UInt16 source = UInt16.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            Byte? result = source.ToByteOrDefault((byte)86);
    
            Assert.AreEqual((byte)0, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
            // Test conversion of source type value 42 to target type
            source = (ushort)42;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToByteOrDefault((byte)86);
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = UInt16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToByteOrDefault((byte)86);
            // Here we would expect this conversion to fail (and return the default value of (byte)86), 
            // since the source type's maximum value (65535) is greater than the target type's maximum value (255).
            Assert.AreEqual((byte)86, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
        }


        /// <summary>
        /// Makes multiple UInt16 to nullable Byte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestUInt16ToByteNullable()
        {
            // Test conversion of source type minimum value
            UInt16 source = UInt16.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            Byte? result = source.ToByteNullable();
            Assert.AreEqual((byte)0, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type value 42 to target type
            source = (ushort)42;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToByteNullable();
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = UInt16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (65535) is greater than the target type's maximum value (255).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple Int32 to Byte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestInt32ToByteOrDefault()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            Byte? result = source.ToByteOrDefault((byte)86);
    
            // Here we would expect this conversion to fail (and return the default value of (byte)86), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (0).
            Assert.AreEqual((byte)86, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToByteOrDefault((byte)86);
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToByteOrDefault((byte)86);
            // Here we would expect this conversion to fail (and return the default value of (byte)86), 
            // since the source type's maximum value (2147483647) is greater than the target type's maximum value (255).
            Assert.AreEqual((byte)86, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
        }


        /// <summary>
        /// Makes multiple Int32 to nullable Byte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestInt32ToByteNullable()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            Byte? result = source.ToByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToByteNullable();
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (2147483647) is greater than the target type's maximum value (255).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple UInt32 to Byte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestUInt32ToByteOrDefault()
        {
            // Test conversion of source type minimum value
            UInt32 source = UInt32.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            Byte? result = source.ToByteOrDefault((byte)86);
    
            Assert.AreEqual((byte)0, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
            // Test conversion of source type value 42 to target type
            source = 42u;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToByteOrDefault((byte)86);
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = UInt32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToByteOrDefault((byte)86);
            // Here we would expect this conversion to fail (and return the default value of (byte)86), 
            // since the source type's maximum value (4294967295) is greater than the target type's maximum value (255).
            Assert.AreEqual((byte)86, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
        }


        /// <summary>
        /// Makes multiple UInt32 to nullable Byte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestUInt32ToByteNullable()
        {
            // Test conversion of source type minimum value
            UInt32 source = UInt32.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            Byte? result = source.ToByteNullable();
            Assert.AreEqual((byte)0, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type value 42 to target type
            source = 42u;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToByteNullable();
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = UInt32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (4294967295) is greater than the target type's maximum value (255).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple Int64 to Byte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestInt64ToByteOrDefault()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            Byte? result = source.ToByteOrDefault((byte)86);
    
            // Here we would expect this conversion to fail (and return the default value of (byte)86), 
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (0).
            Assert.AreEqual((byte)86, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToByteOrDefault((byte)86);
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToByteOrDefault((byte)86);
            // Here we would expect this conversion to fail (and return the default value of (byte)86), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (255).
            Assert.AreEqual((byte)86, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
        }


        /// <summary>
        /// Makes multiple Int64 to nullable Byte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestInt64ToByteNullable()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            Byte? result = source.ToByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (0).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToByteNullable();
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (255).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple UInt64 to Byte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestUInt64ToByteOrDefault()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            Byte? result = source.ToByteOrDefault((byte)86);
    
            Assert.AreEqual((byte)0, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToByteOrDefault((byte)86);
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToByteOrDefault((byte)86);
            // Here we would expect this conversion to fail (and return the default value of (byte)86), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (255).
            Assert.AreEqual((byte)86, result);
            Assert.IsInstanceOfType(result, typeof(Byte));
        }


        /// <summary>
        /// Makes multiple UInt64 to nullable Byte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToByte tests")]
        public void TestUInt64ToByteNullable()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            Byte? result = source.ToByteNullable();
            Assert.AreEqual((byte)0, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToByteNullable();
            Assert.AreEqual((byte)42, result);
            Assert.IsInstanceOfType(result, typeof(Byte));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (255).
            Assert.IsNull(result);
        }

        /* 
        Single to Byte: Method omitted.
        Byte is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to Byte: Method omitted.
        Byte is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to Byte: Method omitted.
        Byte is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

    }
}
