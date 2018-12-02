using libCodiceFiscale.Entities;
using libCodiceFiscale.Interfaces;
using System.Linq;

namespace libCodiceFiscale.Models
{
    public class ForeignCountry : IPlace
    {
        #region Ctor
        public ForeignCountry(string name)
        {
            Name = name;
            using (var db = new LocalDataEntities())
            {
                Code = (from country in db.Stati
                        where country.Nome == name
                        select country.Codice).FirstOrDefault();
            }
        }
        #endregion

        #region Properties
        public string Code { get; set; }
        public string Name { get; set; }
        #endregion
    }
}