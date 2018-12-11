using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.ViewModel
{
    public class LaborViewModel
    {
        [Display(Name = "Quantity:")]
        public int Quantity { get; set; }
        [Display(Name = "Description:")]
        public string Description { get; set; }
        [Display(Name = "Labor Cost:")]
        public double LaborCost { get; set; }
    }
}
