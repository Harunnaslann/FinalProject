using FinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject.Entities.Concrete
{
    public class Cart:IEntity
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }

        public List<CartLine> CartLines { get; set; }
        public decimal Total
        {
            get
            {
                return CartLines.Sum(c => c.Product.UnitPrice * c.Quantity);
            }
        }

    }
}
