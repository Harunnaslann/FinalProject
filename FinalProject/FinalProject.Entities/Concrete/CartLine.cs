using FinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Entities.Concrete
{
    public class CartLine:IEntity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
