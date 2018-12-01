using libCodiceFiscale.Extensions;
using libCodiceFiscale.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace libCodiceFiscale.Test
{
    [TestClass]
    public class GeneratorTest
    {
        [TestMethod]
        public void TestStrip()
        {
            string test = "Andrea Luciano";
            test = test.RemovePunctuationAndWhitespaces();
            Assert.AreEqual("AndreaLuciano", test);
        }

        [TestMethod]
        public void TestPunct()
        {
            string test = "D'Amico";
            test = test.RemovePunctuationAndWhitespaces();
            Assert.AreEqual("DAmico", test);
        }

        [TestMethod]
        public void DateAndGenderTest()
        {
            Person p = new Person
            {
                Name = "Andrea Luciano",
                Surname = "Damico",
                DateOfBirth = new DateTime(1990, 5, 3),
                Gender = 'M',
                PlaceOfBirth = new ItalianMunicipality("BRONTE", "B202")
            };
            CFGenerator gen = new CFGenerator(p);
            gen.GenerateFiscalCode();
            Assert.AreEqual("DMCNRL90E03B202A", gen.FiscalCode);
        }

        [TestMethod]
        public void CodiceTest()
        {
            Person p = new Person
            {
                Name = "Gianfranco",
                Surname = "Damico",
                DateOfBirth = new DateTime(1955, 12, 4),
                Gender = 'M',
                PlaceOfBirth = new ItalianMunicipality("BRONTE", "B202")
            };
            CFGenerator gen = new CFGenerator(p);
            gen.GenerateFiscalCode();
            Assert.AreEqual("DMCGFR55T04B202I", gen.FiscalCode);
        }

        [TestMethod]
        public void CheckDigitTest()
        {
            Person p = new Person
            {
                Name = "Andrea Luciano",
                Surname = "Damico",
                DateOfBirth = new DateTime(1990, 5, 3),
                PlaceOfBirth = new ItalianMunicipality("BRONTE", "B202"),
                Gender = 'M'
            };
            CFGenerator gen = new CFGenerator(p);
            gen.GenerateFiscalCode();
            Assert.AreEqual(gen.CheckDigit, 'A');
        }

        //[TestMethod]
        //public void MunicipalityTest()
        //{
        //    ItalianMunicipality municipality = new ItalianMunicipality("BRONTE");
        //    Assert.AreEqual("B202", municipality.Code);
        //}
    }
}