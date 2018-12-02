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
            MonthsToChar = new Dictionary<Months, char>();
            MonthsToChar.Add(Months.January, 'A');
            MonthsToChar.Add(Months.February, 'B');
            MonthsToChar.Add(Months.March, 'C');
            MonthsToChar.Add(Months.April, 'D');
            MonthsToChar.Add(Months.May, 'E');
            MonthsToChar.Add(Months.June, 'H');
            MonthsToChar.Add(Months.July, 'L');
            MonthsToChar.Add(Months.August, 'M');
            MonthsToChar.Add(Months.September, 'P');
            MonthsToChar.Add(Months.October, 'R');
            MonthsToChar.Add(Months.November, 'S');
            MonthsToChar.Add(Months.December, 'T');

            //Inizializzazione dizionario EvenDigitCheck
            EvenDigitCheck = new Dictionary<char, int>();
            //Aggiunge tutte le cifre al dizionario con un ciclo.
            //for (int i = 0; i <= 9; i++)
            //{
            //    EvenDigitCheck.Add((char) i, i);
            //}
            EvenDigitCheck.Add('0', 0);
            EvenDigitCheck.Add('1', 1);
            EvenDigitCheck.Add('2', 2);
            EvenDigitCheck.Add('3', 3);
            EvenDigitCheck.Add('4', 4);
            EvenDigitCheck.Add('5', 5);
            EvenDigitCheck.Add('6', 6);
            EvenDigitCheck.Add('7', 7);
            EvenDigitCheck.Add('8', 8);
            EvenDigitCheck.Add('9', 9);
            EvenDigitCheck.Add('A', 0);
            EvenDigitCheck.Add('B', 1);
            EvenDigitCheck.Add('C', 2);
            EvenDigitCheck.Add('D', 3);
            EvenDigitCheck.Add('E', 4);
            EvenDigitCheck.Add('F', 5);
            EvenDigitCheck.Add('G', 6);
            EvenDigitCheck.Add('H', 7);
            EvenDigitCheck.Add('I', 8);
            EvenDigitCheck.Add('J', 9);
            EvenDigitCheck.Add('K', 10);
            EvenDigitCheck.Add('L', 11);
            EvenDigitCheck.Add('M', 12);
            EvenDigitCheck.Add('N', 13);
            EvenDigitCheck.Add('O', 14);
            EvenDigitCheck.Add('P', 15);
            EvenDigitCheck.Add('Q', 16);
            EvenDigitCheck.Add('R', 17);
            EvenDigitCheck.Add('S', 18);
            EvenDigitCheck.Add('T', 19);
            EvenDigitCheck.Add('U', 20);
            EvenDigitCheck.Add('V', 21);
            EvenDigitCheck.Add('W', 22);
            EvenDigitCheck.Add('X', 23);
            EvenDigitCheck.Add('Y', 24);
            EvenDigitCheck.Add('Z', 25);

            //Inizializzazione del dizionario OddDigitCheck
            OddDigitCheck = new Dictionary<char, int>();
            OddDigitCheck.Add('A', 1);
            OddDigitCheck.Add('0', 1);
            OddDigitCheck.Add('B', 0);
            OddDigitCheck.Add('1', 0);
            OddDigitCheck.Add('C', 5);
            OddDigitCheck.Add('2', 5);
            OddDigitCheck.Add('D', 7);
            OddDigitCheck.Add('3', 7);
            OddDigitCheck.Add('E', 9);
            OddDigitCheck.Add('4', 9);
            OddDigitCheck.Add('F', 13);
            OddDigitCheck.Add('5', 13);
            OddDigitCheck.Add('G', 15);
            OddDigitCheck.Add('6', 15);
            OddDigitCheck.Add('H', 17);
            OddDigitCheck.Add('7', 17);
            OddDigitCheck.Add('I', 19);
            OddDigitCheck.Add('8', 19);
            OddDigitCheck.Add('J', 21);
            OddDigitCheck.Add('9', 21);
            OddDigitCheck.Add('K', 2);
            OddDigitCheck.Add('L', 4);
            OddDigitCheck.Add('M', 18);
            OddDigitCheck.Add('N', 20);
            OddDigitCheck.Add('O', 11);
            OddDigitCheck.Add('P', 3);
            OddDigitCheck.Add('Q', 6);
            OddDigitCheck.Add('R', 8);
            OddDigitCheck.Add('S', 12);
            OddDigitCheck.Add('T', 14);
            OddDigitCheck.Add('U', 16);
            OddDigitCheck.Add('V', 10);
            OddDigitCheck.Add('W', 22);
            OddDigitCheck.Add('X', 25);
            OddDigitCheck.Add('Y', 24);
            OddDigitCheck.Add('Z', 23);
            //Inizializzazione del dizionario della checkdigit
            CheckDigits = new Dictionary<int, char>();
            char digit = 'A';
            for (int i = 0; i < 26; i++)
            {
                CheckDigits.Add(i, digit);
                digit++;
            }

            //Inizializzazione del dizionario di sostituzione degli omocodi
            OmocodeSubstitutionChars = new Dictionary<char, char>();
            OmocodeSubstitutionChars.Add('0', 'L');
            OmocodeSubstitutionChars.Add('1', 'M');
            OmocodeSubstitutionChars.Add('2', 'N');
            OmocodeSubstitutionChars.Add('3', 'P');
            OmocodeSubstitutionChars.Add('4', 'Q');
            OmocodeSubstitutionChars.Add('5', 'R');
            OmocodeSubstitutionChars.Add('6', 'S');
            OmocodeSubstitutionChars.Add('7', 'T');
            OmocodeSubstitutionChars.Add('8', 'U');
            OmocodeSubstitutionChars.Add('9', 'V');
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