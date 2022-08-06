using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak.Solution
{
    internal class AlTonno : Pizza
    {
        public override string Ingredients => "Tomato, Cheese, Tuna";

        public override double Price { get; set; } = 36.99;
    }
}
