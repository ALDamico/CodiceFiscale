using libCodiceFiscale.Enums;
using libCodiceFiscale.Extensions;
using libCodiceFiscale.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace libCodiceFiscale.Models
{
    public class CFGenerator
    {
        #region Ctor
        /// <summary>
        /// Costruisce l'oggetto CFGenerator.
        /// </summary>
        public CFGenerator()
        {
            _currentPerson = new Person();
        }

        /// <summary>
        /// Richiama il costruttore di default e inizializza la proprietà PlaceOfBirth cercando
        /// </summary>
        /// <param name="placeName"></param>
        public CFGenerator(string placeName) : this()
        {
            PlaceOfBirth = new ItalianMunicipality(placeName);
            if (PlaceOfBirth == null)
            {
                PlaceOfBirth = new ForeignCountry(placeName);
            }
        }

        /// <summary>
        /// Costruisce l'oggetto CFGenerator e inizializza il campo _currentPerson con il parametro.
        /// </summary>
        /// <param name="p">L'oggetto Person con cui inizializzare l'oggetto.</param>
        public CFGenerator(Person p)
        {

            _currentPerson = p;
            GenerateName();
            GenerateSurname();
            GenerateBirthdayAndGender();
            PlaceOfBirth = p.PlaceOfBirth;
            GenerateFiscalCode();
        }
        #endregion

        #region Utility Functions
        /// <summary>
        /// Prende una stringa in input e restituisce una stringa contenente le sole consonanti e una contenente le sole vocali. Gli ultimi due parametri vanno passati come out.
        /// </summary>
        /// <param name="input">Stringa di input</param>
        /// <param name="consonants">Parametro out per la stringa delle consonanti</param>
        /// <param name="vowels">Parametro out per la stringa delle vocali</param>
        private void GetConsonantAndVowelStrings(string input, out string consonants, out string vowels)
        {
            consonants = "";
            vowels = "";
            foreach (char c in input)
            {
                if (char.ToUpper(c) == 'A' ||
                    char.ToUpper(c) == 'E' ||
                    char.ToUpper(c) == 'I' ||
                    char.ToUpper(c) == 'O' ||
                    char.ToUpper(c) == 'U')
                {
                    vowels += c;
                }
                else
                {
                    consonants += c;
                }
            }
        }

        private void AppendFields()
        {
            //Costruisce la stringa
            StringBuilder output = new StringBuilder();
            output.Append(SurnameAbbreviated)
                .Append(NameAbbreviated)
                .Append(BirthdayAndGenderAbbreviated)
                .Append(_currentPerson.PlaceOfBirth.Code);
            //.Append(CheckDigit);

            //Imposta il valore finale
            FiscalCode = output.ToString();
        }
        #endregion

        #region Generator Methods
        /// <summary>
        /// Genera il codice di tre lettere del cognome della persona corrente.
        /// </summary>
        /// <exception cref="InvalidOperationException">Lancia un'eccezione InvalidOperationException se l'oggetto _currentPerson non è inizializzato.</exception>
        public void GenerateSurname()
        {
            /*
             * https://www.agenziaentrate.gov.it/wps/content/Nsilib/Nsi/Schede/Istanze/Richiesta+TS_CF/Informazioni+codificazione+pf/
             * Per i soggetti coniugati di sesso femminile si prende in considerazione soltanto il cognome da nubile.
             * Se il cognome contiene tre o più consonanti, i tre caratteri da rilevare sono, nell'ordine, la prima, la seconda e la terza consonante.
             * Se il cognome contiene due consonanti, i tre caratteri da rilevare sono, nell'ordine, la prima e la seconda consonante e la prima vocale.
             * Se il cognome contiene una consonante e due vocali, si rilevano, nell'ordine, quella consonante e quindi la prima e la seconda vocale.
             * Se il cognome contiene una consonante e una vocale, si rilevano la consonante e la vocale, nell'ordine, e si assume come terzo carattere la lettera x (ics).
             * Se il cognome e' costituito da due sole vocali, esse si rilevano, nell'ordine, e si assume come terzo carattere la lettera x (ics).
             */
            if (_currentPerson == null)
            {
                throw new InvalidOperationException("Oggetto _currentPerson non inizializzato.");
            }
            else
            {
                string stripped = _currentPerson.Surname.RemovePunctuationAndWhitespaces();
                GetConsonantAndVowelStrings(stripped, out string consonants, out string vowels);

                if (consonants.Length >= 3)
                {
                    SurnameAbbreviated = consonants.Substring(0, 3);
                }
                else if (consonants.Length == 2)
                {
                    SurnameAbbreviated = consonants + vowels[0];
                }
                else if (consonants.Length == 1)
                {
                    if (vowels.Length == 2)
                    {
                        SurnameAbbreviated = consonants + vowels;
                    }
                    else
                    {
                        SurnameAbbreviated = consonants + vowels + 'X';
                    }
                }
                else
                {
                    SurnameAbbreviated += vowels + 'X';
                }
            }
            SurnameAbbreviated = SurnameAbbreviated.ToUpper();
        }



        /// <summary>
        /// Genera il codice di tre lettere del nome della persona corrente e lo salva nella proprietà NameAbbreviated.
        /// </summary>
        /// <exception cref="InvalidOperationException"/>
        /// <seealso cref="GenerateSurname"/>
        public void GenerateName()
        {
            /*
             * I nomi doppi, multipli o comunque composti, vengono considerati come scritti per esteso in ogni loro parte e secondo un'unica ed ininterrotta successione di caratteri.
             * Se il nome contiene quattro o più consonanti, i tre caratteri da rilevare sono, nell'ordine, la prima, la terza e la quarta consonante.
             * Se il nome contiene tre consonanti, i tre caratteri da rilevare sono, nell'ordine, la prima, la seconda e la terza consonante.
             * Se il nome contiene due consonanti, i tre caratteri da rilevare sono, nell'ordine, la prima e la seconda consonante e la prima vocale.
             * Se il nome contiene una consonante e due vocali, i tre caratteri da rilevare sono, nell'ordine, quella consonante e quindi la prima e la seconda vocale.
             * Se il nome contiene una consonante e una vocale, si rilevano la consonante e la vocale, nell'ordine, e si assume come terzo carattere la lettera x (ics).
             * Se il nome e' costituito da due sole vocali, esse si rilevano nell'ordine, e si assume come terzo carattere la lettera x (ics).
             */
            if (_currentPerson == null)
            {
                throw new InvalidOperationException("Oggetto _currentPerson non inizializzato.");
            }
            else
            {
                string stripped = _currentPerson.Name.RemovePunctuationAndWhitespaces();
                GetConsonantAndVowelStrings(stripped, out string consonants, out string vowels);
                if (consonants.Length >= 4)
                {
                    NameAbbreviated = consonants[0] + consonants.Substring(2, 2);
                }
                else if (consonants.Length == 3)
                {
                    NameAbbreviated = consonants;
                }
                else if (consonants.Length == 2)
                {
                    NameAbbreviated = consonants + vowels[0];
                }
                else if (consonants.Length == 1)
                {
                    if (vowels.Length == 2)
                    {
                        NameAbbreviated = consonants + vowels;
                    }
                    else
                    {
                        NameAbbreviated = consonants + vowels + 'X';
                    }
                }
                else
                {
                    NameAbbreviated = vowels + 'X';
                }
                NameAbbreviated = NameAbbreviated.ToUpper();
            }
        }

        /// <summary>
        /// Genera la stringa corrispondente alla data di nascita e al genere della persona corrente.
        /// </summary>
        public void GenerateBirthdayAndGender()
        {
            StringBuilder output = new StringBuilder();
            output.Append(_currentPerson.DateOfBirth.YearToTwoDigits()); //Le due cifre dell'anno
            char m = CFCollections.MonthsToChar[(Months)_currentPerson.DateOfBirth.Month];
            output.Append(m);
            //            output.Append(CFCollections.MonthsToChar[(Months)_currentPerson.DateOfBirth.Month]); //Il carattere corrispondente al mese.
            int dayOfBirth = _currentPerson.DateOfBirth.Day;
            if (_currentPerson.Gender == 'F') //Se il sesso è femminile, aggiunge 40 al valore.
            {
                dayOfBirth += 40;
            }
            if (dayOfBirth < 10) //Richiesto
            {
                output.Append('0');
            }
            output.Append(dayOfBirth);
            BirthdayAndGenderAbbreviated = output.ToString();
        }

        public void GenerateFiscalCode()
        {
            FiscalCode = "";
            _currentPerson.PlaceOfBirth = PlaceOfBirth;
            GenerateSurname();
            GenerateName();
            GenerateBirthdayAndGender();
            GetPlaceOfBirth();
            AppendFields();
            CalculateCheckDigit();
            FiscalCode += CheckDigit;
        }

        public static char CalculateCheckDigit(string s)
        {
            if (s.Length != 15)
            {
                throw new Exception("Lunghezza della stringa di input non valida!");
            }
            int evenSum = 0, oddSum = 0;
            for (int i = 0; i < 14; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    evenSum += CFCollections.EvenDigitCheck[s[i]];
                }
                else
                {
                    oddSum += CFCollections.OddDigitCheck[s[i]];
                }
            }
            int digit = (evenSum + oddSum) % 26;
            return CFCollections.CheckDigits[digit];
        }
        private void CalculateCheckDigit()
        {
            int evenSum = 0, oddSum = 0;
            for (int i = 0; i < 15; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    evenSum += CFCollections.EvenDigitCheck[FiscalCode[i]];
                }
                else
                {
                    oddSum += CFCollections.OddDigitCheck[FiscalCode[i]];
                }
            }
            int digit = (evenSum + oddSum) % 26;
            CheckDigit = CFCollections.CheckDigits[digit];
        }

        public void GetPlaceOfBirth()
        {
            PlaceOfBirth = _currentPerson.PlaceOfBirth;
        }

        public List<string> GenerateOmocodes()
        {
            GenerateFiscalCode();
            OmocodeGenerator.InitialFiscalCode = FiscalCode;
            OmocodeGenerator.GenerateOmocodes();
            return OmocodeGenerator.OmocodeFiscalCodes;
        }
        #endregion

        #region Properties
        public string FiscalCode { get; private set; }
        public string BirthdayAndGenderAbbreviated { get; private set; }
        public string SurnameAbbreviated { get; private set; }
        public string NameAbbreviated { get; private set; }
        public IPlace PlaceOfBirth { get; set; }
        public char CheckDigit { get; private set; }
        public Person _currentPerson { get; set; }
        #endregion
    }
}