using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class FundingRaised
    {
        public string permalink { get; set; }
        public string company_name { get; set;  }
        public string number_employees { get; set; }
        public string category { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string funded_date { get; set; }
        public string raised_amount { get; set; }
        public string raised_currency { get; set; }
        public string round { get; set; }
    }
}
