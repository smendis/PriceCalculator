using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    class SeasonalRebate : Rebate
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public SeasonalRebate(string name, Product product, double discount, DateTime start, DateTime end)
            : base(name, product, discount)
        {
            Start = start;
            End = end;
        }

        public SeasonalRebate(int id, string name, Product product, double discount, DateTime start, DateTime end)
            : base(id, name, product, discount)
        {
            Start = start;
            End = end;
        }

        public override bool IsRebateApplicable(int productId, int quantity, DateTime date)
        {
            return (productId == Product.Id && date >= Start && date <= End);
        }
    }
}
