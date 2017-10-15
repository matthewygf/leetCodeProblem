using System;
using System.Collections.Generic;
using System.Linq;

namespace AddTwoNums
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode five1 = new ListNode(5);

            ListNode five = new ListNode(5);

            var results = AddTwoNumbers(five1, five);
            //Console.WriteLine(7 % 10);
            //WriteNext(results.next);

            Console.ReadLine();
        }

        private static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

            var added = 0;
            if(l1 != null){
                added += l1.val;
            }

            if(l2 != null){
                added += l2.val;
            }

            // if added  >= 10
            // we only want 0
            // and the next node should add on 1 ?
            int toAdd = 0;
            toAdd = added / 10;

            // l1 has next or l2 has next we need to hook into another add two numbers?.
            var next = new ListNode(0);
            if(l1.next != null || l2.next != null){
                if(l1.next == null){
                    l1.next = new ListNode(0);
                }
                
                if(l2.next == null){
                    l2.next = new ListNode(0);
                }

                l1.next.val += toAdd;
                next = AddTwoNumbers(l1.next, l2.next);
            }else {
                // l1 and l2 both dont have next,
                // check whether we need to create a toAdd node

                if(toAdd > 0){
                    next = new ListNode(toAdd);
                }
            }
        
            
            if(l1.next == null && l2.next == null){
                if(toAdd > 0){
                    return new ListNode(added % 10) {next = next};
                }
                return new ListNode(added % 10);
            }else {
                return new ListNode(added % 10) {next = next};
            }
        }

        public class ListNode {
            public int val;
            public ListNode next;

            public ListNode(int x) {
                this.val = x;
            }
        }
    }
}
