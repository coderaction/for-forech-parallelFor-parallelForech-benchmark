using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace LoopsBencmark
{ 
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            
            Bar();
        }
        
        
       public static void Bar()
        {
            List<int> list = new List<int>();

            int Add(int a, int b)  
            {  
                return a + b;  
            }  
  
            Console.WriteLine(Add(3,4)); 
        }
    }

    [MemoryDiagnoser]
    public class LoopsPerformance
    {
        readonly double[] array = new double[1000]; 
        readonly double[] arrayTwo = new double[1000]; 
        readonly Random rnd=new Random();

        [Benchmark]
        public void ForAddLoop()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (rnd.NextDouble()/Math.Cos(rnd.NextDouble()))*Math.Sqrt(rnd.NextDouble());
            }
        }
        
        [Benchmark]
        public void ParalelForAddLoop()
        {
            Parallel.For(0, arrayTwo.Length, i =>
                {
                    arrayTwo[i] = (rnd.NextDouble() / Math.Cos(rnd.NextDouble())) * Math.Sqrt(rnd.NextDouble());
                }
            );
        }
        
        [Benchmark]
        public void ParalelForLoop()
        {
            Parallel.For(0, array.Length, i =>
            {
                double d = array[i];
            }
            );
        }
        
        [Benchmark]
        public void ParalelForechLoop()
        {
            Parallel.ForEach(array, i =>
                {
                    double d = i;
                }
            );
        }
        
        [Benchmark]
        public void ForechLoop()
        {
            foreach (double i in array)
            {
                double d = i;
            }
        }
    }
}