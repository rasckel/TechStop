using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.ViewModel
{
    public class PurchaseViewModel
    {
        [Required, Display(Name = "Quantity:")]
        public int Quantity { get; set; }
        [Required, Display(Name = "Description:")]
        public string Description { get; set; }
        [Required, Display(Name = "Purchase Price:")]
        public double PurchasePrice { get; set; }
        [Required, Display(Name = "URL:")]
        public string URL { get; set; }
        [Required, Display(Name = "Shipping Cost:")]
        public double ShippingCost { get; set; }
    }
}
