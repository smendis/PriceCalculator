using Engine.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Store
{
    class InMemStore : IStore
    {
        private List<Customer> customers;
        private List<Product> products;
        private List<Rebate> rebates;

        private static int customerId = 1;
        private static int productId = 1;
        private static int rebateId = 1;

        public InMemStore()
        {
            customers = new List<Customer>();
            products = new List<Product>();
            rebates = new List<Rebate>();
        }

        public void AddCustomer(Customer customer)
        {
            customer.Id = customerId++;
            customers.Add(customer);
        }

        public void AddProduct(Product product)
        {
            product.Id = productId++;
            products.Add(product);
        }

        public void AddRebate(Rebate rebate)
        {
            rebate.Id = rebateId++;
            rebates.Add(rebate);
        }

        public Customer GetCustomer(int id)
        {
            foreach (Customer cust in customers)
            {
                if (cust.Id == id)
                    return cust;
            }

            return null;
        }

        public Product GetProduct(int id)
        {
            foreach (Product prod in products)
            {
                if (prod.Id == id)
                    return prod;
            }

            return null;
        }

        public Rebate GetRebate(int id)
        {
            foreach (Rebate rebate in rebates)
            {
                if (rebate.Id == id)
                    return rebate;
            }

            return null;
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public List<Rebate> GetAllRebates()
        {
            return rebates;
        }


        public void RemoveCustomer(int id)
        {
            foreach (Product prod in products)
            {
                if (prod.Id == id)
                    products.Remove(prod);
            }
        }

        public void RemoveProduct(int id)
        {
            foreach (Rebate rebate in rebates)
            {
                if (rebate.Id == id)
                    rebates.Remove(rebate);
            }
        }

        public void RemoveRebate(int id)
        {
            foreach (Customer cust in customers)
            {
                if (cust.Id == id)
                    customers.Remove(cust);
            }
        }

        public void EditCustomer(int id, Customer customer)
        {
            RemoveCustomer(id);
            customers.Add(customer);
        }

        public void EditProduct(int id, Product product)
        {
            RemoveProduct(id);
            products.Add(product);
        }

        public void EditRebate(int id, Rebate rebate)
        {
            RemoveRebate(id);
            rebates.Add(rebate);
        }
    }
}
