using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Basket :BaseEntity
    { 
        public virtual ICollection<BasketItem> BasketItems { get; set; }

        public Basket()
        {
            this.BasketItems = new List<BasketItem>();
        }

        public static implicit operator Basket(BasketItem v)
        {
            throw new NotImplementedException();
        }
    }
}

