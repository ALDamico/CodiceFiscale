using libCodiceFiscale.Enums;
using System.Collections.Generic;

namespace libCodiceFiscale.Models
{
    public static class CFCollections
    {
        #region Ctor
        /// <summary>
        /// Costruttore statico che inizializza il dizionario mese-char
        /// </summary>
        static CFCollections()
        {
            //Inizializzazione dizionario MonthsToChar
            MonthsToChar = new Dictionary<Months, char>
            {
                { Months.January, 'A' },
                { Months.February, 'B' },
                { Months.March, 'C' },
                { Months.April, 'D' },
                { Months.May, 'E' },
                { Months.June, 'H' },
                { Months.July, 'L' },
                { Months.August, 'M' },
                { Months.September, 'P' },
                { Months.October, 'R' },
                { Months.November, 'S' },
                { Months.December, 'T' }
            };

            //Inizializzazione dizionario EvenDigitCheck
            EvenDigitCheck = new Dictionary<char, int>
            {
                //Aggiunge tutte le cifre al dizionario con un ciclo.
                //for (int i = 0; i <= 9; i++)
                //{
                //    EvenDigitCheck.Add((char) i, i);
                //}
                { '0', 0 },
                { '1', 1 },
                { '2', 2 },
                { '3', 3 },
                { '4', 4 },
                { '5', 5 },
                { '6', 6 },
                { '7', 7 },
                { '8', 8 },
                { '9', 9 },
                { 'A', 0 },
                { 'B', 1 },
                { 'C', 2 },
                { 'D', 3 },
                { 'E', 4 },
                { 'F', 5 },
                { 'G', 6 },
                { 'H', 7 },
                { 'I', 8 },
                { 'J', 9 },
                { 'K', 10 },
                { 'L', 11 },
                { 'M', 12 },
                { 'N', 13 },
                { 'O', 14 },
                { 'P', 15 },
                { 'Q', 16 },
                { 'R', 17 },
                { 'S', 18 },
                { 'T', 19 },
                { 'U', 20 },
                { 'V', 21 },
                { 'W', 22 },
                { 'X', 23 },
                { 'Y', 24 },
                { 'Z', 25 }
            };

            //Inizializzazione del dizionario OddDigitCheck
            OddDigitCheck = new Dictionary<char, int>
            {
                { 'A', 1 },
                { '0', 1 },
                { 'B', 0 },
                { '1', 0 },
                { 'C', 5 },
                { '2', 5 },
                { 'D', 7 },
                { '3', 7 },
                { 'E', 9 },
                { '4', 9 },
                { 'F', 13 },
                { '5', 13 },
                { 'G', 15 },
                { '6', 15 },
                { 'H', 17 },
                { '7', 17 },
                { 'I', 19 },
                { '8', 19 },
                { 'J', 21 },
                { '9', 21 },
                { 'K', 2 },
                { 'L', 4 },
                { 'M', 18 },
                { 'N', 20 },
                { 'O', 11 },
                { 'P', 3 },
                { 'Q', 6 },
                { 'R', 8 },
                { 'S', 12 },
                { 'T', 14 },
                { 'U', 16 },
                { 'V', 10 },
                { 'W', 22 },
                { 'X', 25 },
                { 'Y', 24 },
                { 'Z', 23 }
            };
            //Inizializzazione del dizionario della checkdigit
            CheckDigits = new Dictionary<int, char>();
            char digit = 'A';
            for (int i = 0; i < 26; i++)
            {
                CheckDigits.Add(i, digit);
                digit++;
            }

            //Inizializzazione del dizionario di sostituzione degli omocodi
            OmocodeSubstitutionChars = new Dictionary<char, char>
            {
                { '0', 'L' },
                { '1', 'M' },
                { '2', 'N' },
                { '3', 'P' },
                { '4', 'Q' },
                { '5', 'R' },
                { '6', 'S' },
                { '7', 'T' },
                { '8', 'U' },
                { '9', 'V' }
            };
        }
        #endregion

        #region Fields
        /// <summary>
        /// Un dizionario che mette in relazione i mesi (cifre da 1 a 12) e le lettere che vanno a comporre il codice fiscale.
        /// </summary>
        public static readonly Dictionary<Months, char> MonthsToChar;

        /// <summary>
        /// Un dizionario che mette in relazione i caratteri e le cifre che compaiono nel codice fiscale all'intero usato per calcolare la cifra di controllo (cifre in posizione pari).
        /// </summary>
        public static readonly Dictionary<char, int> EvenDigitCheck;

        /// <summary>
        /// Un dizionario che mette in relazione i caratteri e le cifre che compaiono nel codice fiscale all'intero usato per calcolare la cifra di controllo (cifre in posizione dispari).
        /// </summary>
        public static readonly Dictionary<char, int> OddDigitCheck;

        /// <summary>
        /// Un dizionario che mette in relazione i possibili valori della somma di controllo e il carattere di controllo da generare.
        /// </summary>
        public static readonly Dictionary<int, char> CheckDigits;

        public static readonly Dictionary<char, char> OmocodeSubstitutionChars;
        #endregion
    }
}