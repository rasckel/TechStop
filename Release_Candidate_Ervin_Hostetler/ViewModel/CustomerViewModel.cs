using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.ViewModel
{
    public class CustomerViewModel
    {
        [Required, Display(Name = "Name:")]
        public string Name { get; set; }
        [Required, Display(Name = "Ticket Number:")]
        public string TicketNumber { get; set; }
    }
}
