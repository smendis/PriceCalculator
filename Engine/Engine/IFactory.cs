using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    interface IFactory
    {
        Customer CreateCustomer(string name, List<int> rebateIdList);
        Product CreateProduct(string name, double standardPrice);
        Rebate CreatRebate(string name, int productId, int quantity, DateTime start, DateTime end, double discount, string type);
    }
}
