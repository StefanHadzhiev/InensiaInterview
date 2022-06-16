using System;

namespace TaxSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal inputAmount = decimal.Parse(Console.ReadLine());

            Worker worker = new Worker(inputAmount);

            Console.WriteLine(worker.GrossSalary);
            Console.WriteLine(worker.NetSalary);
            Console.WriteLine(worker.Tax);

            //If we were to add new taxes to the system , we could add new methods in the worker class and use the class' properties to show them in the outside world.
        }
    }
}
