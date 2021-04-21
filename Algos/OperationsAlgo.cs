using System;
using System.Linq;

namespace TrainningConsolePoho.Algos
{
    public class OperationsAlgo
    {
        public void GetResponsability()
        {
            Console.WriteLine("Sum algo class");
        }

        public string GetResponsabilityString()
        {
            return "Sum algo class from string function";
        }

        public int Sum(int[] values)
        {
            if (values == null || values.Length == 0)
                return 0;

            int result = 0;
            foreach (int value in values)
            {
                result += value;
            }
            return result;
        }


        public int Max(int[] values)
        {
            if (values == null || values.Length == 0)
                return 0;

            int maxValue = 0;
            foreach (int value in values)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }
            return maxValue;
        }

        public int MaxOptimized(int[] values)
        {
            if (values == null || values.Length == 0)
                return 0;

            return values.Max();
        }

        public int SumOptimized(int[] values)
        {
            if (values == null || values.Length == 0)
                return 0;

            return values.Sum();
        }
    }
}
