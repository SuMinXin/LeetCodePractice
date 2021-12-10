using System;
using System.Diagnostics;

namespace LeetCode {
    class Program {
        static void Main(string[] args) {
            //new SumPair().start();
            //new RemoveDuplicates().start(new int[] { 1, 2, 3, 3, 3, 4, 5, 6, 6, 6 });
            //new RemoveElement().start(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
            //new RemoveElement().start(new int[] { 2 }, 3);
            // Stopwatch t = new Stopwatch();
            // StrString model = new StrString();
            // model.start("mississippi", "pi");
            // model.sample("hello", "ll");
            // Console.WriteLine($"back:{t.ElapsedMilliseconds}/ms");
            // Console.WriteLine($"Result:{new InsertPosition().start(new int[] { 1,2,3,4,5,10}, 2)}");
            // Console.WriteLine($"start Result:{ new MaxSubArray().start(new int[] {1,-2,-2,-1,5,-1,-2,6})}");
            // Console.WriteLine($"sample Result:{ new MaxSubArray().sample(new int[] {1,-2,-2,-1,5,-1,-2,6})}");
            Console.WriteLine($"sample Result:{ new AddBinary().start("1010", "1011")}");
        }
    }
}