using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.ViewModel
{
    public class PurchaseViewModel
    {
        public bool AmazonPurchase { get; set; }
        [Display(Name = "Quantity:")]
        public int Quantity { get; set; }
        [Display(Name = "Description:")]
        public string Description { get; set; }
        [Display(Name = "Purchase Price:")]
        public double PurchasePrice { get; set; }
        [Display(Name = "URL:")]
        public string URL { get; set; }
        [Display(Name = "Shipping Cost:")]
        public double ShippingCost { get; set; }
    }
}
