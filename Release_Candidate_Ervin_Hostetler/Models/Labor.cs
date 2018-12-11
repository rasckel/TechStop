using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.Models
{
    public class Labor
    {
        public int LaborId { get; set; }
        public int LaborQuantity { get; set; }
        public string LaborDescription { get; set; }
        public double LaborCost { get; set; }
    }
}
