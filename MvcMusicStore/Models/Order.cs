using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }


        public DateTime OrderDate { get; set; }


        public string Username { get; set; }

        [Required(ErrorMessage = "Your {0} is too long.")]
        [StringLength(160, MinimumLength=4)]
        public string FirstName { get; set; }

        [Required(ErrorMessage="Your {0} is too long.")]
        [StringLength(160, MinimumLength = 4)]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]@[A-Za-z0-9.-] +\.[A-Za-z]{2,4}", ErrorMessage = "Doesn't look like this email valid")]
        public string Email { get; set; }

        [Range(typeof(decimal),"0.00","49.99")]
        public decimal Total { get; set; }
    }
}