using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak.Solution;

namespace Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowProblem();
            ShowSolution();
        }

        private static void ShowSolution()
        {
            Pizza capricciosa = Solution.PizzaFactory.GetPizza("Capricciosa");
            Console.WriteLine($"Enjoying: {capricciosa}");
            Console.WriteLine();

            Pizza vegetariana = PizzaFactory.GetPizza("Vegetariana");
            Console.WriteLine($"Enjoying : {vegetariana}");
            Console.WriteLine();

            Pizza margherita = PizzaFactory.GetPizzaByReflection(typeof(Solution.Margherita).FullName);
            Console.WriteLine($"Enjoying: {margherita}");
            Console.WriteLine();

            Pizza alTonno = PizzaFactory.GetPizzaByReflection(typeof(Solution.AlTonno).FullName);
            Console.WriteLine($"Enjoying: {alTonno}");
        }

        private static void ShowProblem()
        {
            Problem.Margherita margherita = new Problem.Margherita();
            margherita.Prepare();
            margherita.Bake();
            margherita.Serve();
            margherita.Charge();
            Console.WriteLine($"Enjoying: {margherita}");
            Console.WriteLine();

            Problem.Capricciosa capricciosa = new Problem.Capricciosa();
            capricciosa.Prepare();
            capricciosa.Bake();
            capricciosa.Serve();
            capricciosa.Charge();
            Console.WriteLine($"Enjoying {capricciosa}");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
