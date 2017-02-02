using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    static class GridUtil
    {
        public static BindingList<GridProduct> GetAllGridProducts(List<Product> input)
        {
            BindingList<GridProduct> result = new BindingList<GridProduct>();

            foreach (Product prod in input)
            {
                GridProduct item = new GridProduct
                {
                    Id = prod.Id,
                    Name = prod.Name,
                    StandardPrice = prod.StandardPrice
                };

                result.Add(item);
            }

            return result;
        }

        public static BindingList<GridCustomer> GetAllGridCustomers(List<Customer> input)
        {
            BindingList<GridCustomer> result = new BindingList<GridCustomer>();

            foreach (Customer cust in input)
            {
                GridCustomer item = new GridCustomer
                {
                    Id = cust.Id,
                    Name = cust.Name,
                    RebateAgreements = String.Join(", ", cust.RebateAgreement.Select(i=>i.Name).ToList())
                };

                result.Add(item);
            }

            return result;
        }

        public static BindingList<GridRebate> GetAllGridRebates(List<Rebate> input)
        {
            BindingList<GridRebate> result = new BindingList<GridRebate>();

            foreach (Rebate reb in input)
            {
                GridRebate item = null;
                if (reb.GetType() == typeof(VolumeBasedRebate))
                {
                    VolumeBasedRebate r = (VolumeBasedRebate)reb;
                    item = new GridRebate
                    {
                        Id = r.Id,
                        Name = r.Name,
                        RebateType = "Volume Based",
                        Product = r.Product.Name,
                        Discount = r.Discount.ToString(),
                        MinimalVolume = r.Volume.ToString(),
                        PeriodStart = "N/A",
                        PeriodEnd = "N/A"
                    };
                }
                else if (reb.GetType() == typeof(SeasonalRebate))
                {
                    SeasonalRebate r = (SeasonalRebate)reb;
                    item = new GridRebate
                    {
                        Id = r.Id,
                        Name = r.Name,
                        RebateType = "Seasonal",
                        Product = r.Product.Name,
                        Discount = r.Discount.ToString(),
                        MinimalVolume = "N/A",
                        PeriodStart = r.Start.ToString(),
                        PeriodEnd = r.End.ToString()
                    };
                }
                else
                {
                    SpecialRebate r = (SpecialRebate)reb;
                    item = new GridRebate
                    {
                        Id = r.Id,
                        Name = r.Name,
                        RebateType = "Special Offer",
                        Product = r.Product.Name,
                        Discount = r.Discount.ToString(),
                        MinimalVolume = r.Volume.ToString(),
                        PeriodStart = r.Start.ToString(),
                        PeriodEnd = r.End.ToString()
                    };
                }
                result.Add(item);
            }

            return result;
        }
    }

    public class GridProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double StandardPrice { get; set; }
    }

    public class GridCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RebateAgreements { get; set; }
    }

    public class GridRebate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Product { get; set; }
        public string Discount { get; set; }
        public string RebateType { get; set; }
        public string MinimalVolume { get; set; }
        public string PeriodStart { get; set; }
        public string PeriodEnd { get; set; }
    }
}
