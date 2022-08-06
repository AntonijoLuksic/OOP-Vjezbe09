using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak.Solution
{
    internal class Capricciosa : Pizza
    {
        public override string Ingredients => "Tomato, Cheese, Ham, Mushrooms";

        public override double Price { get; set; } = 35.99;
    }
}
