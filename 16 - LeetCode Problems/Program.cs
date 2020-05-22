using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace _16___LeetCode_Problems
{
    class Program
    {
        //Curated List of Top 75 LeetCode Questions to Save Your Time
        static void Main(string[] args)
        {
            //int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //Console.WriteLine(MaxSubArray(arr));
            //int[] B = { 1 };
            //var ans = SearchRange(B, 1);
            //foreach (var item in ans)
            //{
            //    Console.Write(item + " ");
            //}
            //TreeNode node = new TreeNode(2147483647);
            //var ansList = FindMode(node);
            //foreach (var item in ansList)
            //{
            //    Console.Write(item + " ");
            //}
            //ListNode ll = new ListNode(1);
            //ll.next = new ListNode(2);
            //ll.next.next = new ListNode(3);
            //ll.next.next.next = new ListNode(4);
            //ll.next.next.next.next = new ListNode(5);
            //var ans = ReverseBetween(ll, 2, 4);
            //while (ans != null)
            //{
            //    Console.Write(ans.val + " ");
            //    ans = ans.next;
            //}
            //TreeNode root = new TreeNode(3);
            //root.left = new TreeNode(9);
            //root.right = new TreeNode(20);
            //root.right.left = new TreeNode(15);
            //root.right.right = new TreeNode(7);
            //var ans = AverageOfLevels(root);
            //foreach (var item in ans)
            //{
            //    Console.Write(item + " ");
            //}
            //var ans = ClosestKValues(root, 3.714286, 2);
            //foreach (var item in ans)
            //{
            //    Console.Write(item + " ");
            //}
            //var str = "loveleetcode";
            //Console.WriteLine(FirstUniqChar(str));
            //var str = "babab";
            //var ans = LongestPalindrome(str);
            //foreach (var item in ans)
            //{
            //    Console.Write(item + " ");
            //}
            //int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            //int k = 3;
            //var ans = MaxSlidingWindow(arr, k);
            //foreach (var item in ans)
            //{
            //    Console.Write(item + " ");
            //}
            //TreeNode tree = new TreeNode(1);
            //tree.left = new TreeNode(2);
            //tree.left.left = new TreeNode(4);
            //tree.left.right = new TreeNode(5);
            //tree.right = new TreeNode(3);
            //tree.right.left = new TreeNode(3);
            //tree.right.right = new TreeNode(6);
            //Preorder(tree);
            //Solution solution = new Solution();
            //Console.WriteLine(DiameterTree(tree));
            //int[,] edges = new int[5, 5];
            //edges[0, 1] = 1;
            //edges[1, 2] = 1;
            //edges[2, 3] = 1;
            //edges[3, 4] = 1;
            //Console.WriteLine(CountComponents(5, edges));
            //int[] arr = { 8, 1, 2, 2, 3 };
            //var ans = SmallerNumbersThanCurrent(arr);
            //foreach (var item in ans)
            //{
            //    Console.Write(item + " ");
            //}
            //int[] arr = { 1, 2, 2, 1, 1, 3 };
            //Console.WriteLine(UniqueOccurrences(arr));
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            node1.neighbors.Add(node2);
            node1.neighbors.Add(node4);
            node2.neighbors.Add(node1);
            node2.neighbors.Add(node3);
            node3.neighbors.Add(node2);
            node3.neighbors.Add(node4);
            node4.neighbors.Add(node1);
            node4.neighbors.Add(node3);
            var ans = CloneGraph(node1);
        }

        #region April 16
        //1. Two Sum
        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //Given nums = [2, 7, 11, 15], target = 9,
        //Because nums[0] + nums[1] = 2 + 7 = 9,
        //return [0, 1].
        //Notes: use dictionary/hashtable approach to store diff or value
        //Time: O(n), Space: O(n)
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (dictionary.ContainsKey(diff))
                {
                    return new int[] { i, dictionary[diff] };
                }
                else
                {
                    if (!dictionary.ContainsKey(nums[i]))
                    {
                        dictionary.Add(nums[i], i);
                    }
                }
            }
            return new int[] { };
        }

        //**121. Best Time to Buy and Sell Stock
        //Say you have an array for which the ith element is the price of a given stock on day i.
        //If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        //Note that you cannot sell a stock before you buy one.
        //Input: [7,1,5,3,6,4]
        //Output: 5
        //Notes:got wrong, find minPrice, then find largest difference for maxProfit
        public static int MaxProfit(int[] prices)
        {
            return 0;
        }

        //217. Contains Duplicate
        //Given an array of integers, find if the array contains any duplicates.
        //Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
        //Input: [1,2,3,1]
        //Output: true
        public static bool ContainsDuplicates(int[] nums)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    dictionary.Add(nums[i], i);
                }
            }
            return false;
        }

        //**238. Product of Array Except Self
        //Given an array nums of n integers where n > 1,  return an array 
        //output such that output[i] is equal to the product of all the elements of nums except nums[i]
        //Input:  [1,2,3,4]
        //Output: [24,12,8,6]
        //Notes:did not understand the solution
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] output = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {

            }
            return output;
        }
        #endregion
        #region April 17
        //153. Find Minimum in Rotated Sorted Array
        //Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
        //(i.e.,  [0,1,2,4,5,6,7] might become  [4,5,6,7,0,1,2]).
        //Find the minimum element. You may assume no duplicate exists in the array.
        //Input: [3,4,5,1,2] 
        //Output: 1
        //Notes: Missed edge case of 1 or 2 elements
        //Time: O(n), Space:O(1)
        public static int FindMin(int[] nums)
        {
            int i = 0;
            int j = 1;
            while (j < nums.Length)
            {
                if (nums[j] < nums[i])
                {
                    return nums[j];
                }
                else
                {
                    i++;
                    j++;
                }
            }
            return nums[0];
        }
        //33. Search in Rotated Sorted Array
        //Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
        //(i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).
        //You are given a target value to search. If found in the array return its index, otherwise return -1.
        //You may assume no duplicate exists in the array.
        //Your algorithm's runtime complexity must be in the order of O(log n).
        //Input: nums = [4,5,6,7,0,1,2], target = 0
        //Output: 4
        //Notes: Missed edge case of empty arr
        //Time:O(log n), Space: O(1)
        public static int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }
            //find rot index
            //do binary search
            int rotIndex = 0;
            int i = 0;
            int j = 1;
            while (j < nums.Length)
            {
                if (nums[j] < nums[i])
                {
                    rotIndex = j;
                    break;
                }
                i++;
                j++;
            }

            int lowStart = rotIndex;
            int lowEnd = nums.Length - 1;
            int highStart = 0;
            int highEnd = rotIndex - 1;

            int low;
            int high;
            if (target > nums[lowEnd])
            {
                //search larger arr
                low = highStart;
                high = highEnd;
            }
            else
            {
                //search smaller arr
                low = lowStart;
                high = lowEnd;
            }

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
        //**15. 3Sum
        //Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? 
        //Find all unique triplets in the array which gives the sum of zero.
        //The solution set must not contain duplicate triplets.
        //Given array nums = [-1, 0, 1, 2, -1, -4],
        //A solution set is:
        //[
        //  [-1, 0, 1],
        //  [-1, -1, 2]
        //]
        //Notes: Could not come up with the solution
        //Solution: Two Appointers Approach
        public static List<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> ansList = new List<List<int>>();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            return ansList;
        }
        #endregion
        #region April 18
        //**11. Container With Most Water
        //Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate 
        //(i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and 
        //(i, 0). Find two lines, which together with x-axis forms a container, such that the container 
        //contains the most water.
        //You may not slant the container and n is at least 2.
        //Input: [1,8,6,2,5,4,8,3,7]
        //Output: 49
        //Notes: Could not get working solution, on the right track
        //Solution: Two pointer approach.
        public static int MaxArea(int[] height)
        {
            int i = 0;
            int j = 1;
            while (i < height.Length && j < height.Length - 1)
            {
                if (height[i] < height[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    j++;
                }
            }
            int area = height[i] < height[j] ? height[i] * height[i] : height[j] * height[j];
            return area;
        }
        //206. Reverse Linked List
        //Reverse a singly linked list.
        //Input: 1->2->3->4->5->NULL
        //Output: 5->4->3->2->1->NULL
        //Notes: get curr.next, after swapping prev will be head the so return prev;
        //Time: O(n), Space: O(1)
        public static ListNode ReverseList(ListNode head)
        {
            var current = head;
            ListNode prev = null;
            while (current != null)
            {
                var temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            return prev;
        }
        //141. Linked List Cycle
        //Given a linked list, determine if it has a cycle in it.
        //To represent a cycle in the given linked list, we use an integer pos which 
        //represents the position (0-indexed) in the linked list where tail connects to. 
        //If pos is -1, then there is no cycle in the linked list.
        //Input: head = [3,2,0,-4], pos = 1
        //Output: true
        //Explanation: There is a cycle in the linked list, where tail connects to the second node.
        //Notes: missed null head edge case
        //Time:O(n), Space:O(1)
        public static bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            var slowPtr = head;
            var fastPtr = head.next;
            while (fastPtr != null && fastPtr.next != null)
            {
                if (slowPtr == fastPtr)
                {
                    return true;
                }
                else
                {
                    slowPtr = slowPtr.next;
                    fastPtr = fastPtr.next.next;
                }
            }
            return false;
        }
        // **104. Maximum Depth of Binary Tree
        //Given a binary tree, find its maximum depth.
        //The maximum depth is the number of nodes along the longest path from 
        //the root node down to the farthest leaf node.
        //Notes: got wrong, think recursion for each side of the tree
        public static int MaxDepth(TreeNode root)
        {
            int depth = 0;
            return depth;
        }
        //**371. Sum of Two Integers
        //Calculate the sum of two integers a and b, but you are not allowed to use the operator + and -
        //Input: a = 1, b = 2
        //Output: 3
        //Notes: Did not solve, need to go over bit shifting 
        public static int GetSum(int a, int b)
        {
            int sum = 0;

            return sum;
        }
        #endregion
        #region April 19
        // **151. Reverse Words in a String
        //Given an input string, reverse the string word by word.
        //Input: "the sky is blue"
        //Output: "blue is sky the"
        //Notes: Could not solve
        public static string ReverseWords(string s)
        {
            char[] stringChar = s.ToCharArray();
            List<string> words = new List<string>();
            int startWordIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (stringChar[i] == ' ')
                {
                    List<char> word = new List<char>();
                    while (startWordIndex < i)
                    {
                        word.Add(stringChar[startWordIndex]);
                        startWordIndex++;
                    }
                    words.Add(new string(word.ToArray()));
                }
            }
            int low = 0;
            int high = words.Count - 1;
            while (low <= high)
            {
                Swap(words, low, high);
                low++;
                high--;
            }

            return string.Empty;
        }
        public static void Swap(List<string> list, int a, int b)
        {
            var temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
        #endregion
        #region April 20
        // **21. Merge Two Sorted Lists
        //Merge two sorted linked lists and return it as a new list. The new list should 
        //be made by splicing together the nodes of the first two lists.
        //Input: 1->2->4, 1->3->4
        //Output: 1->1->2->3->4->4
        //Notes: Did not get right, need to review linked list insertion
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode ansList = null;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    if (ansList == null)
                    {
                        ansList = l1;
                    }
                    else
                    {
                        var temp = ansList.next;
                        ansList.next = l1;
                        l1.next = temp;
                        l1 = l1.next;
                    }
                }
                else
                {
                    if (ansList == null)
                    {
                        ansList = l2;
                    }
                    else
                    {
                        var temp = ansList.next;
                        ansList.next = l2;
                        l2.next = temp;
                        l2 = l2.next;
                    }
                }
                ansList = ansList.next;
            }
            var next = ansList.next;
            while (l1 != null)
            {
                ansList.next = l1;
                l1.next = next;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                ansList.next = l2;
                l2.next = next;
                l2 = l2.next;
            }

            return ansList;
        }

        //** 53. Maximum Subarray
        //Given an integer array nums, find the contiguous subarray (containing at least one number) 
        //which has the largest sum and return its sum.
        //Input: [-2,1,-3,4,-1,2,1,-5,4],
        //Output: 6
        //Explanation: [4,-1,2,1] has the largest sum = 6.
        //Notes: Did not get right, need to review sliding window
        public static int MaxSubArray(int[] nums)
        {
            int max = 0;
             
            return max;
        }
        #endregion
        #region April 21
        //760. Find Anagram Mappings
        //Given two lists Aand B, and B is an anagram of A. B is an anagram of A means B is made 
        //by randomizing the order of the elements in A.
        //We want to find an index mapping P, from A to B.A mapping P[i] = j means the ith element 
        //in A appears in B at index j.
        //These lists A and B may contain duplicates.If there are multiple answers, output any of them.
        //A = [12, 28, 46, 32, 50]
        //B = [50, 12, 32, 46, 28]
        public static int[] AnagramMappings(int[] A, int[] B)
        {
            int[] ans = new int[B.Length];
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < B.Length; i++)
            {
                if (!dictionary.ContainsKey(B[i]))
                {
                    dictionary.Add(B[i], i);
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (dictionary.ContainsKey(A[i]))
                {
                    ans[i] = dictionary[A[i]];
                }
            }
            return ans;
        }
        //349. Intersection of Two Arrays
        //Given two arrays, write a function to compute their intersection.
        //Input: nums1 = [1,2,2,1], nums2 = [2,2]
        //Output: [2]
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!dictionary.ContainsKey(nums1[i]))
                {
                    dictionary.Add(nums1[i], i);
                }
            }
            var hs = new HashSet<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (dictionary.ContainsKey(nums2[i]))
                {
                    hs.Add(nums2[i]);
                }
            }

            int[] ansList = new int[hs.Count];
            int k = 0;
            foreach (var item in hs)
            {
                ansList[k] = item;
                k++;
            }
            return ansList;
        }
        #endregion
        #region April 22
        //** 34. Find First and Last Position of Element in Sorted Array
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.
        //Your algorithm's runtime complexity must be in the order of O(log n).
        //If the target is not found in the array, return [-1, -1].
        //Input: nums = [5,7,7,8,8,10], target = 8
        //Output: [3,4]
        //Notes: Got wrong answer
        public static int[] SearchRange(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (target == nums[mid])
                {
                    int startIndex = mid;
                    int endIndex = mid;
                    while (startIndex > low)
                    {
                        if (nums[startIndex] != nums[mid])
                        {
                            break;
                        }
                        startIndex--;
                    }
                    while (endIndex < high -1)
                    {
                        if (nums[endIndex] != nums[mid])
                        {
                            break;
                        }
                        endIndex++;
                    }
                    return new int[] { startIndex, endIndex };
                }
                else if (target < nums[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return new int[] { -1, -1 };
        }
        #endregion
        #region April 23
        //700. Search in a Binary Search Tree
        //Given the root node of a binary search tree (BST) and a value. 
        //You need to find the node in the BST that the node's value equals the given value. 
        //Return the subtree rooted with that node. If such node doesn't exist, you should return NULL.
        //Notes: Answered correctly, iteration approach is less memory O(n)
        //Time:O(H) where H is height, Space:O(n) because recursion uses system stack
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }
            else if (val == root.val)
            {
                return root;
            }
            else if (val < root.val)
            {
                return SearchBST(root.left, val);
            }
            else
            {
                return SearchBST(root.right, val);
            }

        }
        #endregion
        #region April 24
        //** 501. Find Mode in Binary Search Tree
        //Given a binary search tree (BST) with duplicates, find all the mode(s) 
        //(the most frequently occurred element) in the given BST.
        //Notes: Took lots of submissions to get working solution, forget empty root edge case,
        //used dictionary, and did a level order traversal to get counts
        //Time:O(n), Space:O(n)
        public static int[] FindMode(TreeNode root)
        {
            if (root == null)
            {
                return new int[] { };
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            Dictionary<int, int> dictonary = new Dictionary<int, int>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var currNode = queue.Dequeue();
                    //do something here
                    if (!dictonary.ContainsKey(currNode.val))
                    {
                        dictonary.Add(currNode.val, 1);
                    }
                    else
                    {
                        dictonary[currNode.val]++;
                    }
                    if (currNode.left != null)
                    {
                        queue.Enqueue(currNode.left);
                    }
                    if (currNode.right != null)
                    {
                        queue.Enqueue(currNode.right);
                    }
                }
            }
            List<int> list = new List<int>();
            int maxMode = 0;
            foreach (var item in dictonary.Values)
            {
                maxMode = Math.Max(maxMode, item);
            }
            foreach (var item in dictonary)
            {
                if (item.Value == maxMode)
                {
                    list.Add(item.Key);
                }
            }

            int[] ansList = new int[list.Count];
            for (int i = 0; i < ansList.Length; i++)
            {
                ansList[i] = list[i];
            }

            return ansList;
        }

        // **108. Convert Sorted Array to Binary Search Tree
        //Given an array where elements are sorted in ascending order, 
        //convert it to a height balanced BST.
        //Notes: Solution in the the solution class below.
        public static void Test()
        {

        }

        //876. Middle of the Linked List
        //Given a non-empty, singly linked list with head node head, 
        //return a middle node of linked list.
        //If there are two middle nodes, return the second middle node.
        //Input: [1,2,3,4,5]
        //Output: Node 3 from this list (Serialization: [3,4,5])
        //Notes: Took too many attempts to get right
        //Time:O(n), Space:O(1)
        public static ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            var fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        //** 19. Remove Nth Node From End of List
        //Given a linked list, remove the n-th node from the end of list and return its head.
        //Given linked list: 1->2->3->4->5, and n = 2.
        //After removing the second node from the end, the linked list becomes 1->2->3->5.
        //Notes: Did not get right, but was on the right track
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var slow = head;
            var fast = head;
            ListNode prev = null;
            while (n > 0)
            {
                prev = fast;
                fast = fast.next;
                n--;
            }

            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            slow = prev;
            slow.next = fast;          
            
            return slow;
        }
        #endregion
        #region April 25
        // **92. Reverse Linked List II
        //Reverse a linked list from position m to n. Do it in one-pass.
        //Input: 1->2->3->4->5->NULL, m = 2, n = 4
        //Output: 1->4->3->2->5->NULL
        //Notes: Did not get right
        public static ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode start = null;
            var current = head;
            ListNode prev = null;
            while (current != null)
            {
                if (current.val == m)
                {
                    start = prev;
                    while (prev.val != n)
                    {
                        var temp = current.next;
                        current.next = prev;
                        prev = current;
                        current = temp;
                    }
                    ListNode end = current;
                    start.next = prev;
                    while (start.val != m)
                    {
                        start = start.next;
                    }
                    prev = start.next;
                    start.next = end;
                    return prev;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
            }
            return head;
        }

        //270. Closest Binary Search Tree Value
        //Given a non-empty binary search tree and a target value, find the value in the BST that is closest to the target.
        //Given target value is a floating point.
        //You are guaranteed to have only one unique value in the BST that is closest to the target.
        //Notes: Got answer right, used bfs search which made slow time, could have used a binary search for a O(H), O(1) solution
        //Time:O(n), Space:O(n)
        public static int ClosetValue(TreeNode root, double target)
        {
            int closestValue = root.val;
            double smallestDiff = double.MaxValue;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var currentNode = queue.Dequeue();
                    var diff = target - currentNode.val;
                    if (Math.Abs(diff) < smallestDiff)
                    {
                        smallestDiff = Math.Abs(diff);
                        closestValue = currentNode.val;
                    }
                    //do something here
                    if (currentNode.left != null)
                    {
                        queue.Enqueue(currentNode.left);
                    }
                    if (currentNode.right != null)
                    {
                        queue.Enqueue(currentNode.right);
                    }
                }
            }
            return closestValue;
        }

        //938. Range Sum of BST
        //Given the root node of a binary search tree, return the sum of values of all 
        //nodes with value between L and R (inclusive).
        //The binary search tree is guaranteed to have unique values.
        //Input: root = [10,5,15,3,7,null,18], L = 7, R = 15
        //Output: 32
        //Notes: Got right solution but slow, better approach would be DFS
        //Time: O(n), Space: O(n)
        public static int RangeSumBST(TreeNode root, int L, int R)
        {
            int sum = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var currNode = queue.Dequeue();
                    //do something
                    if (currNode.val >= L && currNode.val <= R)
                    {
                        sum += currNode.val;
                    }
                    if (currNode.left != null)
                    {
                        queue.Enqueue(currNode.left);
                    }
                    if (currNode.right != null)
                    {
                        queue.Enqueue(currNode.right);
                    }
                }
            }
            return sum;
        }

        //** 235. Lowest Common Ancestor of a Binary Search Tree
        //Given a binary search tree (BST), find the lowest common ancestor (LCA) of two given nodes in the BST.
        //Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
        //Output: 6
        //Explanation: The LCA of nodes 2 and 8 is 6.
        //Notes: Got wrong, think recursive BFS 
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode LCA = null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            Dictionary<TreeNode, int> dictionary = new Dictionary<TreeNode, int>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var currNode = queue.Dequeue();
                    if (currNode.val == p.val || currNode.val == q.val)
                    {
                        if (!dictionary.ContainsKey(currNode))
                        {
                            dictionary.Add(currNode, 1);
                        }
                        else
                        {
                            dictionary[currNode]++;
                            LCA = currNode;
                            break;
                        }
                    }

                    if (currNode.left != null)
                    {
                        if (currNode.left.val == p.val || currNode.left.val == q.val)
                        {
                            if (!dictionary.ContainsKey(currNode))
                            {
                                dictionary.Add(currNode, 1);
                            }
                            else
                            {
                                dictionary[currNode]++;
                                LCA = currNode;
                                break;
                            }
                        }
                        queue.Enqueue(currNode.left);
                    }
                    if (currNode.right != null)
                    {
                        if (currNode.right.val == p.val || currNode.right.val == q.val)
                        {
                            if (!dictionary.ContainsKey(currNode))
                            {
                                dictionary.Add(currNode, 1);
                            }
                            else
                            {
                                dictionary[currNode]++;
                                LCA = currNode;
                                break;
                            }

                        }
                        queue.Enqueue(currNode.right);
                    }
                }
            }

            return LCA;
        }
        #endregion
        #region April 26
        // **272. Closest Binary Search Tree Value II
        //Given a non-empty binary search tree and a target value, 
        //find k values in the BST that are closest to the target.
        //Notes: I believe I was close to answer
        public static IList<int> ClosestKValues(TreeNode root, double target, int k)
        {
            List<int> ansList = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            SortedSet<int> sortedSet = new SortedSet<int>();
            double smallestDiff = int.MaxValue;
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var currNode = queue.Dequeue();
                    //do something here
                    var diff = target - currNode.val;
                    //if sorted count < k
                    //check min vs current node 
                    //if (sortedSet.Count < k)
                    //{
                    //    if (true)
                    //    {

                    //    }
                    //}
                    if (Math.Abs(diff) < smallestDiff)
                    {
                        if (sortedSet.Count > k)
                        {
                            var item = sortedSet.Max;
                            sortedSet.Remove(item);
                        }
                        smallestDiff = (Math.Abs(diff));
                        sortedSet.Add(currNode.val);
                    }
                    if (currNode.left != null)
                    {
                        queue.Enqueue(currNode.left);
                    }
                    if (currNode.right != null)
                    {
                        queue.Enqueue(currNode.right);
                    }
                }
            }
            foreach (var item in sortedSet)
            {
                ansList.Add(item);
            }
            return ansList;
        }

        //** 4. Median of Two Sorted Arrays
        //There are two sorted arrays nums1 and nums2 of size m and n respectively.
        //Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
        //You may assume nums1 and nums2 cannot be both empty.
        //nums1 = [1, 3]
        //nums2 = [2]
        //The median is 2.0
        //Notes: Wrong approach was thinking Two Heap, but should be thinking binary search
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double ans = 0;
            SortedSet<int> minHeap = new SortedSet<int>();
            SortedSet<int> maxHeap = new SortedSet<int>();
            int i = 0;
            int j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                
            }
            return ans;
        }
        #endregion
        #region April 27
        //344. Reverse String
        //Write a function that reverses a string. The input string is given as an array of characters char[].
        //Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        //You may assume all the characters consist of printable ascii characters.
        //Input: ["h","e","l","l","o"]
        //Output: ["o","l","l","e","h"]
        //Time:O(n), Space:O(1)
        public static void ReverseString(char[] s)
        {
            int low = 0;
            int high = s.Length - 1;
            while (low <= high)
            {
                var temp = s[low];
                s[low] = s[high];
                s[high] = temp;
                low++;
                high--;
            }
        }

        // **541. Reverse String II
        //Given a string and an integer k, you need to reverse the first 
        //k characters for every 2k characters counting from the start of the string. 
        //If there are less than k characters left, reverse all of them. If there are less 
        //than 2k but greater than or equal to k characters, then reverse the first k 
        //characters and left the other as original.
        //Input: s = "abcdefg", k = 2
        //Output: "bacdfeg"
        //Notes: did not get right, on the right track though
        public static string ReverseStr(string s, int k)
        {
            char[] sArray = new char[s.Length];
            int j = 0;
            for (int i = 0; i < sArray.Length; i++)
            {
                if (j == k)
                {
                    while (k > 0)
                    {
                        var temp = sArray[i];
                        sArray[i] = sArray[j];
                        sArray[j] = temp;
                        k--;
                    }
                    i = j;
                }
                j++;
            }

            var ansString = new String(sArray);
            return ansString;
        }

        // **125. Valid Palindrome
        //Given a string, determine if it is a palindrome, considering only alphanumeric characters
        //and ignoring cases.
        //For the purpose of this problem, we define empty string as valid palindrome.
        //Notes: got wrong, on the right track, Two Pointers
        public static bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
            {
                return true;
            }
            char[] arr = s.ToCharArray();
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                while (!Char.IsLetter(arr[low]) && low <= high)
                {
                    low++;
                }
                while (!Char.IsLetter(arr[high]) && high >= low)
                {
                    high--;
                }
                if (char.ToLower(arr[low]) == char.ToLower(arr[high]))
                {
                    low++;
                    high--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        //387. First Unique Character in a String
        //Given a string, find the first non-repeating character in it and return it's index. 
        //If it doesn't exist, return -1.
        //s = "leetcode"
        //return 0.
        //Notes: struggled to get right answer
        //Time:O(n), Space:O(n)
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dictionary.ContainsKey(s[i]))
                {
                    dictionary.Add(s[i], 1);
                }
                else
                {
                    if (dictionary.ContainsKey(s[i]))
                    {
                        dictionary[s[i]]++;
                    }
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
        #endregion
        #region April 29
        //** 5. Longest Palindromic Substring
        //Given a string s, find the longest palindromic substring in s. 
        //You may assume that the maximum length of s is 1000.
        //Input: "babad"
        //Output: "bab"
        //Note: "aba" is also a valid answer.
        //Notes: got wrong answer, not even close
        public static string LongestPalindrome(string s)
        {
            int windowStart = 0;
            int windowEnd = 0;
            int start = 0;
            int end = 0;
            int maxLength = int.MinValue;
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dictionary.ContainsKey(s[windowEnd]))
                {
                    dictionary.Add(s[windowEnd], 1);
                }
                else
                {
                    dictionary[s[windowEnd]]++;
                    if (windowEnd - windowStart + 1 > maxLength)
                    {
                        maxLength = windowEnd - windowStart + 1;
                        start = windowStart;
                        end = windowEnd;
                    }
                    dictionary[s[windowEnd]]--;
                    if (dictionary[s[windowEnd]] == 0)
                    {
                        dictionary.Remove(s[windowEnd]);
                    }
                    windowStart++;
                }
            }

            var length = s.Length - end;
            var ans = s.Substring(start, length);

            return ans;
        }
        #endregion
        #region May 2
        //107. Binary Tree Level Order Traversal II
        //Given a binary tree, return the bottom-up level order 
        //traversal of its nodes' values. (ie, from left to right, level by level 
        //from leaf to root).
        //Notes: missed edge case of empty tree
        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }
            var ansList = new LinkedList<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int level = queue.Count;
                List<int> levelList = new List<int>();
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    levelList.Add(curr.val);
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                ansList.AddFirst(levelList);
            }
            return new List<IList<int>>(ansList);
        }

        //102. Binary Tree Level Order Traversal
        //Given a binary tree, return the level order traversal of its nodes' 
        //values. (ie, from left to right, level by level).
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }
            var ansList = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int level = queue.Count;
                List<int> levelList = new List<int>();
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    levelList.Add(curr.val);
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                ansList.Add(levelList);
            }
            return ansList;
        }

        //103. Binary Tree Zigzag Level Order Traversal
        //Given a binary tree, return the zigzag level order traversal of its nodes' values. 
        //(ie, from left to right, then right to left for the next level and alternate between).
        //Notes:got right answer, adding for loop back at end could be cleaner
        //Time:O(n), Space:O(n)
        public static IList<IList<int>> ZigZagLevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }
            var ansList = new List<LinkedList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool flip = false;
            while (queue.Count > 0)
            {
                int level = queue.Count;
                LinkedList<int> levelList = new LinkedList<int>();
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    if (flip)
                    {
                        levelList.AddFirst(curr.val);
                    }
                    else
                    {
                        levelList.AddLast(curr.val);
                    }
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                flip = flip == true ? false : true;
                ansList.Add(levelList);
            }

            IList<IList<int>> ans = new List<IList<int>>();
            foreach (var list in ansList)
            {
                List<int> levelList = new List<int>();
                foreach (var item in list)
                {
                    levelList.Add(item);
                }
                ans.Add(levelList);
            }

            return ans;
        }

        //637. Average of Levels in Binary Tree
        //Given a non-empty binary tree, return the average value of the nodes 
        //on each level in the form of an array.
        public static List<double> AverageOfLevels(TreeNode root)
        {
            if (root == null)
            {
                return new List<double>();
            }
            List<double> ansList = new List<double>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int level = queue.Count;
                double currSum = 0;
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    currSum += curr.val;
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                double average = currSum / level;
                ansList.Add(average);
            }

            return ansList;
        }

        #endregion
        #region May 3
        // **239. Sliding Window Maximum
        //Input: nums = [1,3,-1,-3,5,3,6,7], and k = 3
        //Output: [3,3,5,5,6,7]
        //Notes: Did not get right, on the right path, need to review the Sliding window
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] ansArray = new int[nums.Length - k + 1];
            int windowStart = 0;
            int windowEnd = 0;
            int currMax = 0;
            for (; windowEnd < nums.Length; windowEnd++)
            {
                currMax = Math.Max(currMax,nums[windowEnd]);
                if (windowEnd >= k - 1)
                {
                    ansArray[windowStart] = currMax;
                    windowStart++;
                }
            }
            return ansArray;
        }
        #endregion
        #region May 5
        //** 257. Binary Tree Paths
        //Given a binary tree, return all root-to-leaf paths.
        //Notes: did not get right
        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> paths = new List<string>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var currNode = stack.Pop();
                //normally display something here
                if (currNode.right != null)
                {
                    stack.Push(currNode.right);
                }
                if (currNode.left != null)
                {
                    stack.Push(currNode.left);
                }
            }
            return paths;
        }
        #endregion
        #region May 8
        // **144. Binary Tree Preorder Traversal
        //Given a binary tree, return the preorder traversal of its nodes' values.
        //Notes: on the right track, gave up too early
        public static void Preorder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.val);
            Preorder(node.left);
            Preorder(node.right);
        }
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            List<int> preorderList = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var currNode = stack.Pop();
                preorderList.Add(currNode.val);
                if (currNode.right != null)
                {
                    stack.Push(currNode.right);
                }
                if (currNode.left != null)
                {
                    stack.Push(currNode.left);
                }
            }
            return preorderList;
        }

        //515. Find Largest Value in Each Tree Row
        //Notes: simple BFS grabbing largest at each level
        //Time:O(n), Space:O(n)
        public static IList<int> LargestValues(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            List<int> list = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int level = queue.Count;
                int currLevelMax = int.MinValue;
                for (int i = 0; i < level; i++)
                {
                    var currNode = queue.Dequeue();
                    currLevelMax = Math.Max(currLevelMax, currNode.val);
                    if (currNode.left != null)
                    {
                        queue.Enqueue(currNode.left);
                    }
                    if (currNode.right != null)
                    {
                        queue.Enqueue(currNode.right);
                    }
                }
                list.Add(currLevelMax);
            }

            return list;
        }

        //1302. Deepest Leaves Sum
        //Given a binary tree, return the sum of values of its deepest leaves.
        //Notes:BFS/Level order traversal to get sum at last level
        public static int DeepestLeavesSum(TreeNode root)
        {
            if (root == null)
            {
                return -1;
            }
            int sum = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var level = queue.Count;
                int currLevelSum = 0;
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    currLevelSum += curr.val;
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                sum = currLevelSum;
            }
            return sum;
        }

        // **654. Maximum Binary Tree
        //Notes: did not get right
        public static TreeNode ConstuctMaxiumBinaryTreee(int[] nums)
        {
            int maxIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[maxIndex] < nums[i])
                {
                    maxIndex = i;
                }
            }

            TreeNode node = new TreeNode(nums[maxIndex]);
            int low = 0;
            int high = nums.Length - 1;
            int mid = low + (high - low) / 2;
            int leftStart = 0;
            int leftEnd = mid - 1;
            int rightStart = mid;
            int rightEnd = high;

            while (leftStart <= leftEnd)
            {
                if (nums[leftStart] != nums[maxIndex])
                {
                    Add(node, nums[leftStart]);
                }
            }

            while (rightStart <= rightEnd)
            {
                if (nums[rightStart] != nums[maxIndex])
                {
                    Add(node, nums[rightStart]);
                }
            }

            return node;
        }
        public static TreeNode Add(TreeNode node, int value)
        {
            if (node == null)
            {
                node = new TreeNode(value);
            }
            else
            {
                if (value < node.val)
                {
                    if (node.left != null)
                    {
                        node.left = Add(node.left, value);
                    }
                    else
                    {
                        node.left = new TreeNode(value);
                    }
                }
                else
                {
                    if (node.right != null)
                    {
                        node.right = Add(node.right, value);
                    }
                    else
                    {
                        node.right = new TreeNode(value);
                    }
                }
            }
            return node;
        }


        //** 543. Diameter of Binary Tree
        //Notes: did not get right

        //1161. Maximum Level Sum of a Binary Tree
        //Notes: Took two submissions, simple bfs traversal
        //Time:O(n), Space:O(n)
        public static int MaxLevelSum(TreeNode root)
        {
            if (root == null)
            {
                return -1;
            }
            int maxSumLevel = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<int> levelSums = new List<int>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var level = queue.Count;
                int levelSum = 0;
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    levelSum += curr.val;
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                levelSums.Add(levelSum);
            }

            int maxSeenSoFar = int.MinValue;
            for (int i = 0; i < levelSums.Count; i++)
            {
                if (levelSums[i] > maxSeenSoFar)
                {
                    maxSeenSoFar = levelSums[i];
                    maxSumLevel = i + 1;
                }
            }

            return maxSumLevel;
        }

        // **323. Number of Connected Components in an Undirected Graph
        //Notes: could not get to compile in leetcode
        public static int CountComponents(int n, int[,] edges)
        {
            int numOfComponents = 5;
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[n];
            //foreach edge trigger bfs on destination node
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (edges[i, j] == 1 && visited[j] == false)
                    {
                        
                        visited[j] = true;
                        queue.Enqueue(j);
                        while (queue.Count > 0)
                        {
                            var curr = queue.Dequeue();
                            for (int k = 0; k < n-1; k++)
                            {
                                if (edges[curr, k] == 1 && visited[k] == false)
                                {
                                    numOfComponents--;
                                    queue.Enqueue(k);
                                }
                            }
                        }
                    }
                }
            }
            return numOfComponents;
        }
        #endregion
        #region May 9
        //1365. How Many Numbers Are Smaller Than the Current Number
        //Notes: Got right answer, faster sorted array + hashtable approach
        //Time:O(n^2), Space:O(1) Brute force
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] ansList = new int[nums.Length];
            //brute force
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j] && i != j)
                    {
                        ansList[i]++;
                    }
                }
            }
            return ansList;
        }

        //1213. Intersection of Three Sorted Arrays
        //Notes: got right, probably a slightly faster solution available 
        //Time:O(n), Space:O(n)
        public static IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            List<int> ansList = new List<int>();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!dictionary.ContainsKey(arr1[i]))
                {
                    dictionary.Add(arr1[i], 1);
                }
                else
                {
                    dictionary[arr1[i]]++;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (!dictionary.ContainsKey(arr2[i]))
                {
                    dictionary.Add(arr2[i], 1);
                }
                else
                {
                    dictionary[arr2[i]]++;
                }
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                if (!dictionary.ContainsKey(arr3[i]))
                {
                    dictionary.Add(arr3[i], 1);
                }
                else
                {
                    dictionary[arr3[i]]++;
                }
            }

            foreach (var item in dictionary)
            {
                if (item.Value == 3)
                {
                    ansList.Add(item.Key);
                }
            }

            return ansList;
        }

        //961. N-Repeated Element in Size 2N Array
        //Notes: got right, used dictionary and counted items, less space solution available
        //Time:O(n), Space:O(n)
        public static int RepeatedNTimes(int[] A)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!dictionary.ContainsKey(A[i]))
                {
                    dictionary.Add(A[i], 1);
                }
                else
                {
                    dictionary[A[i]]++;
                }
            }
            int ans = 0;
            foreach (var item in dictionary)
            {
                if (item.Value > 1)
                {
                    ans = item.Key;
                }
            }
            return ans;
        }

        //1198. Find Smallest Common Element in All Rows
        //Notes: Got right, concept was right, need to review array or arrays vs 2d array
        //better approach are avaible
        //Time:O(mn), Space:O(n)
        public static int SmallestCommonElement(int[][] mat)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (!dictionary.ContainsKey(mat[i][j]))
                    {
                        dictionary.Add(mat[i][j], 1);
                    }
                    else
                    {
                        dictionary[mat[i][j]]++;
                    }
                }
            }
            int n = mat.Length;
            foreach (var item in dictionary)
            {
                if (item.Value == n)
                {
                    return item.Key;
                }
            }
            return -1;
        }

        //1207. Unique Number of Occurrences
        //Notes: got right
        //Time:O(n), Space:O(n)
        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dictionary.ContainsKey(arr[i]))
                {
                    dictionary.Add(arr[i], 1);
                }
                else
                {
                    dictionary[arr[i]]++;
                }
            }

            HashSet<int> hs = new HashSet<int>();
            foreach (var item in dictionary)
            {
                if (hs.Contains(item.Value))
                {
                    return false;
                }
                else
                {
                    hs.Add(item.Value);
                }
            }
            return true;
        }

        //1133. Largest Unique Number
        //Notes: can improve the run time
        //Time:O(n), Space:O(n)
        public static int LargestUniqueNumber(int[] A)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!dictionary.ContainsKey(A[i]))
                {
                    dictionary.Add(A[i], 1);
                }
                else
                {
                    dictionary[A[i]]++;
                }
            }

            int greatestNumber = -1;
            foreach (var item in dictionary)
            {
                if (item.Value <= 1)
                {
                    if (item.Key > greatestNumber)
                    {
                        greatestNumber = item.Key;
                    }
                }
            }

            return greatestNumber;
        }

        //136. Single Number
        //Notes: can improve run time
        //Time:O(n), Space:O(n)
        public static int SingleNumber(int[] nums)
        {
            int ans = 0;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], 1);
                }
                else
                {
                    dictionary[nums[i]]++;
                }
            }
            foreach (var item in dictionary)
            {
                if (item.Value == 1)
                {
                    ans = item.Key;
                }
            }
            return ans;
        }

        //**701. Insert into a Binary Search Tree
        //did not get right on the first try 
        //Time:O(n), Space:O(n)
        public static TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                root = new TreeNode(val);
            }
            else
            {
                if (val < root.val)
                {
                    if (root.left != null)
                    {
                        root.left = InsertIntoBST(root.left, val);
                    }
                    else
                    {
                        root.left = new TreeNode(val);
                    }
                }
                else
                {
                    if (root.right != null)
                    {
                        root.right = InsertIntoBST(root.right, val);
                    }
                    else
                    {
                        root.right = new TreeNode(val);
                    }
                }
                
            }
            return root;
        }
        #endregion
        #region May 11
        // **1043. Partition Array for Maximum Sum
        //Notes:Need to working sliding window
        public static int MaxSumAfterPartitioning(int[] A, int K)
        {
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < A.Length; windowEnd++)
            {
                if(windowEnd == K-1)
                {

                }
            }

            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }

            return sum;
        }
        #endregion
        #region May 13

        #endregion
        #region May 14
        // **15. 3Sum
        public static IList<IList<int>> ThreeSum1(int[] nums)
        {
            List<IList<int>> ansList = new List<IList<int>>();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
            //do two sums and the optimize
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = -nums[i];
                if (dictionary.ContainsKey(diff))
                {
                    //found pair of dictionary[diff] and nums[i]
                    //would normally return the diff and i
                    var diff2 = -dictionary[diff] - nums[i];
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] == diff2)
                        {
                            ansList.Add(new List<int> { nums[j], dictionary[diff], nums[i] });
                            break;
                        }
                        
                    }
                }
                else
                {
                    if (!dictionary.ContainsKey(nums[i]))
                    {
                        dictionary.Add(nums[i], i);
                    }
                }
            }
            return ansList;
        }
        #endregion
        #region May 16
        //** 133. Clone Graph
        //Notes: did not get right, think DFS/BFS traversals
        public static Node CloneGraph(Node node)
        {
            Node newNode = null;
            return newNode;
        }
        #endregion
        #region May 19
        // **22. Generate Parentheses
        //Notes: Thought it may have been a subset problem, didn't understand the answers
        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> list = new List<string>();

            return list;
        }
        #endregion
    }

    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }

    //98. Validate Binary Search Tree
    //Given a binary tree, determine if it is a valid binary search tree (BST).
    //Notes: took 3 times to get right solution, but thought process was correct, need
    //to review iteration bfs for trees
    //Time:O(n), Space:O(n)
    public class Solution
    {
        List<int> list = new List<int>();
        public bool IsValidBST(TreeNode root)
        {
            DFS(root);
            int i = 0;
            int j = 1;
            while (j < list.Count)
            {
                if (list[i] >= list[j])
                {
                    return false;
                }
                i++;
                j++;
            }
            return true;
        }

        public void DFS(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            DFS(node.left);
            list.Add(node.val);
            DFS(node.right);
        }
    }

    //** 108. Convert Sorted Array to Binary Search Tree
    //Given an array where elements are sorted in ascending order, 
    //convert it to a height balanced BST.
    //Notes: did not get right
    //public class Solution
    //{
    //    TreeNode root;
    //    public TreeNode SortedArrayToBST(int[] nums)
    //    {
    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            if (root == null)
    //            {
    //                root = new TreeNode(nums[i]);
    //            }
    //            else
    //            {
    //                root = Add(root, nums[i]);
    //            }
    //        }
    //        return root;
    //    }
    //    public TreeNode Add(TreeNode node, int value)
    //    {
    //        if (value < node.val)
    //        {
    //            if (node.left == null)
    //            {
    //                node.left = new TreeNode(value);
    //            }
    //            else
    //            {
    //                node.left = Add(node.left, value);
    //            }
    //        }
    //        else
    //        {
    //            if (node.right == null)
    //            {
    //                node.right = new TreeNode(value);
    //            }
    //            else
    //            {
    //                node.right = Add(node.right, value);
    //            }
    //        }

    //        return node;
    //    }
    //}

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }
    //public class Node
    //{
    //    public int val;
    //    public IList<Node> neighbors;

    //    public Node()
    //    {
    //        val = 0;
    //        neighbors = new List<Node>();
    //    }

    //    public Node(int _val)
    //    {
    //        val = _val;
    //        neighbors = new List<Node>();
    //    }

    //    public Node(int _val, List<Node> _neighbors)
    //    {
    //        val = _val;
    //        neighbors = _neighbors;
    //    }
    //}
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x;  }
    }
}
