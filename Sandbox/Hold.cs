using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Hold
    {
        //instance fields
        private string _name;
        private string _holdno;
        private string _startdate;

        private Student _s1;
        private Student _s2;
        private Student _s3;

        private Lokale _lokale;

        private Teacher _teacher; 

        //Constructor
        public Hold(string name, string holdNo, string startDate)
        {
            _name = name;
            _holdno = holdNo;
            _startdate = startDate;
        }

        // properties
        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }

        public string HoldNo
        {
            get { return _holdno; }
            set { _holdno = value; }
        }

        public string StartDate
        {
            get { return _startdate; }
            set { _startdate = value; }
        }

        public Student S1
        {
            get { return _s1; }
            set { _s1 = value; }
        }


        public Student S2
        {
            get { return _s2; }
            set { _s2 = value; }
        }

        public Student S3
        {
            get { return _s3; }
            set { _s3 = value; }
        }



        public Lokale Lokale
        {
            get { return _lokale; }
            set { _lokale = value; }
        }

        public Teacher Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }



        //Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Holdet, {_name}'s hold nummer er: {_holdno} \nHoldet starter den {_startdate} ");
        }

        public void PrintStudents()
        {
            _s1.PrintInfo();
            _s2.PrintInfo();
            _s3.PrintInfo();
        }


    }
}
