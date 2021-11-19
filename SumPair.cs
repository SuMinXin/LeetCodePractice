using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LeetCode {
    ///<summary> 計算不重複陣列之指定和組合 </summary> 
    public class SumPair {
        public void start() {
            List<int> arr = setRandom();
            int target = 33;
            Console.WriteLine($"target: {target},{Environment.NewLine}array: {string.Join(", ",arr)}");
            arr.RemoveAll(o => o > target);
            int middle = (arr.Count / 2);
            if (arr.Count % 2 > 0) {
                middle++;
            }
            List<int> arr2 = new List<int>();
            arr2.AddRange(arr);
            List<int> arr3 = new List<int>();
            arr3.AddRange(arr);

            Stopwatch t = new Stopwatch();

            t.Restart();
            arr = arr.OrderBy(o => o).ToList();
            List<int> group1 = arr.Take(middle).ToList(); // 小的一半
            List<int> group2 = arr.Skip(middle).ToList(); // 大的一半
            int counter = group2.Count - 1;
            foreach (int min in group1) {
                for (int i = counter; i >= 0; i--) {
                    int sum = min + group2[i];
                    if (sum == target) {
                        Console.WriteLine($"Group: {min} + {group2[i]}");
                        break;
                    } else if (sum < target) {
                        break;
                    }
                }
            }
            if (group1[middle - 2] + group1[middle - 1] == target) {
                Console.WriteLine($"Group: {group1[middle - 2]} + {group1[middle-1]}");
            }
            t.Stop();
            Console.WriteLine($"===== Function 1: {t.ElapsedMilliseconds}/ms =====");

            Console.WriteLine($"{Environment.NewLine}");
            t.Restart();
            int idx = 0;
            do {
                int num = arr2[idx];
                for (int j = idx + 1; j < arr2.Count; j++) {
                    if (num + arr2[j] == target) {
                        Console.WriteLine($"Group: {num} + {arr2[j]}");
                        arr2.RemoveAt(j);
                        break;
                    }
                }
                idx++;
            } while (idx < arr2.Count());
            t.Stop();
            Console.WriteLine($"===== Function 2: {t.ElapsedMilliseconds}/ms =====");

            /* 會有重複問題
            t.Restart();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr3.Count; i++) {
                dic.Add(arr3[i], target - arr3[i]);
            }
            foreach (KeyValuePair<int, int> item in dic) {
                if (dic.ContainsKey(item.Value)) {
                    Console.WriteLine($"Group: {item.Key} + {item.Value}");
                }
            }
            t.Stop();
            Console.WriteLine($"===== Function 3: {t.ElapsedMilliseconds}/ms =====");
            */
        }

        private static List<int> setRandom() {
            Random rnd = new Random();
            List<int> list = new List<int>();
            do {
                int number = rnd.Next(1, 99);
                int dup = list.IndexOf(number);
                if (dup < 0) {
                    list.Add(number);
                }
            } while (list.Count < 80);
            return list;
        }
    }
}