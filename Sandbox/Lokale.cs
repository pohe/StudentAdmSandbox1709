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
        private int _no;
        private static int counter = 0;

        public int Number
        {
            get { return _no; }

        }

        //constructor, signatur
        public Lokale()
        {
            counter = counter + 1;
            _no = counter;
        }

        //Method
        public void PrintInfo()
        {
            Console.WriteLine($" Klassen nr:{_no}.");
        }

        
    }

}
