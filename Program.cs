using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }
        public void Run()
        {
            Console.WriteLine("Start Run");
            Parallel.Invoke(() =>
            {
                Console.WriteLine("Start Task 1");
                for (int i = 0; i < 10; i++)
                    Thread.Sleep(200);
                Console.WriteLine("End Task 1");
            },
            () =>
            {
                Console.WriteLine("Start Task 2");
                for (int i = 0; i < 20; i++)
                    Thread.Sleep(200);
                Console.WriteLine("End Task 2");
            },
            () =>
            {
                Console.WriteLine("Start Task 3");
                for (int i = 0; i < 30; i++)
                    Thread.Sleep(200);
                Console.WriteLine("End Task 3");
            });
            Console.WriteLine("End Run");
            Console.ReadLine();
        }
    }
}
