using System;

namespace LeetCode {
    ///<summary> 移除陣列重複資料 </summary> 
    public class RemoveDuplicates {
        public void start(int[] nums) {
            if (nums == null || nums.Length == 0) {
                return;
            }
            int i = 0;
            for (int j = 1; j < nums.Length; j++) {
                Console.WriteLine($"current = [{j}]:{nums[j]}");
                if (nums[i] != nums[j]) {
                    i++;
                    Console.WriteLine($"nums[{i}]:{nums[i]} <- nums[{j}]:{nums[j]}");
                    nums[i] = nums[j];
                }
                Console.WriteLine($"Result : {string.Join(", ",nums)}");
            }
            Console.WriteLine($"Result : {string.Join(", ",nums)}");
        }
    }
}