namespace LeetCode {
    public class PlusOne {
        public int[] start(int[] digits) {
            int len = digits.Length;
            int[] one = new int[len + 1];
            bool add = false;
            for (int i = len - 1; i >= 0; i--) {
                if (digits[i] != 9) {
                    digits[i] = digits[i] + 1;
                    add = false;
                    break;
                } else {
                    digits[i] = 0;
                    add = true;
                }
                one[i] = 0;
            }
            if (add) {
                one[0] = 1;
                return one;
            }
            return digits;
        }
    }
}