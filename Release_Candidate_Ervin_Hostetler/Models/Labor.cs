using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.Models
{
    public class Labor
    {
        public int LaborId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int LaborCost { get; set; }
    }
}
