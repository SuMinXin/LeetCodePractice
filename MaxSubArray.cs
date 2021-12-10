using System;
using System.Collections.Generic;

namespace LeetCode {
    /// <summary> 取最大和之子陣列 </summary>
    public class MaxSubArray {
        public int start(int[] nums) {
            int sum = nums[0], max = nums[0];
            int t = 0; // temp
            bool hasPositive = false;
            foreach (int n in nums) {
                t += n;
                if (t < 0) {
                    t = 0;
                } else {
                    hasPositive = true;
                    if (t > sum) {
                        sum = t;
                    }
                }
                if (n > max) {
                    max = n;
                }
            }
            return hasPositive ? sum : max;
        }

        public int sample(int[] nums) {
            int sum = nums[0], result = nums[0];
            for (int i = 1; i < nums.Length; i++) {
                Console.WriteLine($"sum + nums[i]:{sum + nums[i]}, nums[i]:{nums[i]}");
                sum = Math.Max(sum + nums[i], nums[i]);
                result = Math.Max(result, sum);
                Console.WriteLine($"sum:{sum}, result:{result}");
            }
            return result;
        }
    }
}