﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.Models
{
    public class AmazonPurchase
    {
        public int AmazonPurchaseId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int PurchasePrice { get; set; }
        public string URL { get; set; }
        public int ShippingCost { get; set; }
    }
}
