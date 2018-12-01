using libCodiceFiscale.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace libCodiceFiscale.Test
{
    [TestClass]
    public class ExtensionTests
    {
        [TestMethod]
        public void DateToTwoDigitsTest()
        {
            for (int i = 1900; i < 9999; i++)
            {
                DateTime date = new DateTime(i, 1, 1);
                Assert.AreEqual(i % 100, date.YearToTwoDigits());
            }
        }
    }
}