using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.Models
{
    public class Report
    {
        
        public string Name { get; set; }
        
        public string TicketNumber { get; set; }
        
        public int LaborQuantity { get; set; }
       
        public string LaborDescription { get; set; }
       
        public double LaborCost { get; set; }

        public bool AmazonPurchase { get; set; }
        
        public int PurchaseQuantity { get; set; }
       
        public string PurchaseDescription { get; set; }
       
        public double PurchasePrice { get; set; }
       
        public string URL { get; set; }
        
        public double ShippingCost { get; set; }
    }
}
