using Release_Candidate_Ervin_Hostetler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.ViewModel
{
    public class QuoteViewModel
    {
        public Customer Customer { get; set; }
        public Labor Labor { get; set; }
        public Purchase Purchase { get; set; }


    }
}
