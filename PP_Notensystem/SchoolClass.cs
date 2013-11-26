using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP_Notensystem
{
    public class SchoolClass
    {
        #region Members

        private String name;
        private int turnusNumber;
        private DateTime tStartDate;
        private DateTime tEndDate;

        #endregion

        public SchoolClass(String name, int turnusNumber, DateTime tStartDate, DateTime tEndDate)
        {
            this.name = name;
            this.turnusNumber = turnusNumber;
            this.tStartDate = tStartDate;
            this.tEndDate = tEndDate;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int TurnusNumber
        {
            get { return turnusNumber; }
            set { turnusNumber = value; }
        }

        public DateTime TurnusSatrtDate
        {
            get { return tStartDate; }
            set { tStartDate = value; }
        }

        public DateTime TurnusEndDate
        {
            get { return tEndDate; }
            set { tEndDate = value; }
        }
    }
}
