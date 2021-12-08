namespace LeetCode {
    ///<summary> 尋找插入位置 </summary> 
    public class InsertPosition {
        public int start(int[] nums, int target) {
            int end = nums.Length;
            int i = 0;
            while (i < end) {
                if (nums[i] >= target) {
                    return i;
                }
                i++;
            }
            return end;
        }

        public int cutInHalf(int[] nums, int target) {
            if (nums == null || nums[0] >= target) {
                return 0;
            }
            int len = nums.Length;
            if (nums[len - 1] < target) {
                return len;
            }
            if (nums[len - 1] == target) {
                return len - 1;
            }

            int position = len / 2;
            int move = len / 2; // 移動幅度
            for (int i = 0; i < (len / 2) + 1; i++) {
                if (nums[position] == target) {
                    return position;
                }
                move = move / 2;
                if (move == 0) {
                    if (nums[position] < target) {
                        return position + 1;
                    } else if (nums[position - 1] == target) {
                        return position - 1;
                    }
                    return position;
                }
                if (nums[position] > target) {
                    position -= move;
                } else {
                    position += move;
                }
            }
            return position;
        }
    }
}