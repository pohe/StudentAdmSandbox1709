using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class School
    {
        private string _name;
        private string _adress;
        private string _phoneNumber;

        private Hold _team;
        private Teacher _teacher;

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public string Adress
        {
            set { _adress = value; }
            get { return _adress; }
        }

        public string PhoneNumber
        {
            set { _phoneNumber = value; }
            get { return _phoneNumber; }
        }

        public Hold Hold
        {
            get { return _team; }
            set { _team = value; }
        }

        public Teacher Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        public School(string name, string adress, string phoneNumber)
        {
            _name = name;
            _adress = adress;
            _phoneNumber = phoneNumber;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Skole navn:\t{_name}\nSkole adresse:\t{_adress}\nSkole tlf:\t{_phoneNumber}\nHold:\t{_team}");
        }


    }
}
