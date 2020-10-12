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

            bool var = pattern.validateFirstName(input);

            Assert.AreEqual(expected, var);
        }

        [TestMethod]
        public void TestEmail()
        {
            Pattern pattern = new Pattern();
            bool expected = true;
            string input = "abc.xyz@bl.co.in";

            bool var = pattern.validateEmail(input);

            Assert.AreEqual(expected, var);
        }
    }
}