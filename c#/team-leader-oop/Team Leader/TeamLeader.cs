using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Leader
{
    class TeamLeader : ProductionWorker
    {
        // Fields
        private int _requiredHours;
        private int _earnedHours;
        private decimal _bonus;


        // Constructor
        public TeamLeader()
        {
            _requiredHours = 0;
            _earnedHours = 0;
            _bonus = 0;
        }

        // shift property
        public int Required_Hours
        {
            get { return _requiredHours; }
            set { _requiredHours = value; }
        }

        // rate property
        public int Earned_Hours
        {
            get { return _earnedHours; }
            set { _earnedHours = value; }
        }

        // bonus property
        public decimal Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
    }
}
