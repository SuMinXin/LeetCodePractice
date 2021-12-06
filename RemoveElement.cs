using System;

namespace LeetCode {
    ///<summary> 移除陣列指定項目 </summary> 
    public class RemoveElement {
        public int start(int[] nums, int val) {
            if (nums == null) {
                return 0;
            }

            int len = nums.Length;
            int flag = -1;
            for (int i = 0; i < len; i++) {
                if (nums[i] == val) {
                    if (flag == -1) {
                        flag = i;
                    }
                } else if (flag >= 0) {
                    nums[flag] = nums[i];
                    flag++;
                }
            }
            return flag < 0 ? len : flag;
        }
    }
}