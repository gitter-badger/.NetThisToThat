
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToSByteTests
    {



        /// <summary>
        /// Makes multiple Byte to SByte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestByteToSByteOrDefault()
        {
            // Test conversion of source type minimum value
            Byte source = Byte.MinValue;
            Assert.IsInstanceOfType(source, typeof(Byte));
            SByte? result = source.ToSByteOrDefault((sbyte)86);
    
            Assert.AreEqual((sbyte)0, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
            // Test conversion of source type value 42 to target type
            source = (byte)42;
            Assert.IsInstanceOfType(source, typeof(Byte));
            result = source.ToSByteOrDefault((sbyte)86);
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = Byte.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Byte));
            result = source.ToSByteOrDefault((sbyte)86);
            // Here we would expect this conversion to fail (and return the default value of (sbyte)86), 
            // since the source type's maximum value (255) is greater than the target type's maximum value (127).
            Assert.AreEqual((sbyte)86, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
        }


        /// <summary>
        /// Makes multiple Byte to nullable SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestByteToSByteNullable()
        {
            // Test conversion of source type minimum value
            Byte source = Byte.MinValue;
            Assert.IsInstanceOfType(source, typeof(Byte));
            SByte? result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)0, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type value 42 to target type
            source = (byte)42;
            Assert.IsInstanceOfType(source, typeof(Byte));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = Byte.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Byte));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (255) is greater than the target type's maximum value (127).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple Int16 to SByte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestInt16ToSByteOrDefault()
        {
            // Test conversion of source type minimum value
            Int16 source = Int16.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            SByte? result = source.ToSByteOrDefault((sbyte)86);
    
            // Here we would expect this conversion to fail (and return the default value of (sbyte)86), 
            // since the source type's minimum value (-32768) is less than the target type's minimum value (-128).
            Assert.AreEqual((sbyte)86, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
            // Test conversion of source type value 42 to target type
            source = (short)42;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToSByteOrDefault((sbyte)86);
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = Int16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToSByteOrDefault((sbyte)86);
            // Here we would expect this conversion to fail (and return the default value of (sbyte)86), 
            // since the source type's maximum value (32767) is greater than the target type's maximum value (127).
            Assert.AreEqual((sbyte)86, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
        }


        /// <summary>
        /// Makes multiple Int16 to nullable SByte conversions and asserts that the results are correct.
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
            source = (short)42;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = Int16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int16));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (32767) is greater than the target type's maximum value (127).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple UInt16 to SByte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestUInt16ToSByteOrDefault()
        {
            // Test conversion of source type minimum value
            UInt16 source = UInt16.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            SByte? result = source.ToSByteOrDefault((sbyte)86);
    
            Assert.AreEqual((sbyte)0, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
            // Test conversion of source type value 42 to target type
            source = (ushort)42;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToSByteOrDefault((sbyte)86);
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = UInt16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToSByteOrDefault((sbyte)86);
            // Here we would expect this conversion to fail (and return the default value of (sbyte)86), 
            // since the source type's maximum value (65535) is greater than the target type's maximum value (127).
            Assert.AreEqual((sbyte)86, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
        }


        /// <summary>
        /// Makes multiple UInt16 to nullable SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestUInt16ToSByteNullable()
        {
            // Test conversion of source type minimum value
            UInt16 source = UInt16.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            SByte? result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)0, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type value 42 to target type
            source = (ushort)42;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = UInt16.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt16));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (65535) is greater than the target type's maximum value (127).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple Int32 to SByte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestInt32ToSByteOrDefault()
        {
            // Test conversion of source type minimum value
            Int32 source = Int32.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            SByte? result = source.ToSByteOrDefault((sbyte)86);
    
            // Here we would expect this conversion to fail (and return the default value of (sbyte)86), 
            // since the source type's minimum value (-2147483648) is less than the target type's minimum value (-128).
            Assert.AreEqual((sbyte)86, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
            // Test conversion of source type value 42 to target type
            source = 42;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToSByteOrDefault((sbyte)86);
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToSByteOrDefault((sbyte)86);
            // Here we would expect this conversion to fail (and return the default value of (sbyte)86), 
            // since the source type's maximum value (2147483647) is greater than the target type's maximum value (127).
            Assert.AreEqual((sbyte)86, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
        }


        /// <summary>
        /// Makes multiple Int32 to nullable SByte conversions and asserts that the results are correct.
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
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = Int32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int32));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (2147483647) is greater than the target type's maximum value (127).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple UInt32 to SByte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestUInt32ToSByteOrDefault()
        {
            // Test conversion of source type minimum value
            UInt32 source = UInt32.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            SByte? result = source.ToSByteOrDefault((sbyte)86);
    
            Assert.AreEqual((sbyte)0, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
            // Test conversion of source type value 42 to target type
            source = 42u;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToSByteOrDefault((sbyte)86);
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = UInt32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToSByteOrDefault((sbyte)86);
            // Here we would expect this conversion to fail (and return the default value of (sbyte)86), 
            // since the source type's maximum value (4294967295) is greater than the target type's maximum value (127).
            Assert.AreEqual((sbyte)86, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
        }


        /// <summary>
        /// Makes multiple UInt32 to nullable SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestUInt32ToSByteNullable()
        {
            // Test conversion of source type minimum value
            UInt32 source = UInt32.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            SByte? result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)0, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type value 42 to target type
            source = 42u;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = UInt32.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt32));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (4294967295) is greater than the target type's maximum value (127).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple Int64 to SByte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestInt64ToSByteOrDefault()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            SByte? result = source.ToSByteOrDefault((sbyte)86);
    
            // Here we would expect this conversion to fail (and return the default value of (sbyte)86), 
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (-128).
            Assert.AreEqual((sbyte)86, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToSByteOrDefault((sbyte)86);
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToSByteOrDefault((sbyte)86);
            // Here we would expect this conversion to fail (and return the default value of (sbyte)86), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (127).
            Assert.AreEqual((sbyte)86, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
        }


        /// <summary>
        /// Makes multiple Int64 to nullable SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestInt64ToSByteNullable()
        {
            // Test conversion of source type minimum value
            Int64 source = Int64.MinValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            SByte? result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's minimum value (-9223372036854775808) is less than the target type's minimum value (-128).
            Assert.IsNull(result);

            // Test conversion of source type value 42 to target type
            source = 42L;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = Int64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(Int64));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (9223372036854775807) is greater than the target type's maximum value (127).
            Assert.IsNull(result);
        }


        /// <summary>
        /// Makes multiple UInt64 to SByte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestUInt64ToSByteOrDefault()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            SByte? result = source.ToSByteOrDefault((sbyte)86);
    
            Assert.AreEqual((sbyte)0, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToSByteOrDefault((sbyte)86);
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToSByteOrDefault((sbyte)86);
            // Here we would expect this conversion to fail (and return the default value of (sbyte)86), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (127).
            Assert.AreEqual((sbyte)86, result);
            Assert.IsInstanceOfType(result, typeof(SByte));
        }


        /// <summary>
        /// Makes multiple UInt64 to nullable SByte conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestUInt64ToSByteNullable()
        {
            // Test conversion of source type minimum value
            UInt64 source = UInt64.MinValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            SByte? result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)0, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type value 42 to target type
            source = 42UL;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToSByteNullable();
            Assert.AreEqual((sbyte)42, result);
            Assert.IsInstanceOfType(result, typeof(SByte));

            // Test conversion of source type maximum value
            source = UInt64.MaxValue;
            Assert.IsInstanceOfType(source, typeof(UInt64));
            result = source.ToSByteNullable();
            // Here we would expect this conversion to fail (and return null), 
            // since the source type's maximum value (18446744073709551615) is greater than the target type's maximum value (127).
            Assert.IsNull(result);
        }

        /* 
        Single to SByte: Method omitted.
        SByte is an integral type. Single is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Double to SByte: Method omitted.
        SByte is an integral type. Double is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /* 
        Decimal to SByte: Method omitted.
        SByte is an integral type. Decimal is non-integral (can contain fractions).
        Conversions involving possible rounding or truncation are not currently provided by this library.
        */

        /// <summary>
        /// Makes multiple String to SByte or default conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestStringToSByteOrDefault()
        {
            // Test conversion of target type minimum value
            SByte resultMin = "-128".ToSByteOrDefault();
            Assert.AreEqual((sbyte)-128, resultMin);

            // Test conversion of fixed value (42)
            SByte result42 = "42".ToSByteOrDefault();
            Assert.AreEqual((sbyte)42, result42);
            
            // Test conversion of target type maximum value
            SByte resultMax = "127".ToSByteOrDefault();
            Assert.AreEqual((sbyte)127, resultMax);

            // Test conversion of "foo"
            SByte resultFoo = "foo".ToSByteOrDefault((sbyte)86);
            Assert.AreEqual((sbyte)86, resultFoo);

        }

        /// <summary>
        /// Makes multiple String to SByteNullable conversions and asserts that the results are correct.
        /// </summary>
        [TestMethod, TestCategory("ToSByte tests")]
        public void TestStringToSByteNullable()
        {
            // Test conversion of target type minimum value
            SByte? resultMin = "-128".ToSByteNullable();
            Assert.AreEqual((sbyte)-128, resultMin);

            // Test conversion of fixed value (42)
            SByte? result42 = "42".ToSByteNullable();
            Assert.AreEqual((sbyte)42, result42);
            
            // Test conversion of target type maximum value
            SByte? resultMax = "127".ToSByteNullable();
            Assert.AreEqual((sbyte)127, resultMax);

            // Test conversion of "foo"
            SByte? resultFoo = "foo".ToSByteNullable();
            Assert.IsNull(resultFoo);

        }
    }
}
