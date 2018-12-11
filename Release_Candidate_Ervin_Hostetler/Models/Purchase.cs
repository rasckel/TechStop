using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public bool AmazonPurchase { get; set; }
        public int PurcahseQuantity { get; set; }
        public string PurcahseDescription { get; set; }
        public double PurchasePrice { get; set; }
        public string URL { get; set; }
        public double ShippingCost { get; set; }
        
    }
}
