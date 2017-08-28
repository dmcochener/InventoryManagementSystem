using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InventoryManagementSystem.Models
{
    public class MenuItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public Double Price { get; set; }
        public virtual IList<Ingredient> IngredientList { get; set; }

        public int? QuantitySold { get; set; }

        public override bool Equals(object obj)
        {
            MenuItem menuItem = obj as MenuItem;

            return menuItem.ID == this.ID;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}