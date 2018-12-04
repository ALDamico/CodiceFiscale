using System;
using System.Collections.Generic;

namespace libCodiceFiscale.Models
{

    public static class OmocodeGenerator
    {
        #region Static ctor
        static OmocodeGenerator()
        {
            OmocodeFiscalCodes = new List<string>();
        }
        #endregion

        #region Methods
        public static void GenerateOmocodes()
        {
            if (string.IsNullOrEmpty(InitialFiscalCode))
            {
                throw new InvalidOperationException("Codice iniziale non specificato!");
            }

            string temp = InitialFiscalCode.Substring(0, 15);
            for (int i = 0; i < temp.Length; i++)
            {
                if (char.IsDigit(temp[i]))
                {
                    string toAdd =
                        temp.Substring(0, i) + CFCollections.OmocodeSubstitutionChars[temp[i]] + temp.Substring(i + 1);
                    toAdd += CFGenerator.CalculateCheckDigit(toAdd);
                    OmocodeFiscalCodes.Add(toAdd);
                    temp = toAdd.Substring(0, 15);
                }
            }
        }

        /// <summary>
        /// Restituisce la lista di codici fiscali omocodi.
        /// </summary>
        /// <param name="initialFiscalCode">Il codice fiscale di cui generare gli omocodi. Se non specificato, verrà usato il valore già contenuto nella proprietà InitialFiscalCodes</param>
        /// <returns></returns>
        public static List<string> RetrieveList(string initialFiscalCode = "")
        {
            if (string.IsNullOrEmpty(initialFiscalCode) == false)
            {
                InitialFiscalCode = initialFiscalCode;
            }
            GenerateOmocodes();
            return OmocodeFiscalCodes;
        }
        #endregion

        #region Properties
        public static string InitialFiscalCode
        {
            get => _initialFiscalCode;

            set
            {
                OmocodeFiscalCodes.Add(value);
                _initialFiscalCode = value;
            }
        }

        public static List<string> OmocodeFiscalCodes { get; set; }
        #endregion

        #region Fields
        private static string _initialFiscalCode;
        #endregion
    }
}
