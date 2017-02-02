using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    public abstract class Rebate
    {
        public Product Product { get; private set; }
        public double Discount { get; private set; }
        public string Name { get; set; }
        public int Id { get; set; }

        public Rebate(string name, Product product, double discount)
        {
            Name = name;
            Product = product;
            Discount = discount;
        }

        public Rebate(int id, string name, Product product, double discount):this(name, product, discount)
        {
            Id = id;
        }

        public abstract bool IsRebateApplicable(int productId, int quantity, DateTime date);
    }
}
