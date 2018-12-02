using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using libCodiceFiscale.Models;

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
            Assert.AreEqual(9, OmocodeGenerator.OmocodeFiscalCodes.Count);
        }
    }
}
