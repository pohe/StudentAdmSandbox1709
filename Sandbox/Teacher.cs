﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Teacher
    {
        //Instance Fields
        private string _navn;
        private string _cpr;
        private string _adresse;
        private int _salery;

        //Properties
        public string Navn
        {
            set { _navn = value; }
            get { return _navn; }
        }
        public string CPR
        {
            set { _cpr = value; }
            get { return _cpr; }
        }
        public string Adresse
        {
            set { _adresse = value; }
            get { return _adresse; }
        }
        public int Salery
        {
            set { _salery = value; }
            get { return _salery; }
        }

        //Constructers
        public Teacher(string navn, string cpr, string adresse, int salery)
        {
            _adresse = navn;
            _cpr = cpr;
            _adresse = adresse;
            _salery = salery;
        }
        public Teacher()
        {
            _adresse = "Nope";
            _cpr = "Nope";
            _adresse = "Nope";
            _salery = 8008;
        }

        //Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Navn: {_navn} \nCPR: {_cpr} \nAdresse: {_adresse} \nSalery: {_salery}");
        }

    }



}
