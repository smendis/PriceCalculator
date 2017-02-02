using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    public interface IEngine
    {
        void AddCustomer(string name, List<int> rebateIdList);
        void AddProduct(string name, double standardPrice);
        void AddRebate(string name, string type, int productId, double discount, int quantity, DateTime startDate, DateTime endDate);
        double CalculatePrice(int customerId, int productId, int quantity);
        List<Customer> GetAllCustomers();
        List<Product> GetAllProducts();
        List<Rebate> GetAllRebates();
        void RemoveCustomer(int id);
        void RemoveProduct(int id);
        void RemoveRebate(int id);
        void EditCustomer(int id, string name, List<int> rebateIdList);
        void EditProduct(int id, string name, double standardPrice);
        void EditRebate(int id, string name, string type, int productId, double discount, int quantity, DateTime startDate, DateTime endDate);
        
    }
}
