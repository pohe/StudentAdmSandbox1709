using System;
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
        private const int maxSalery = 30000;

        private static int counter = 0;
        private int _teacherNo;

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
        public int TeacherNo
        {
            get { return _teacherNo; }
        }
        public int MaxSalery
        {
            get { return maxSalery; }
        }

        //Constructers
        public Teacher(string navn, string cpr, string adresse, int salery)
        {
            counter++;
            _teacherNo = counter;
            _adresse = navn;
            _cpr = cpr;
            _adresse = adresse;
            if (salery > maxSalery)
            {
                Console.WriteLine("Sorry, there was an error while trying to assign salery to a teacher. \n" +
                    $"Please make sure to assign a value equel to or below {maxSalery}. \n" +
                    "Setting salery to 0 (Zero).");
                _salery = 0;
            }
            else
                _salery = salery;
        }
        public Teacher()
        {
            counter++;
            _teacherNo = counter;
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
