namespace LeetCode {
    ///<summary> 計算字串相加 (二進位) </summary> 
    public class AddBinary {
        public string start(string a, string b) {
            int flag = 1;
            int aLen = a.Length, bLen = b.Length;
            string addOne = "0";
            string result = "";
            do {
                string aStr = (aLen - flag) < 0 ? "0" : a.Substring(aLen - flag, 1);
                string bStr = (bLen - flag) < 0 ? "0" : b.Substring(bLen - flag, 1);
                switch (aStr + bStr + addOne) {
                    case "000":
                        result = "0" + result;
                        break;
                    case "001":
                    case "010":
                    case "100":
                        result = "1" + result;
                        addOne = "0";
                        break;
                    case "011":
                    case "101":
                    case "110":
                        result = "0" + result;
                        addOne = "1";
                        break;
                    case "111":
                        result = "1" + result;
                        addOne = "1";
                        break;
                }
                flag++;
            } while (flag <= aLen || flag <= bLen);
            if (addOne == "1") {
                result = "1" + result;
            }
            return result;
        }
    }
}