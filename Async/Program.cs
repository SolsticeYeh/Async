using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a = 0; a < 5; a++)
            {
                mAsync();
                Console.WriteLine("@");
                Thread.Sleep(1000);
                Console.WriteLine("@");
                Thread.Sleep(1000);
            }
        }

        public static async Task<int> mAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.Write("$");
                return 0;
            });
        }

    }
}
