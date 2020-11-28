// --------------------------------------------------------------------------------------------------------------------
// <copyright file="User Registration MS Testing.cs" company="Bridgelabz">
//   Copyright © 2018 Company// </copyright>
// <creator Name="Nikhil Kumar Yadav"/>
// --------------------------------------------------------------------------------------------------------------------

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
    }
}
