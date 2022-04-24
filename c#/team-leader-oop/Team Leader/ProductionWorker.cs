using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Leader
{
    class ProductionWorker : Employee
    {
        // Fields
        private int _shift;
        private decimal _rate;

        // Constructor
        public ProductionWorker()
        {
            _shift = 0;
            _rate = 0;
        }

        // shift property
        public int Shift
        {
            get { return _shift; }
            set { _shift = value; }
        }

        // rate property
        public decimal Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
    }
}
