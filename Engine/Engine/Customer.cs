using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Rebate> RebateAgreement { get; set; }
    }
}
