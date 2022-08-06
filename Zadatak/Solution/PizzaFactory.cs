using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak.Solution
{
    internal static class PizzaFactory
    {
        internal static Pizza GetPizza(string name)
        {
            Pizza pizza;
            switch (name)
            {
                case "Margherita":
                    pizza=new Margherita();
                    break;
                case "Capricciosa":
                    pizza=new Capricciosa();
                    break;
                case "Vegetariana":
                    pizza=new Vegetariana();
                    break;
                default:
                    throw new Exception("No such pizza!");
                    
            }
            pizza.Prepare();
            pizza.Bake();
            pizza.Serve();
            pizza.Charge();
            return pizza;
        }

        internal static Pizza GetPizzaByReflection(string name)
        {
            Pizza pizza = GetPizzaByClassName(name);
            pizza.Prepare();
            pizza.Bake();
            pizza.Serve();
            pizza.Charge();
            return pizza;
        }

        private static Pizza GetPizzaByClassName(string name)
        {
            Type type=Type.GetType(name);
            return Activator.CreateInstance(type) as Pizza;
        }
    }
}
