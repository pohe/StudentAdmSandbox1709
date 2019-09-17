using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    //properties
    public class Lokale
    {
        private string _no;

        public string Number
        {
            get { return _no; }

            set { _no = value; }
        }

        //constructor, signatur
        public Lokale(string no)
        {
            _no = no;
        }

        //Method
        public void PrintInfo()
        {
            Console.WriteLine($" Klassen nr:{_no}.");
        }
    }

}
