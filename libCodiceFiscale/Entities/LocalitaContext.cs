using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libCodiceFiscale.Models;
using System.Data.Entity;

namespace libCodiceFiscale.Entities
{
    public class LocalitaContext:DbContext
    {
        public LocalitaContext() : base(new SQLiteConnection("Data Source=Data/app.db;"), false)
        {
            Database.SetInitializer<LocalitaContext>(null);
            Console.WriteLine(ItalianMunicipalities.Sql); 
        }

        

        public virtual DbSet<Comuni_Italiani> ItalianMunicipalities { get; set; }
        public virtual DbSet<ForeignCountry> ForeignCountries { get; set; }
    }
}


