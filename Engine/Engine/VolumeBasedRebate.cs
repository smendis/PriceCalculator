using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    class VolumeBasedRebate : Rebate
    {
        public int Volume { get; private set; }

        public VolumeBasedRebate(string name, Product product, double discount, int volume)
            : base(name, product, discount)
        {
            Volume = volume;
        }

        public VolumeBasedRebate(int id, string name, Product product, double discount, int volume)
            : base(id, name, product, discount)
        {
            Volume = volume;
        }

        public override bool IsRebateApplicable(int productId, int quantity, DateTime date)
        {
            return (productId == Product.Id && quantity >= Volume);
        }
    }
}
