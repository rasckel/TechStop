using Release_Candidate_Ervin_Hostetler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Release_Candidate_Ervin_Hostetler.ViewModel
{
    public class QuoteViewModel
    {
        [Required, Display(Name = "Name:")]
        public string Name { get; set; }
        [Required, Display(Name = "Ticket Number:")]
        public int TicketNumber { get; set; }
        [Display(Name = "Labor Quantity:")]
        public int LaborQuantity { get; set; }
        public string LaborDescription { get; set; }
        public double LaborCost { get; set; }
        public int PurchaseQuantity { get; set; }
        public string PurchaseDescription { get; set; }
        public double PurchasePrice { get; set; }
        public string PurchaseURL { get; set; }
        public double PurchaseShippingCost { get; set; }

        public string URL { get; set; }
        public double ShippingCost { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }


    }
}
