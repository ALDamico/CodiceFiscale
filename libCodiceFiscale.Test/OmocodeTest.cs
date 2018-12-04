using libCodiceFiscale.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace libCodiceFiscale.Test
{
    [TestClass]
    public class OmocodeTest
    {
        [TestMethod]
        public void ListTest()
        {
            string CF = "DMCNRL90E03B202A";
            OmocodeGenerator.InitialFiscalCode = CF;
            OmocodeGenerator.GenerateOmocodes();
            Assert.AreEqual(8, OmocodeGenerator.OmocodeFiscalCodes.Count);
        }
    }
}
