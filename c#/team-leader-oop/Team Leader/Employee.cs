using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Leader
{
    class Employee
    {
        // Fields
        private string _name;
        private int _number;


        // Constructor
        public Employee()
        {
            _name = "";
            _number = 0;
        }

        // Make property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Model property
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}
