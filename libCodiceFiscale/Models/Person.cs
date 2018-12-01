using libCodiceFiscale.Interfaces;
using System;

namespace libCodiceFiscale.Models
{
    public class Person
    {
        #region Ctor
        /// <summary>
        /// Costruisce l'oggetto Person.
        /// </summary>
        public Person()
        {
            DateOfBirth = new DateTime();
        }

        /// <summary>
        /// Costruisce l'oggetto Person e inizializza il valore della proprietà PlaceOfBirth.
        /// </summary>
        /// <param name="placeName">Il nome del comune italiano o dello stato estero da usare per inizializzare la proprietà.</param>
        public Person(string placeName) : this()
        {
            PlaceOfBirth = new ItalianMunicipality(placeName);
            if (PlaceOfBirth == null)
            {
                PlaceOfBirth = new ForeignCountry(placeName);
            }
            if (PlaceOfBirth == null)
            {
                throw new Exception($"Località {placeName} non trovata!");
            }
        }
        #endregion
        
        #region Utility functions
        private bool IsGenderValid(char val)
        {
            if (char.ToUpper(val) == 'M' ||
                char.ToUpper(val) == 'F')
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Fields
        private char _gender;
        private DateTime _dateOfBirth;
        #endregion
        
        #region Properties
        public IPlace PlaceOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new InvalidOperationException($"La data '{value}' non è consentita. Consentite solo date precedenti a {DateTime.Now}.");
                }
                else
                {
                    _dateOfBirth = value;
                }
            }
        }
        public char Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (IsGenderValid(value))
                {
                    _gender = value;
                }
                else
                {
                    throw new InvalidOperationException($"Valore '{value}' non consentito. Il sesso può essere solo 'M' o 'F'.");
                }
            }
        }
        #endregion
    }
}