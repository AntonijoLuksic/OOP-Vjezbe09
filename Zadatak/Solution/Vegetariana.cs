using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak.Solution
{
    internal class Vegetariana : Pizza
    {
        public override string Ingredients => "Tomato, Cheese, Vegetables, Dreadlocks";

        public override double Price { get; set; } = 39.99;
    }
}
