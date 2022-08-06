using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak.Problem
{
    internal class Capricciosa
    {
        public string Ingredients { get; } = "Tomato, Cheese, Ham, Mushrooms";
        public double Price { get; set; } = 35.99;
        public void Prepare() => Console.WriteLine($"Preparing {GetType().Name}");
        public void Bake() => Console.WriteLine($"Baking {GetType().Name}");
        public void Serve() => Console.WriteLine($"Serving {GetType().Name}");
        public void Charge() => Console.WriteLine($"Charging {GetType().Name}: {Price}");

        public override string ToString() => $"{GetType().Name}: {Ingredients}";
       
    }
}
