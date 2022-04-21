using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectVIII.Models
{
    public class CustomerData
    {
        //Billing information
        [Required,DisplayName("Name")]
        public string customerName { get; set; }
        [Required,Display(Name ="Surname")]
        public string customerSurname { get; set; }
        [Required, Display(Name ="Contact")]
        public string customerContact { get; set; }
        [Required,Display(Name ="Country")]
        public string country { get; set; }
        [Display(Name ="Physical Address")]
        [Required]
        public string physicalAddress { get; set; }
        [Required,DisplayName("Province")]
        public string province { get; set; }
        [Required,DisplayName("City")]
        public string city { get; set; }
        [Required,DisplayName("Zip code")]
        public int zipCode { get; set; }
        [DisplayName("Delivery method")]
        public string deliveryMethod { get; set; }

        //Payment information
        [DisplayName("Payment method")]
        public string paymentMethod { get; set; }
        [Required,DisplayName("Bank Name")]
        public string cardName { get; set; }
        [Required,DisplayName("Card number")]
        public int cardNumber { get; set; }
        [Required,DisplayName("Expiry date")]
        public string expiryDate { get; set; }
        [Required,DisplayName("CVV")]
        public int CVV { get; set; }
        [Required,DisplayName("Paypal email address")]
        public string paypalEmailAddress { get; set; }

        //Collection address
        public string collectionAddress { get; set; }

    }
}