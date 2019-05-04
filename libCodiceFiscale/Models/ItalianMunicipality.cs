using libCodiceFiscale.Entities;
using libCodiceFiscale.Interfaces;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace libCodiceFiscale.Models
{

    public class Comuni_Italiani : IPlace
    {
        #region Ctor
        public Comuni_Italiani(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public Comuni_Italiani()
        {
            Name = null;
            Code = null;
        }

        public Comuni_Italiani(string name)
        {
            Name = name;
            using (var db = new LocalitaContext())
            {
                Province = db.ItalianMunicipalities.FirstOrDefault(i => i.Name == name).Province;
                Code = db.ItalianMunicipalities.FirstOrDefault(i => i.Name == name).Code;
            }
        }
        #endregion

        #region Properties
        [Key, Column("id_comune_italiano")]
        public int Id { get; set; }
        public string Province { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        #endregion
    }
}