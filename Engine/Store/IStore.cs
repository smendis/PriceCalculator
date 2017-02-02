using Engine.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Store
{
    public interface IStore
    {
        void AddCustomer(Customer customer);
        void AddProduct(Product product);
        void AddRebate(Rebate rebate);
        Customer GetCustomer(int id);
        Product GetProduct(int id);
        Rebate GetRebate(int id);
        List<Customer> GetAllCustomers();
        List<Product> GetAllProducts();
        List<Rebate> GetAllRebates();
        void RemoveCustomer(int id);
        void RemoveProduct(int id);
        void RemoveRebate(int id);
        void EditCustomer(int id, Customer customer);
        void EditProduct(int id, Product product);
        void EditRebate(int id, Rebate rebate);
    }
}
