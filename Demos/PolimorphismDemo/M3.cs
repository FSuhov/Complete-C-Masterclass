using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismDemo
{
    class M3:BMW
    {
        public M3(int hp, string color, string model):base(hp,color, model)
        {
            this.Model = model;
        }

        //не может быть переопределен, так как в базовом классе sealed override
        //public override void Repair()
        //{
        //    base.Repair();
        //}
    }
}
