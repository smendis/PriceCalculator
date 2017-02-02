using Engine.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    class Factory : IFactory
    {
        private IStore store = null;

        public Factory(IStore store)
        {
            this.store = store;
        }

        public Customer CreateCustomer(string name, List<int> rebateIdList)
        {
            //Generate list of applicable rebates
            List<Rebate> rebateList = new List<Rebate>();
            foreach (int id in rebateIdList)
            {
                Rebate rebate = store.GetRebate(id);
                rebateList.Add(rebate);
            }

            Customer cust = new Customer();
            cust.Name = name;
            cust.RebateAgreement = rebateList;

            return cust;
        }

        public Product CreateProduct(string name, double standardPrice)
        {
            Product prod = new Product();
            prod.Name = name;
            prod.StandardPrice = standardPrice;

            return prod;
        }

        public Rebate CreatRebate(string name, int productId, int quantity, DateTime start, DateTime end, double discount, string type)
        {
            type = type.ToUpper().Trim();
            Product product = store.GetProduct(productId);

            Rebate rebate;
            switch (type)
            {
                case "VOLUME":
                    rebate = new VolumeBasedRebate(name, product, discount, quantity);
                    break;
                case "SEASONAL":
                    rebate = new SeasonalRebate(name, product, discount, start, end);
                    break;
                case "SPECIAL":
                    rebate = new SpecialRebate(name, product, discount, quantity, start, end);
                    break;
                default:
                    rebate = null;
                    break;
            }

            return rebate;
        }
    }
}
