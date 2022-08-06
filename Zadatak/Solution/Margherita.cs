using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak.Solution
{
    internal class Margherita : Pizza
    {
        public override string Ingredients => "Tomato, Cheese";

        public override double Price { get; set; } = 29.99;
    }
}
