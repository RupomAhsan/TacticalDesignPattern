using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Discount
    {
        private readonly string description;
        private readonly decimal relativeDiscount;

        public Discount(string description, decimal relativeDiscount)
        {
            if(relativeDiscount<=0 || relativeDiscount >= 1)
            {
                throw new ArgumentException("Invalid discount.", nameof(relativeDiscount));
            }
            this.description = description;
            this.relativeDiscount = relativeDiscount;
        }

        public decimal Apply(decimal price)
        {
            return price * (1 - this.relativeDiscount);
        }

        public override string ToString()
        {
            return string.Format("{0}% {1}", this.relativeDiscount*100,this.description);
        }
    }
}
