using System;

namespace LeetCode {
    ///<summary> 尋找指定項目字串 </summary> 
    public class StrString {
        public int start(string haystack, string needle) {
            if (needle == "") {
                return 0;
            }
            int t = needle.Length, len = haystack.Length;
            int count = 0;
            for (int i = 0; i < len; i++) {
                if (count == 0 && (len - i) < t) {
                    return -1;
                } else {
                    if (haystack[i] == needle[count]) {
                        count++;
                        if (count == t) {
                            return i + 1 - t;
                        }
                    } else {
                        i = i - count;
                        count = 0;
                    }
                }
            }
            return -1;
        }
    }
}