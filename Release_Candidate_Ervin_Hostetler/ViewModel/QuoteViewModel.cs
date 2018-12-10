using Release_Candidate_Ervin_Hostetler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.ViewModel
{
    public class QuoteViewModel
    {
      
        public string Name { get; set; }
        public int TicketNumber { get; set; }
        public List<Labor> Labor { get; set; }
        public List<AmazonPurchase> AmazonPurchase { get; set; }
        public List<Purchase> Purchase { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
        public double ShippingCost { get; set; }

    }
}
