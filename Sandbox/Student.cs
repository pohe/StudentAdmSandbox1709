using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Student
    {

        //Instance fields 
        private string _navn;
        private string _cpr;
        private string _adresse;
        private string _telefonummer;
        private int _karakter1;
        private int _karakter2;

        private static int counter = 0;

        private int _studNo;

        public int StudNo
        {
            get { return _studNo; }
        }
        //Constructor
        public Student(string navn, string cpr, string adresse, string telefonummer)
        {
            counter = counter + 1; 
            _studNo = counter;
            _navn = navn;
            _cpr = cpr;
            _adresse = adresse;
            _telefonummer = telefonummer;
        }

        //public Student(string navn, string cpr, string adresse, string telefonummer, int studentNo)
        //{
        //    _studNo = studentNo;
        //    _navn = navn;
        //    _cpr = cpr;
        //    _adresse = adresse;
        //    _telefonummer = telefonummer;
        //}
        //Properties
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Cpr
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string Telefonummer
        {
            get { return _telefonummer; }
            set { _telefonummer = value; }
        }

        public int Karakter1
        {
            get { return _karakter1; }
            set { _karakter1 = value; }
        }

        public int Karakter2
        {
            get { return _karakter2; }
            set { _karakter2 = value; }
        }

        //Metoder

        public double Average()
        {
            double average = (_karakter1 + _karakter2) / 2.0;
            return average;
        }

        

        public void PrintInfo()
        {
            Console.WriteLine(
                $" Student navn: {_navn}\n Student CPR: {_cpr}\n Student adresse: {_adresse}\n Student telefonummer: {_telefonummer}\n Student karakter 1: {_karakter1}\n Student karakter 2: {_karakter2} \n Har gennemsnit {Average()}");
        }

    }
}
