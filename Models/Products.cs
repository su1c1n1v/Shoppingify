using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shoppingify.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        public String Description { get; set; }
        
        public String ImagePath { get; set; }

        public int? IdCategory { get; set; }

        [Required]
        [ForeignKey("IdCategory")]
        public virtual Categories Category { get; set; }

        public String IdUser { get; set; }

        [Required]
        [ForeignKey("IdUser")]
        public virtual IdentityUser User { get; set; }
    }
}
