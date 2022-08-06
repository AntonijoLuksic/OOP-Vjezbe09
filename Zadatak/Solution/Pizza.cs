using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak.Solution
{
    abstract class Pizza
    {
        public abstract string Ingredients { get;  }
        public abstract double Price { get; set; }

        public void Prepare() => Console.WriteLine($"Preparing {GetType().Name}");
        public void Bake() => Console.WriteLine($"Baking {GetType().Name}");
        public void Serve() => Console.WriteLine($"Serving {GetType().Name}");
        public void Charge() => Console.WriteLine($"Charging {GetType().Name}: {Price}");

        public override string ToString() => $"{GetType().Name}: {Ingredients}";
    }
}
