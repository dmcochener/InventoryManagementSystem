using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public class Extra
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ExtraId { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}