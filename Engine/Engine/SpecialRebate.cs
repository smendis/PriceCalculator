using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    class SpecialRebate : Rebate
    {
        public int Volume { get; private set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public SpecialRebate(string name, Product product, double discount, int volume, DateTime start, DateTime end)
            : base(name, product, discount)
        {
            Volume = volume;
            Start = start;
            End = end;
        }

        public SpecialRebate(int id, string name, Product product, double discount, int volume, DateTime start, DateTime end)
            : base(id, name, product, discount)
        {
            Volume = volume;
            Start = start;
            End = end;
        }

        public override bool IsRebateApplicable(int productId, int quantity, DateTime date)
        {
            return (productId == Product.Id && quantity >= Volume && date >= Start && date <= End);
        }
    }
}
