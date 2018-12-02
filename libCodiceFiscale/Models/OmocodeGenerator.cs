using System;
using System.Collections.Generic;

namespace libCodiceFiscale.Models
{
    public static class OmocodeGenerator
    {
        static OmocodeGenerator()
        {
            OmocodeFiscalCodes = new List<string>();
        }

        public static void GenerateOmocodes()
        {
            if (string.IsNullOrEmpty(InitialFiscalCode))
            {
                throw new InvalidOperationException("Codice iniziale non specificato!");
            }

            string temp = InitialFiscalCode;
            OmocodeFiscalCodes.Add(temp); //Aggiunge il codice fiscale originale alla lista
            for (int i = 0; i < temp.Length; i++)
            {
                if (char.IsDigit(temp[i]))
                {
                    string toAdd =
                        temp.Substring(0, i) + CFCollections.OmocodeSubstitutionChars[temp[i]] + temp.Substring(i + 1);
                    OmocodeFiscalCodes.Add(toAdd);
                    temp = toAdd;
                }
            }
        }

        public static string InitialFiscalCode
        {
            get
            {
                return _initialFiscalCode;
            }

            set
            {
                OmocodeFiscalCodes.Add(value);
                _initialFiscalCode = value;
            }
        }
        public static List<string> OmocodeFiscalCodes { get; set; }

        private static string _initialFiscalCode;
    }
}
