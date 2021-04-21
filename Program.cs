using System;
using TrainningConsolePoho.Algos;

namespace TrainningConsolePoho
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationsAlgo opAlgo = new OperationsAlgo();

            // OutPut input
            opAlgo.GetResponsability();
            string outPut = opAlgo.GetResponsabilityString();
            Console.WriteLine(outPut);

            // Sum value version 1
            int[] values = new[] { 1, 2, 3, 10, 12 };

            int resultSum = opAlgo.Sum(values);
            Console.WriteLine(resultSum);

            // Max  
            int maxValue = opAlgo.Max(values);
            int maxOptimizedValue = opAlgo.Max(values);

            Console.WriteLine("Max value : " + maxValue);
            Console.WriteLine("Max optimized value : " + maxOptimizedValue);

            Console.ReadKey();
        }
    }
}
