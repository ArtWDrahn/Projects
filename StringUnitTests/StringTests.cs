//-----------------------------------------------------------------------
// <copyright file="StringTests.cs" company="Tyson J. Hayes">
//     Copyright (c), Tyson J. Hayes. All rights reserved.
// </copyright>
// <summary>
//    Testing for all of the string methods.
// </summary>
// <author>
//    Tyson J. Hayes (jobs@tysonjhayes.com)
// </author>
//-----------------------------------------------------------------------

namespace StringUnitTests
{
    using CustomString;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The string tests.
    /// </summary>
    [TestClass]
    public class StringTests
    {
        /// <summary>
        /// The reverse a string unit test.
        /// </summary>
        [TestMethod]
        public void ReverseAStringUnitTest()
        {
            const string TestString = "This is a test.";
            const string ExpectedOutput = ".tset a si sihT";
            Assert.AreEqual(Manipulate.Reverse(TestString), ExpectedOutput);
        }
    }
}
