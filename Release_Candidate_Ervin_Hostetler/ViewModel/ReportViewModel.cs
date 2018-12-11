﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.ViewModel
{
    public class ReportViewModel
    {
        [Required, Display(Name = "Name:")]
        public string Name { get; set; }
        [Required, Display(Name = "Ticket Number:")]
        public string TicketNumber { get; set; }
        [Display(Name = "Quantity:")]
        public int LaborQuantity { get; set; }
        [Display(Name = "Description:")]
        public string LaborDescription { get; set; }
        [Display(Name = "Labor Cost:")]
        public double LaborCost { get; set; }

        public bool AmazonPurchase { get; set; }
        [Display(Name = "Quantity:")]
        public int PurchaseQuantity { get; set; }
        [Display(Name = "Description:")]
        public string PurchaseDescription { get; set; }
        [Display(Name = "Purchase Price:")]
        public double PurchasePrice { get; set; }
        [Display(Name = "URL:")]
        public string URL { get; set; }
        [Display(Name = "Shipping Cost:")]
        public double ShippingCost { get; set; }
    }
}
