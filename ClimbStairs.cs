using System;
using System.Collections.Generic;

namespace LeetCode {
    ///<summary> take step1 or 2 </summary> 
    public class ClimbStairs {
        public int start(int n) {
            {
                List<int> list = new List<int>() { 0, 1, 2 };
                if (n < 3) {
                    return list[n];
                }
                for (int i = 3; i <= n; i++) {
                    list.Add(list[i - 1] + list[i - 2]);
                }
                return list[n];
            }
        }
        public int faster(int n) {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++) {
                int c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}