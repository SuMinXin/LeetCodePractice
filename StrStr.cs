namespace LeetCode {
    ///<summary> 尋找指定項目字串 </summary> 
    public class StrString {
        public int start(string haystack, string needle) {
            if (needle == "") {
                return 0;
            }
            if (haystack == "" || haystack.Length < needle.Length) {
                return -1;
            }
            int n = 0, h = 0;
            int count = 0;
            int limit = haystack.Length; // haystack結束字元
            do {
                if (haystack[h] == needle[n]) {
                    count++;
                    if (count == needle.Length) {
                        return h - count + 1;
                    }
                    n++;
                    h++;
                } else {
                    h = h - count + 1;
                    n = n - count;
                    count = 0;
                }
            } while (h < limit);
            return -1;
        }

        public int sample(string haystack, string needle) {
            // 排除不需判斷的情況
            if (needle == "") {
                return 0;
            }
            if (haystack == "" || haystack.Length < needle.Length) {
                return -1;
            }

            int compared = 0; // 已比對字元數
            int h = needle.Length - 1; // haystack比對位置
            int n = needle.Length - 1; // needle最後字元位置
            int limit = haystack.Length; // haystack結束字元
            // 從後往前比
            do {
                if (haystack[h] == needle[n]) {
                    if (n == 0) {
                        return h; // 比對完成，回傳haystack字元位置
                    }
                    h--; // haystack位置往前移動
                    n--; // needle位置往前移動
                    compared++; // 比對字元數 + 1
                } else {
                    h = h + compared + 1; // 比對失敗，移動到下一個比對位置: 目前位置 + 已比對字元數 + 1
                    n = n + compared; // 比對失敗，移動初始比對位置: 目前位置 + 已比對字元數
                    compared = 0; // 重新計數
                }
            } while (h < limit); // 比對到haystacK結束
            return -1;
        }
    }
}