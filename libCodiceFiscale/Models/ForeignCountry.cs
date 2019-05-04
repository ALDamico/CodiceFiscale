using libCodiceFiscale.Entities;
using libCodiceFiscale.Interfaces;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace libCodiceFiscale.Models
{
    public class ForeignCountry : IPlace
    {
        #region Ctor
        public ForeignCountry(string name)
        {
            Name = name;
            using (var db = new LocalitaContext())
            {
                Code = (from country in db.ForeignCountries
                        where country.Name == name
                        select country.Code).FirstOrDefault();
            }
        }
        #endregion

        #region Properties

        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        #endregion
    }
}