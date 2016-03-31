using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string profession;

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
    }
}
