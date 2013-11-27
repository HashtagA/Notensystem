using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP_Notensystem
{
    public class SchoolClass
    {
        #region Members

        private String name{get;set;}
        private int turnusNumber { get; set; }
        private DateTime tStartDate { get; set; }
        private DateTime tEndDate { get; set; }
        private List<SchoolGroup> group;

        #endregion

        public SchoolClass(String name, int turnusNumber, DateTime tStartDate, DateTime tEndDate)
        {
            this.name = name;
            this.turnusNumber = turnusNumber;
            this.tStartDate = tStartDate;
            this.tEndDate = tEndDate;
        }
    }
}
