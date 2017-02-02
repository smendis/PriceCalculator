using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    class Order
    {
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }

        public Order(Product product, Customer customer, int quantity)
        {
            Product = product;
            Customer = customer;
            Quantity = quantity;
            Price = product.StandardPrice;
            Date = DateTime.Now;
        }

        public double CalculatePrice()
        {
            List<Rebate> rebates = Customer.RebateAgreement;

            Rebate rebate = SelectRebate(rebates, Product.Id, Quantity, Date);
            if (rebate != null)
            {
                Price *= (100 - rebate.Discount)/100;
            }
            return Price;
        }

        private Rebate SelectRebate(List<Rebate> rebates, int productId, int quantity, DateTime date)
        {
            Rebate rebate = null;

            foreach (Rebate r in rebates)
            {
                if (r.IsRebateApplicable(productId, quantity, date))
                {
                    rebate = (rebate == null || r.Discount >= rebate.Discount) ? r : rebate;
                }
            }

            return rebate;
        }
    }
}
