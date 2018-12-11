using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.Models
{
    public class Quote
    {
        public int QuoteID { get; set; }
        public Customer Customer { get; set; }
        public Labor Labor { get; set; }
        public Purchase Purchase { get; set; }
    }
}
