using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Day6b();
        }

        static void Day6b()
        {
            var times = new List<double>();
            times.Add(48989083);           

            var distances = new List<double>();
            distances.Add(390110311121360);
            
            long totalWinsM = 1;
            for (int i = 0; i < times.Count; i++)
            {
                long nrWins = 0;
                var T = times[i];
                var dtb = distances[i];
                for (var t = 0.0; t < T; t++)
                {
                    var d = T * t - t * t;
                    if (d > dtb)
                        nrWins++;                    
                }
                totalWinsM *= nrWins;
            }
            Console.WriteLine("Total wins m " + totalWinsM);
            Console.ReadLine();
        }

        static void Day6a()
        {
            var times = new List<double>();
            times.Add(48);
            times.Add(98);
            times.Add(90);
            times.Add(83);

            var distances = new List<double>();
            distances.Add(390);
            distances.Add(1103);
            distances.Add(1112);
            distances.Add(1360);

            long totalWinsM = 1;
            for (int i = 0; i<times.Count; i++)
            {
                long nrWins = 0;
                var T = times[i];
                var dtb = distances[i];
                for (var t = 0.0; t<T; t++)
                {
                    var d = T * t - t * t;
                    if(d > dtb)
                        nrWins++;                    
                }
                totalWinsM *= nrWins;
            }
            Console.WriteLine("Total wins m " + totalWinsM);
            Console.ReadLine();
        }
    }
}
