using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.ViewModel
{
    public class LaborViewModel
    {
        [Display(Name = "Labor Quantity:")]
        public int LaborQuantity { get; set; }
        [Display(Name = "Labor Description:")]
        public string LaborDescription { get; set; }
        [Display(Name = "Labor Cost:")]
        public double LaborCost { get; set; }
    }
}
