using System;
using System.ComponentModel;

namespace EvenOddResponse {
    class Program {
        static void Main(string[] args) {

            //Console.Write("Enter an integer : ");
            //var ans = Console.ReadLine();
            //var nbr = Convert.ToInt32(ans);
            //if(nbr % 2 == 0) {
            //    Console.WriteLine($"The number {nbr} is even");
            //} else {
            //    Console.WriteLine($"The number {nbr} is odd");
            //}

            //var total = 0;
            //for(var idx = 0; idx <= 25; idx++) {
            //    total += idx;
            //}
            //Console.WriteLine($"The sum of 1 to 25 is {total}");

            int[] nbrs = { 308, 280, 876, 935, 862, 513, 758, 530, 600, 413 };
            var total = 0;
            foreach(var i in nbrs) {
                total += i;
            }
            Console.WriteLine($"The sum of 1 to 25 is {total}");
        }
    }
}
