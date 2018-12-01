using libCodiceFiscale.Entities;
using libCodiceFiscale.Interfaces;
using System.Linq;

namespace libCodiceFiscale.Models
{
    public class ItalianMunicipality : IPlace
    {
        #region Ctor
        public ItalianMunicipality(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public ItalianMunicipality(string name)
        {
            Name = name;
            using (var db = new LocalDataEntities())
            {
                Province = db.Comuni.FirstOrDefault(i => i.Comune == name).Provincia;
                Code = db.Comuni.FirstOrDefault(i => i.Comune == name).Codice;
            }
        }
        #endregion

        #region Properties
        public string Province { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        #endregion
    }
}