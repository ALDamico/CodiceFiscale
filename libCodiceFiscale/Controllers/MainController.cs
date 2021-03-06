﻿using libCodiceFiscale.Entities;
using libCodiceFiscale.Interfaces;
using libCodiceFiscale.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace libCodiceFiscale.Controllers
{
    public class MainController
    {
        #region Ctor
        public MainController()
        {
            Generator = new CFGenerator();
            Provinces = new List<string>();
            ForeignCounties = new List<string>();
            CurrentProviceMunicipalities = new List<string>();
        }
        #endregion

        #region Setters
        public void SetPersonValues(string name, string surname, DateTime dateOfBirth, char gender, IPlace placeOfBirth)
        {
            try
            {
                CurrentPerson = new Person()
                {
                    Name = name,
                    Surname = surname,
                    DateOfBirth = dateOfBirth,
                    Gender = gender,
                    PlaceOfBirth = placeOfBirth
                };
                Generator._currentPerson = CurrentPerson;
                Generator.PlaceOfBirth = placeOfBirth;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di input!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion

        #region Collection management
        public void RetrieveProvincesAsList()
        {
            try
            {
                using (var db = new LocalDataEntities())
                {
                    foreach (var prov in db.Comuni)
                    {
                        if (Provinces.Contains(prov.Provincia) == false)
                        {
                            Provinces.Add(prov.Provincia);
                        }
                    }
                }
                Provinces.Sort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore nel recupero del database!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public void RetrieveForeignCountriesAsList()
        {
            try
            {
                using (var db = new LocalDataEntities())
                {
                    foreach (var country in db.Stati)
                    {
                        if (ForeignCounties.Contains(country.Nome) == false)
                        {
                            ForeignCounties.Add(country.Nome);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore nel recupero del database!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            ForeignCounties.Sort();
        }

        public void RetrieveCurrentProvinceMunicipalities()
        {
            CurrentProviceMunicipalities.Clear();
            try
            {
                using (var db = new LocalDataEntities())
                {
                    foreach (var municipality in db.Comuni)
                    {
                        if (municipality.Provincia == CurrentProvince)
                        {
                            CurrentProviceMunicipalities.Add(municipality.Comune);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore nel recupero del database!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            CurrentProviceMunicipalities.Sort();
        }
        #endregion

        #region Properties
        public string CurrentProvince { get; set; }
        public List<string> Provinces { get; set; }
        public List<string> ForeignCounties { get; set; }
        public List<string> CurrentProviceMunicipalities { get; set; }
        public IPlace CurrentPlace { get; set; }
        public CFGenerator Generator { get; set; }
        private Person CurrentPerson { get; set; }
        #endregion
    }
}