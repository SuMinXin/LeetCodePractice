using System.Collections.Generic;

namespace LeetCode {
    /// <summary> 移除重複項 </summary>
    public class DeleteDuplicates {
        public string start() {
            ListNode head = setStart();
            if (head == null) {
                return "[]";
            }
            ListNode n = new ListNode();
            ListNode t = n;
            int prev = -1;
            do {
                if (head.val != prev) {
                    prev = head.val;
                    t.next = head;
                    t = t.next;
                } else if (head.next == null) {
                    t.next = null;
                }
                head = head.next;
            }
            while (head != null);
            return print(n.next);
        }

        public string sample() {
            /* ListNode flag = head; */
            ListNode head = setStart();
            if (head == null || head.next == null) {
                return print(head);
            }
            ListNode f1 = head;
            ListNode f2 = head.next;
            do {
                if (f1.val == f2.val) {
                    f1.next = f2.next;
                    f2 = f1.next;
                } else {
                    f1 = f1.next;
                    f2 = f2.next;
                }
            } while (f2 != null);
            return print(head);
        }

        private ListNode setStart() {
            return new ListNode() {
                val = 1,
                    next = new ListNode() {
                        val = 1,
                        next = new ListNode() {
                        val = 2,
                        next = new ListNode() {
                        val = 3,
                        next = new ListNode() {
                        val = 3,
                        next = null
                        }
                        }
                        }
                        }
            };
        }

        private ListNode setStart2() {
            return new ListNode() {
                val = 1,
                    next = new ListNode() {
                        val = 1,
                        next = new ListNode() {
                        val = 2,
                        next = null
                        }
                        }
            };
        }

        private string print(ListNode nodes) {
            List<int> result = new List<int>();
            do {
                result.Add(nodes.val);
                nodes = nodes.next;
            } while (nodes != null);
            return $"[{string.Join(",", result)}]";
        }
    }
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }
}