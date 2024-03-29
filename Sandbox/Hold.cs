﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Hold
    {

        private static int counter = 0;
        private const int maxNoOfStudents= 28;

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
        public Hold(string name, string startDate)
        {
            
            counter = counter + 1;
            _name = name;
            _holdno = counter.ToString();
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
            //set { _holdno = value; }
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
            _s1?.PrintInfo();
            _s2?.PrintInfo();
            _s3?.PrintInfo();
        }

        public string CheckIfFull()
        {
            //if (_s1 != null && _s2 != null && _s3 != null)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false; 
            //}

            return (_s1 != null && _s2 != null && _s3 != null) ? "Sandt" : "Falsk"; 
        }

    }
}
