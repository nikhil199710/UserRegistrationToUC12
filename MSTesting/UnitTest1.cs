using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration;

namespace MSTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            Pattern pattern = new Pattern();
            bool expected = true;
            string input = "Nikhil";

            bool var = pattern.validateFirstName(input);

            Assert.AreEqual(expected, var);
        }


        [TestMethod]
        public void TestLastName()
        {
            Pattern pattern = new Pattern();
            bool expected = true;
            string input = "Yadav";

            bool var = pattern.validateLastName(input);

            Assert.AreEqual(expected, var);
        }

        [TestMethod]
        public void TestEmail()
        {
            Pattern pattern = new Pattern();
            bool expected = true;
            string input = "Nikhil";

            bool var = pattern.validateEmail(input);

            Assert.AreEqual(expected, var);
        }

        [TestMethod]
        public void TestMobile()
        {
            Pattern pattern = new Pattern();
            bool expected = true;
            string input = "91 7896541238";

            bool var = pattern.validateMobile(input);

            Assert.AreEqual(expected, var);
        }

        [TestMethod]
        public void TestPass1()
        {
            Pattern pattern = new Pattern();
            bool expected = true;
            string input = "qwertygrte";

            bool var = pattern.validatePasswordrule1(input);

            Assert.AreEqual(expected, var);
        }


        [TestMethod]
        public void TestPas2()
        {
            Pattern pattern = new Pattern();
            bool expected = true;
            string input = "Qwertygrte";

            bool var = pattern.validatePasswordWithUppercase(input);

            Assert.AreEqual(expected, var);
        }
    }
}