using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThisToThat;

namespace ThisToThatTests
{
    [TestClass]
    public class ToBooleanTests
    {
        [TestMethod, TestCategory("ToBoolean tests")]
        public void TestStringToBooleanOrDefault()
        {
            Assert.AreEqual(true, "true".ToBooleanOrDefault());
            Assert.AreEqual(true, "t".ToBooleanOrDefault());
            Assert.AreEqual(true, "yes".ToBooleanOrDefault());
            Assert.AreEqual(true, "y".ToBooleanOrDefault());
            Assert.AreEqual(true, "on".ToBooleanOrDefault());
            Assert.AreEqual(true, "1".ToBooleanOrDefault());

            Assert.AreEqual(false, "false".ToBooleanOrDefault(true));
            Assert.AreEqual(false, "f".ToBooleanOrDefault(true));
            Assert.AreEqual(false, "no".ToBooleanOrDefault(true));
            Assert.AreEqual(false, "n".ToBooleanOrDefault(true));
            Assert.AreEqual(false, "off".ToBooleanOrDefault(true));
            Assert.AreEqual(false, "0".ToBooleanOrDefault(true));

            Assert.AreEqual(false, "foo".ToBooleanOrDefault(false));
            Assert.AreEqual(true, "bar".ToBooleanOrDefault(true));
        }

        [TestMethod, TestCategory("ToBoolean tests")]
        public void TestStringToBooleanNullable()
        {
            Assert.AreEqual(true, "true".ToBooleanNullable());
            Assert.AreEqual(true, "t".ToBooleanNullable());
            Assert.AreEqual(true, "yes".ToBooleanNullable());
            Assert.AreEqual(true, "y".ToBooleanNullable());
            Assert.AreEqual(true, "on".ToBooleanNullable());
            Assert.AreEqual(true, "1".ToBooleanNullable());

            Assert.AreEqual(false, "false".ToBooleanNullable());
            Assert.AreEqual(false, "f".ToBooleanNullable());
            Assert.AreEqual(false, "no".ToBooleanNullable());
            Assert.AreEqual(false, "n".ToBooleanNullable());
            Assert.AreEqual(false, "off".ToBooleanNullable());
            Assert.AreEqual(false, "0".ToBooleanNullable());

            Assert.IsNull("foo".ToBooleanNullable());
        }


        [TestMethod, TestCategory("ToBoolean tests")]
        public void TestCharToBooleanOrDefault()
        {
            Assert.AreEqual(true, 't'.ToBooleanOrDefault());
            Assert.AreEqual(true, 'y'.ToBooleanOrDefault());
            Assert.AreEqual(true, '1'.ToBooleanOrDefault());

            Assert.AreEqual(false, 'f'.ToBooleanOrDefault(true));
            Assert.AreEqual(false, 'n'.ToBooleanOrDefault(true));
            Assert.AreEqual(false, '0'.ToBooleanOrDefault(true));

            Assert.AreEqual(false, 'a'.ToBooleanOrDefault(false));
            Assert.AreEqual(true, 'b'.ToBooleanOrDefault(true));
        }

        [TestMethod, TestCategory("ToBoolean tests")]
        public void TestCharToBooleanNullable()
        {
            Assert.AreEqual(true, 't'.ToBooleanNullable());
            Assert.AreEqual(true, 'y'.ToBooleanNullable());
            Assert.AreEqual(true, '1'.ToBooleanNullable());

            Assert.AreEqual(false, 'f'.ToBooleanNullable());
            Assert.AreEqual(false, 'n'.ToBooleanNullable());
            Assert.AreEqual(false, '0'.ToBooleanNullable());

            Assert.IsNull('x'.ToBooleanNullable());
        }

    }
}
