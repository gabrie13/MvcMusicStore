using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }


        public DateTime OrderDate { get; set; }

        [Remote("CheckUserName", "Account")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Your first name is required")]
        [StringLength(160, ErrorMessage = "Your {0} is too long.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="Your first name is required")]
        [StringLength(160, ErrorMessage = "Your {0} is too long.")]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]@[A-Za-z0-9.-] +\.[A-Za-z]{2,4}", ErrorMessage = "Doesn't look like this email valid")]
        public string Email { get; set; }

        [ReadOnly(true)]
        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = false)]
        [Range(typeof(decimal),"0.00","49.99")]
        public decimal Total { get; set; }
    }
}