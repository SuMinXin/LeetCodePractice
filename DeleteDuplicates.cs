namespace LeetCode {
    /// <summary> 移除重複項 </summary>
    public class DeleteDuplicates {
        public ListNode start() {
            ListNode head = setStart();
            if (head == null) {
                return head;
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
            return n.next;
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