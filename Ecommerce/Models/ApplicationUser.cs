using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
       public string Address { get; set; }

       // [ForeignKey("Cart")]
       // public int CartId { get; set; }
       // public virtual Cart Cart { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
