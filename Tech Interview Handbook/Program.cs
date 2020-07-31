using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace Tech_Interview_Handbook
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] intervals = new int[2][];
            intervals[0] = new int[] { 7, 10 };
            intervals[1] = new int[] { 2, 4 };
            int[][] intervals = intervals.OrderBy(i => i[0]).ToArray();
            Console.WriteLine(CanAttendMeetings(intervals));
        }

        //1. Two Sum
        //Time:O(n) Space:O(n)
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (dictionary.ContainsKey(diff))
                {
                    return new int[] { dictionary[diff], i };
                }
                else
                {
                    if (!dictionary.ContainsKey(nums[i]))
                    {
                        dictionary.Add(nums[i], i);
                    }
                }
            }
            return new int[] { -1, -1 };
        }

        //217. Contains Duplicate
        //Input: [1,2,3,1]
        //Output: true
        //Time:O(n) Space:O(n)
        //Notes: also could have used a Hashtable
        public static bool ContainsDuplicate(int[] nums)
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
                    dictionary.Add(nums[i], 1);
                }
            }
            return false;
        }

        //121. Best Time to Buy and Sell Stock
        //Input: [7,1,5,3,6,4]
        //Output: 5
        //Time:O(n) Space:O(1)
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }
            int maxProfit = 0;
            int minPrice = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                var diff = prices[i] - minPrice;
                maxProfit = Math.Max(maxProfit, diff);
                minPrice = Math.Min(minPrice, prices[i]);
            }
            return maxProfit;
        }

        //242. Valid Anagram
        //Input: s = "rat", t = "car"
        //Output: false
        //Notes: got right but forgot string length edge case, also better approach letter array will yield O(1) space
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dictionary.ContainsKey(s[i]))
                {
                    dictionary.Add(s[i], 1);
                }
                else
                {
                    dictionary[s[i]]++;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dictionary.ContainsKey(t[i]))
                {
                    dictionary[t[i]]--;
                    if (dictionary[t[i]] == 0)
                    {
                        dictionary.Remove(t[i]);
                    }
                }
            }

            return dictionary.Count == 0;
        }
        //Time:O(n) Space:O(1)
        public static bool IsAnagram2(string s, string t)
        {
            int[] table = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                table[s[i] - 'a']++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                table[t[i] - 'a']--;
                if (table[t[i] - 'a'] < 0)
                {
                    return false;
                }
            }
            return true;
        }

        //20. Valid Parentheses
        //Input: "()"
        //Output: true
        //Notes: did not get right but knew to use a stack
        //Time: O(n) Space: O(n)
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Peek() == '(' && s[i] == ')')
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '[' && s[i] == ']')
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '{' && s[i] == '}')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        //238. Product of Array Except Self
        //Notes: was not able to come up with answer, think two passes 
        public static int[] ProductExceptSelf(int[] nums)
        {
            return new int[] { };
        }

        //53. Maximum Subarray
        //Notes: did not get right, was thinking tradional sliding window pattern but, greedy or dp approach is a correct
        public static int MaxSubArray(int[] nums)
        {
            return -1;
        }

        //15. 3Sum
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Dictionary<int, int> dictionary1 = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = 0 - nums[i];
                if (dictionary1.ContainsKey(diff))
                {
                    //look for par match
                }
                else
                {
                    if (!dictionary1.ContainsKey(nums[i]))
                    {
                        dictionary1.Add(nums[i], i);
                    }
                }
            }
            return new List<IList<int>>();
        }

        //56. Merge Interval
        //Input: [[1,4],[4,5]]
        //Output: [[1,5]]
        public static int[][] Merge(int[][] intervals)
        {
            List<int[]> ans = new List<int[]>();
            intervals.OrderBy(i => i[0]);
            var start = intervals[0][0];
            var end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                var currStart = intervals[i][0];
                var currEnd = intervals[i][1];
                if (currStart <= end)
                {
                    end = Math.Max(currEnd, end);
                }
                else
                {
                    ans.Add(new int[] { start, end });
                    start = currStart;
                    end = currEnd;
                }
            }
            ans.Add(new int[] { start, end });
            int[][] arrays = ans.Select(a => a.ToArray()).ToArray();
            return arrays;
        }

        //49. Group Anagrams
        //Notes: did not get right but was trying to implement the right approach
        public static List<List<string>> GroupAnagrams(string[] strs)
        {
            List<List<string>> ansList = new List<List<string>>();
            Dictionary<int, Dictionary<char, int>> keyValuePairs = new Dictionary<int, Dictionary<char, int>>();
            for (int i = 0; i < strs.Length; i++)
            {
                Dictionary<char, int> letterKeyValuePair = new Dictionary<char, int>();
                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (!letterKeyValuePair.ContainsKey(strs[i][j]))
                    {
                        letterKeyValuePair.Add(strs[i][j], 1);
                    }
                    else
                    {
                        letterKeyValuePair[strs[i][j]]++;
                    }
                }
                keyValuePairs.Add(i, letterKeyValuePair);
            }



            return ansList;
        }

        //Reverse Linked List
        public static ListNode Reverse(ListNode head)
        {
            var curr = head;
            ListNode prev = null;
            while (curr != null)
            {
                var next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }

        //Detect Cycle in Linked List
        public static bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }

        //Container with most water
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            int low = 0;
            int high = height.Length - 1;
            while (low < high)
            {
                var currLowValue = Math.Min(height[low], height[high]);
                maxArea = Math.Max(maxArea, currLowValue * (high - low));
                if (height[low] < height[high])
                {
                    low++;
                }
                else
                {
                    high--;
                }
            }
            return maxArea;
        }

        //153. Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            int min = int.MaxValue;
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] < min)
                {
                    min = nums[mid];
                }
                if (nums[high] < nums[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return min;
        }

        //424. Longest Repeating Character Replacement

        //3. Longest Substring Without Repeating Characters
        //Input: "abcabcbb"
        //Output: 3 
        //Explanation: The answer is "abc", with the length of 3.
        //Notes: did not get right
        public static int LengthOfLongestSubstring(string s)
        {
            int longest = 0;
            int start = 0;
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int end = 0; end < s.Length; end++)
            {
                if (!dictionary.ContainsKey(s[end]))
                {
                    dictionary.Add(s[end], end);
                }
                else
                {
                    start = Math.Max(start, dictionary[s[end]]);
                }
                longest = Math.Max(longest, end - start - 1);
            }

            return longest;
        }

        //200. Number of Islands
        public static int NumIslands(char[][] grid)
        {
            if (grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }
            int islands = 0;
            int rowCount = grid.Length;
            int columnCount = grid[0].Length;
            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < columnCount; c++)
                {
                    if (grid[r][c] == '1')
                    {
                        islands++;
                        NumIslandsDFS(r, c, grid);
                    }
                }
            }
            return islands;
        }

        public static void NumIslandsDFS(int r, int c, char[][] grid)
        {
            int rowCount = grid.Length;
            int columnCount = grid[0].Length;

            if (r < 0 || c < 0 || r >= rowCount || c >= columnCount || grid[r][c]== '0')
            {
                return;
            }

            grid[r][c] = '0';
            NumIslandsDFS(r + 1, c, grid);
            NumIslandsDFS(r - 1, c, grid);
            NumIslandsDFS(r, c + 1, grid);
            NumIslandsDFS(r, c - 1, grid);
        }

        //19. Remove Nth Node From End of List
        //Given linked list: 1->2->3->4->5, and n = 2.
        //After removing the second node from the end, the linked list becomes 1->2->3->5.
        //Notes: did not get answer right
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var curr = head;
            ListNode prev = null;
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            var nToRemove = count - n;
            int i = 0;
            while (curr != null)
            {
                if (i == nToRemove)
                {
                    prev.next = curr.next;
                    break;
                }
                else
                {
                    prev = curr;
                    curr = curr.next;
                }
                i++;
            }
            return prev.next;
        }

        //647. Palindromic Substrings
        //Notes: did not get right
        public static int CountSubstrings(string s)
        {
            int count = 0;
            return count;
        }

        //417. Pacific Atlantic Water Flow
        //Notes: did not get right

        //98. Validate Binary Search Tree
        //Notes: did not get right
        public static bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var rootValue = root.val;
            while (queue.Count > 0)
            {
                int level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var currNode = queue.Dequeue();
                    if (currNode.left != null)
                    {
                        if (currNode.left.val < currNode.val && currNode.left.val < rootValue)
                        {
                            queue.Enqueue(currNode.left);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (currNode.right != null)
                    {
                        if (currNode.right.val > currNode.val && currNode.right.val > rootValue)
                        {
                            queue.Enqueue(currNode.right);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        //226. Invert Binary Tree
        //Notes: my initial thought was correct but did not implement, simple BFS swapping the left and right node
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                var temp = curr.left;
                curr.left = curr.right;
                curr.right = temp;
                if (curr.left != null)
                {
                    queue.Enqueue(curr.left);
                }
                if (curr.right != null)
                {
                    queue.Enqueue(curr.right);
                }
            }
            return root;
        }

        //435. Non-overlapping Intervals
        //Notes: did not get right, close, I knew to use the Merge Interval approach, some good DP and Greedy Solutions are on Leetcode
        public static int EraseOverlapIntervals(int[][] intervals)
        {
            int count = 0;
            List<List<int>> listOfLists = new List<List<int>>();
            intervals = intervals.OrderBy(i => i[0]).ToArray();
            var start = intervals[0][0];
            var end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                var currStart = intervals[i][0];
                var currEnd = intervals[i][1];
                if (currStart <= end)
                {
                    end = Math.Max(end, currEnd);
                    count++;
                }
                else
                {
                    listOfLists.Add(new List<int>() { start, end });
                    start = currStart;
                    end = currEnd;
                }
            }
            return count;
        }

        //105. Construct Binary Tree from Preorder and Inorder Traversal
        //preorder = [3,9,20,15,7]
        //inorder = [9,3,15,20,7]
        //Notes: did not get right and did not understand the solution
        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            TreeNode root = new TreeNode(-1);
            //preoorder: root, left, right
            //inorder: left, root, right

            return root;
        }

        //104. Maximum Depth of Binary Tree
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int maxDepth = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int level = queue.Count;
                maxDepth++;
                for (int i = 0; i < level; i++)
                {
                    var currNode = queue.Dequeue();
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
            return maxDepth;
        }

        //100. Same Tree
        //Did not get right, should have went with DFS approach
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            Queue<TreeNode> q1 = new Queue<TreeNode>();
            Queue<TreeNode> q2 = new Queue<TreeNode>();
            q1.Enqueue(p);
            q2.Enqueue(q);
            while (q1.Count > 0 && q2.Count > 0)
            {
                if (q1.Count != q2.Count)
                {
                    return false;
                }
                int level = q1.Count;
                for (int i = 0; i < level; i++)
                {
                    var currNode1 = q1.Dequeue();
                    var currNode2 = q2.Dequeue();
                    if (currNode1.val != currNode2.val)
                    {
                        return false;
                    }
                    if (currNode1 != null && currNode2 == null)
                    {
                        return false;
                    }
                    if (currNode1 == null && currNode2 != null)
                    {
                        return false;
                    }
                    if (currNode1.left != null && currNode2.left != null)
                    {
                        q1.Enqueue(currNode1.left);
                        q2.Enqueue(currNode2.left);
                    }
                    if (currNode1.right != null && currNode2.right != null)
                    {
                        q1.Enqueue(currNode1.right);
                        q2.Enqueue(currNode2.right);
                    }
                    //currNode1.left.val != currNode2.left.val || currNode1.right.val != currNode2.right.val
                }
            }
            return true;
        }

        //102. Binary Tree Level Order Traversal
        //Notes: got answer right, used BFS while adding each level into a list
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }
            IList<IList<int>> ansList = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var level = queue.Count;
                List<int> list = new List<int>();
                for (int i = 0; i < level; i++)
                {
                    var currNode = queue.Dequeue();
                    list.Add(currNode.val);
                    if (currNode.left != null)
                    {
                        queue.Enqueue(currNode.left);
                    }
                    if (currNode.right != null)
                    {
                        queue.Enqueue(currNode.right);
                    }
                }
                ansList.Add(list);
            }

            return ansList;
        }

        //347. Top K Frequent Elements
        //Notes: did not get right, need to use a heap and dictionary

        //133. Clone Graph
        //Did not get right
        public static Node CloneGraph(Node node)
        {
            Node newGraph = new Node();
            HashSet<int> hashset = new HashSet<int>();
            foreach (var neighbor in node.neighbors)
            {
                if (!hashset.Contains(neighbor.val))
                {
                    Node newNode = new Node(neighbor.val);
                }
                else
                {

                }
            }

            return newGraph;
        }

        //572. Subtree of Another Tree
        public static bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s.val == t.val && IsSubtree(s.left, t.left) && IsSubtree(s.right, t.right))
            {
                return true;
            }
            return false;
        }

        //230. Kth Smallest Element in a BST
        //Got problem right, used a BFS traversal with a minHeap, used java for the implmentation.
        //Solved the problem within Leetcode.

        //235. Lowest Common Ancestor of a Binary Search Tree
        //Notes: did not get right, solution involved a bfs traversal either recursive or iterative.

        //23. Merge k Sorted Lists
        //Notes: did not get right but knew to use 2 heaps, min and max to solve the problem, did not get implementation right.

        //57. Insert Interval
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            if (newInterval.Length == 0)
            {
                return intervals.Length == 0 ? new int[0][] { } : intervals;
            }
            List<int[]> ans = new List<int[]>();
            intervals.OrderBy(i => i[0]);
            var start = intervals[0][0];
            var end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (newInterval[0] <= end)
                {
                    end = Math.Max(newInterval[1], end);
                }
                var currStart = intervals[i][0];
                var currEnd = intervals[i][1];
                if (currStart <= end)
                {
                    end = Math.Max(currEnd, end);
                }
                else
                {
                    ans.Add(new int[] { start, end });
                    start = currStart;
                    end = currEnd;
                }
            }
            ans.Add(new int[] { start, end });
            int[][] arrays = ans.Select(a => a.ToArray()).ToArray();
            return arrays;
        }

        //252. Meeting Rooms
        public static bool CanAttendMeetings(int[][] intervals)
        {
            List<int[]> list = new List<int[]>();
            intervals.OrderBy(i => i[0]);
            var start = intervals[0][0];
            var end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                var currStart = intervals[i][0];
                var currEnd = intervals[i][1];
                if (currStart <= end)
                {
                    end = Math.Max(end, currEnd);
                }
                else
                {
                    list.Add(new int[] { start, end });
                    start = currStart;
                    end = currEnd;
                }
            }
            list.Add(new int[] { start, end });
            return intervals.Length == list.Count();
        }

        //253. Meeting Rooms II
        public static int MinMeetingRooms(int[][] intervals)
        {
            List<int[]> list = new List<int[]>();
            intervals.OrderBy(i => i[0]);
            var start = intervals[0][0];
            var end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                var currStart = intervals[i][0];
                var currEnd = intervals[i][1];
                if (currStart <= end)
                {
                    end = Math.Max(end, currEnd);
                }
                else
                {
                    list.Add(new int[] { start, end });
                    start = currStart;
                    end = currEnd;
                }
            }
            list.Add(new int[] { start, end });
            return list.Count();
        }

        //261. Graph Valid Tree
        public static bool ValidTree(int n, int[][] edges)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < edges.Length; i++)
            {
                var src = edges[i][0];
                var dest = edges[i][1];
                if (hs.Contains(dest))
                {
                    return false;
                }
                hs.Add(dest);
            }
            return true;
        }
    }
    //124. Binary Tree Maximum Path Sum
    public class BinaryTreeMaxPath
    {
        public int MaxPathSum(TreeNode root)
        {
            int maxPathSum = 0;

            return maxPathSum;
        }
        public void Helper(TreeNode node, int sum)
        {
            if (node.left == null && node.right == null)
            {
                return;
            }

        }
    }


    //211. Add and Search Word - Data structure design
    public class WordDictionary
    {
        HashSet<string> hs;
        /** Initialize your data structure here. */
        public WordDictionary()
        {
            hs = new HashSet<string>();
        }

        /** Adds a word into the data structure. */
        public void AddWord(string word)
        {
            hs.Add(word);
        }

        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
        public bool Search(string word)
        {
            if (hs.Contains(word))
            {
                return true;
            }
            if (word.Contains('.'))
            {
                return SearchWildCard(word);
            }
            return false;
        }

        public bool SearchWildCard(string word)
        {
            int wildCardCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '.')
                {
                    wildCardCount++;
                }
            }
            foreach (var item in hs)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (word[i] == '.')
                    {
                        continue;
                    }
                    else
                    {
                        if (word[i] == item[i])
                        {
                            continue;
                        }
                    }
                }
            }
            return false;
        }
    }

    //297. Serialize and Deserialize Binary Tree
    //Notes: did not get right, was looking for a BFS Solution but DFS solution is the way to solve, I am scared of DFS(recursion)
    public class Codec
    {
        public string Serialize(TreeNode root)
        {
            //used bfs to make string
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<int> list = new List<int>();
            queue.Enqueue(root);
            var strTest = string.Empty;
            while (queue.Count > 0)
            {
                var level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    if (curr != null)
                    {
                        strTest = strTest + curr.val.ToString() + ",";
                    }
                    else
                    {
                        strTest = strTest + "null" + ",";
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
            }
            return strTest;
        }
        public TreeNode Deserialize(string data)
        {
            throw new NotImplementedException();
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val)
        {
            this.val = val;
        }
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
}

