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
            Console.WriteLine($"Result:{new InsertPosition().start(new int[] { 1,2,3,4,5,10}, 2)}");
        }
    }
}