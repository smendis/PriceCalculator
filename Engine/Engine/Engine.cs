using Engine.Store;
using Engine.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    public class Engine : IEngine
    {
        private IStore store = null;
        private IFactory factory = null;

        public Engine()
        {
            this.store = new InLocalDB();
            this.factory = new Factory(store);
        }

        public void AddCustomer(string name, List<int> rebateIdList)
        {
            Customer cust = factory.CreateCustomer(name, rebateIdList);
            store.AddCustomer(cust);
        }

        public void AddProduct(string name, double standardPrice)
        {
            Product prod = factory.CreateProduct(name, standardPrice);
            store.AddProduct(prod);
        }

        public void AddRebate(string name, string type, int productId, double discount, int quantity, DateTime startDate, DateTime endDate)
        {
            Rebate rebate = factory.CreatRebate(name, productId, quantity, startDate, endDate, discount, type);
            store.AddRebate(rebate);
        }

        public double CalculatePrice(int customerId, int productId, int quantity)
        {
            Customer customer = store.GetCustomer(customerId);
            Product product = store.GetProduct(productId);

            Order order = new Order(product, customer, quantity);
            return order.CalculatePrice();
        }

        public List<Customer> GetAllCustomers()
        {
            return store.GetAllCustomers();
        }

        public List<Product> GetAllProducts()
        {
            return store.GetAllProducts();
        }

        public List<Rebate> GetAllRebates()
        {
            return store.GetAllRebates();
        }

        public void RemoveCustomer(int id)
        {
            store.RemoveCustomer(id);
        }

        public void RemoveProduct(int id)
        {
            store.RemoveProduct(id);
        }

        public void RemoveRebate(int id)
        {
            store.RemoveRebate(id);
        }

        public void EditCustomer(int id, string name, List<int> rebateIdList)
        {
            Customer cust = factory.CreateCustomer(name, rebateIdList);
            cust.Id = id;
            store.EditCustomer(id, cust);
        }

        public void EditProduct(int id, string name, double standardPrice)
        {
            Product prod = factory.CreateProduct(name, standardPrice);
            prod.Id = id;
            store.EditProduct(id, prod);
        }

        public void EditRebate(int id, string name, string type, int productId, double discount, int quantity, DateTime startDate, DateTime endDate)
        {
            Rebate rebate = factory.CreatRebate(name, productId, quantity, startDate, endDate, discount, type);
            rebate.Id = id;
            store.EditRebate(id, rebate);
        }
    }
}
