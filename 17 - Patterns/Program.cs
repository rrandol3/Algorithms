using System;
using System.Collections.Generic;
using System.Linq;

namespace _17___Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,3,3 };
            var ans = SubsetsDuplicates2(nums);
            foreach (var list in ans)
            {
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        #region Sliding Window
        //Maximum Sum Subarray of Size K (easy)
        //Input: [2, 1, 5, 1, 3, 2], k=3 
        //Output: 9
        public static int MaxSumSubArrayOfSizeK(int[] nums, int k)
        {
            int maxSum = 0;
            int windowStart = 0;
            int currSum = 0;
            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {
                currSum += nums[windowEnd];
                if (windowEnd >= k - 1)//k - 1 becaus zero indexing, eg k = 3, [0,1,2]
                {
                    maxSum = Math.Max(maxSum, currSum);
                    currSum -= nums[windowStart];
                    windowStart++;
                }
            }
            return maxSum;
        }

        //Smallest Subarray with a given sum (easy)
        //Input: [2, 1, 5, 2, 3, 2], S=7 
        //Output: 2
        public static int SmallestSubArrayWithSum(int[] nums, int s)
        {
            int ans = int.MaxValue;
            int windowStart = 0;
            int windowSum = 0;
            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {
                windowSum += nums[windowEnd];
                while (windowSum >= s)//while loop for dynmic window, shrink and expand
                {
                    ans = Math.Min(ans, windowEnd - windowStart + 1);
                    windowSum -= nums[windowStart];
                    windowStart++;
                }
            }
            return ans;
        }

        //Longest Substring with K Distinct Characters (medium)
        //Input: String="araaci", K=2
        //Output: 4
        public static int LongestSubstringKDistinctChars(string str, int k)
        {
            int ans = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                if (!dict.ContainsKey(str[windowEnd]))
                {
                    dict.Add(str[windowEnd], 1);
                }
                else
                {
                    dict[str[windowEnd]]++;
                }
                while (dict.Count > k)
                {
                    dict[str[windowStart]]--;
                    if (dict[str[windowStart]] == 0)
                    {
                        dict.Remove(str[windowStart]);
                    }
                    windowStart++;
                }
                ans = Math.Max(ans, windowEnd - windowStart + 1);
            }
            return ans;
        }

        //Fruits into Baskets (medium)
        //Input: Fruit=['A', 'B', 'C', 'A', 'C']
        //Output: 3
        public static int FruitsInBasket(char[] fruits)
        {
            int ans = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < fruits.Length; windowEnd++)
            {
                if (!dict.ContainsKey(fruits[windowEnd]))
                {
                    dict.Add(fruits[windowEnd], 1);
                }
                else
                {
                    dict[fruits[windowEnd]]++;
                }
                while (dict.Count > 2)
                {
                    dict[fruits[windowStart]]--;
                    if (dict[fruits[windowStart]] == 0)
                    {
                        dict.Remove(fruits[windowStart]);
                    }
                    windowStart++;
                }
                ans = Math.Max(ans, windowEnd - windowStart + 1);
            }
            return ans;
        }

        //No-repeat Substring (hard)
        //Input: String="aabccbb"
        //Output: 3
        //Notes: need to understand the solution
        public static int NoRepeatingSubstring(string str)
        {
            int ans = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int windowStart = 0;
            char noRepeatIndex = str[0];
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                if (!dict.ContainsKey(str[windowEnd]))
                {
                    noRepeatIndex = str[windowEnd];
                    dict.Add(str[windowEnd], windowEnd);
                }
                else
                {
                    var index = dict[noRepeatIndex];
                    ans = Math.Max(ans, windowEnd - windowStart + 1);
                    windowStart = index;
                }
            }
            return ans;
        }
        #endregion

        #region Two Pointers
        //Pair with Target Sum (easy)
        //Input: [1, 2, 3, 4, 6], target=6
        //Output: [1, 3]
        //Notes: Dictionary/Hashtable would also work but with O(n) space
        public static int[] PairWithTargetSum(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                if (nums[low] + nums[high] == target)
                {
                    return new int[] { low, high };
                }
                if (nums[low] + nums[high] > target)
                {
                    high--;
                }
                else
                {
                    low++;
                }
            }
            return new int[] { -1, -1 };
        }

        //Remove Duplicates (easy)
        //Input: [2, 3, 3, 3, 6, 9, 9]
        //Output: 4
        public static int RemoveDuplicates(int[] nums)
        {
            int nextNonDuplicate = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[nextNonDuplicate - 1] != nums[i])
                {
                    nums[nextNonDuplicate] = nums[i];
                    nextNonDuplicate++;
                }
            }
            return nextNonDuplicate;
        }

        //Squaring a Sorted Array (easy)
        //Input: [-2, -1, 0, 2, 3]
        //Output: [0, 1, 4, 4, 9]
        //Notes: need to go over, did not get right
        public static int[] SquarringSortedArray(int[] nums)
        {
            int[] ans = new int[nums.Length];
            int highIndex = nums.Length - 1;
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int lowSquared = nums[low] * nums[low];
                int highSquared = nums[high] * nums[high];
                if (highSquared > lowSquared)
                {
                    ans[highIndex] = highSquared;
                    highIndex--;
                    high--;
                }
                else
                {
                    ans[highIndex] = lowSquared;
                    highIndex--;
                    low++;
                }
            }
            return ans;
        }

        //Triplet Sum to Zero (medium)
        //Input: [-3, 0, 1, 2, -1, 1, -2]
        //Output: [-3, 1, 2], [-2, 0, 2], [-2, 1, 1], [-1, 0, 1]
        public static List<List<int>> TripleSumToZero(int[] nums)
        {
            List<List<int>> ansList = new List<List<int>>();

            return ansList;
        }


        #endregion

        #region Slow and Fast Pointer
        //LinkedList Cycle (easy)
        public static bool HasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == slow)
                {
                    return true;
                }
            }
            return false;
        }

        //Middle of the LinkedList (easy)
        //Input: 1 -> 2 -> 3 -> 4 -> 5 -> null
        //Output: 3
        public static ListNode MiddleOfList(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    break;
                }
            }
            return slow;
        }
        #endregion

        #region Merge Intervals
        //Merge Intervals (medium)
        //Intervals: [[1,4], [2,5], [7,9]]
        //Output: [[1,5], [7,9]]
        public static List<Interval> MergeIntervals(List<Interval> intervals)
        {
            List<Interval> list = new List<Interval>();
            //sort the intervals by start time
            intervals.Sort((x,y) =>  x.start.CompareTo(y.start));
            var start = intervals[0].start;//start off with first start interval
            var end = intervals[0].end;//start off with first end interval
            for (int i = 1; i < intervals.Count; i++)
            {
                var interval = intervals[i];//get interval at index
                if (interval.start <= end)//check to see if start < end
                {
                    end = Math.Max(interval.end, end);//take the larger between curr end and index end
                }
                else
                {
                    list.Add(new Interval(start, end));//create new interval and add start & end to answer list
                    start = interval.start; //set start to interval start
                    end = interval.end; //set interval end to end
                }
            }
            list.Add(new Interval(start, end));//add last start & end interval to answer list
            return list;
        }

        public static List<Interval> MergeIntervals2(List<Interval> intervals)
        {
            List<Interval> ansList = new List<Interval>();
            intervals.Sort((a, b) => a.start.CompareTo(b.start));
            var start = intervals[0].start;
            var end = intervals[0].end;
            for (int i = 1; i < intervals.Count; i++)
            {
                var interval = intervals[i];
                if (interval.start <= end)
                {
                    end = Math.Max(interval.end, end);
                }
                else
                {
                    ansList.Add(new Interval(start, end));
                    start = interval.start;
                    end = interval.end;
                }
            }
            ansList.Add(new Interval(start, end));
            return ansList;
        }
        #endregion

        #region Cycle Sort
        //Cyclic Sort (easy)
        //Input: [3, 1, 5, 4, 2]
        //Output: [1, 2, 3, 4, 5]
        public static void Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var j = nums[i] - 1;
                if (nums[i] != j)
                {
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            } 
        }

        
        #endregion

        #region In-Place Reversal of Linked List
        //Reverse a LinkedList (easy)
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
        #endregion

        #region Tree BFS
        //Binary Tree Level Order Traversal (easy)
        public static List<List<int>> BinaryTreeLevelOrderTraversal(TreeNode root)
        {
            List<List<int>> ansList = new List<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var level = queue.Count;
                var list = new List<int>();
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    list.Add(curr.val);
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                ansList.Add(list);
            }
            return ansList; 
        }

        //Reverse Level Order Traversal (easy)
        public static LinkedList<List<int>> BinaryTreeLevelOrderTraversalReversed(TreeNode root)
        {
            LinkedList<List<int>> ansList = new LinkedList<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var level = queue.Count;
                var list = new List<int>();
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    list.Add(curr.val);
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                ansList.AddFirst(list);
            }
            return ansList;
        }

        //Level Averages in a Binary Tree (easy)
        public static List<double> LevelAvgBinaryTree(TreeNode root)
        {
            List<double> averages = new List<double>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var level = queue.Count;
                double sum = 0;
                int count = 0;
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    sum += curr.val;
                    count++;
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                double avg = sum / count;
                averages.Add(avg);
            }
            return averages;
        }

        //Level Averages in a Binary Tree (easy) Follow Up: largest value on each level
        public static List<int> LargetOnEachLevelBinaryTree(TreeNode root)
        {
            List<int> list = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var level = queue.Count;
                int levelMax = int.MinValue;
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    levelMax = Math.Max(levelMax, curr.val);
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                list.Add(levelMax);
            }
            return list;
        }

        //Minimum Depth of a Binary Tree (easy)
        public static int MinimumDepthBinary(TreeNode root)
        {
            int minDepth = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                minDepth++;
                var level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
                    if (curr.left == null && curr.right == null)
                    {
                        return minDepth;
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
            return minDepth;
        }

        //Minimum Depth of a Binary Tree (easy) Follow Up: Max depth or Height of tree;
        public static int MaxDepthOfBinaryTree(TreeNode root)
        {
            int height = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                height++;
                var level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var curr = queue.Dequeue();
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
            return height;
        }

        //Level Order Successor (easy)
        //Notes: struggled a little with this one, think about the queue operations that could be beneficial
        public static TreeNode FindSuccessor(TreeNode root, int key)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                if (curr.left != null)
                {
                    queue.Enqueue(curr.left);
                }
                if (curr.right != null)
                {
                    queue.Enqueue(curr.right);
                }
                if (curr.val == key)
                {
                    break;
                }
            }
            return queue.Peek();
        }
        #endregion

        #region Tree DFS

        public static void Preorder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.val + " ");
            Preorder(node.left);
            Preorder(node.right);
        }
        public static void Postorder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Postorder(node.left);
            Postorder(node.right);
            Console.Write(node.val + " ");
        }

        public static void Inorder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Inorder(node.left);
            Console.Write(node.val + " ");
            Inorder(node.right);
        }

        //Binary Tree Path Sum (easy)
        //Notes: need to remember what is a leaf is
        public static bool hasPath(TreeNode node, int sum)
        {
            if (node == null)
            {
                return false;
            }
            //leaf node 
            if (node.val == sum && node.left == null && node.right == null)
            {
                return true;
            }
            else
            {
                return hasPath(node.left, sum - node.val) || hasPath(node.right, sum - node.val);
            }
        }
        public static bool HasPath(TreeNode root, int sum)
        {
            if (root == null)
                return false;

            // if the current node is a leaf and its value is equal to the sum, we've found a path
            if (root.val == sum && root.left == null && root.right == null)
                return true;

            // recursively call to traverse the left and right sub-tree
            // return true if any of the two recursive call return true
            return HasPath(root.left, sum - root.val) || HasPath(root.right, sum - root.val);
        }

        //Binary Tree All Paths
        public static List<List<int>> FindPaths(TreeNode node, int sum)
        {
            List<List<int>> allPaths = new List<List<int>>();

            return allPaths;
        }
        #endregion

        #region Subsets
        //Notes: need to go over this section

        //Subsets (easy)
        //Input: [1, 3]
        //Output: [], [1], [3], [1,3]
        public static List<List<int>> Subsets(int[] nums)
        {
            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>());//add empty set
            foreach (var currNumber in nums)
            {
                int n = subsets.Count;//get subset count
                for (int i = 0; i < n; i++)
                {
                    List<int> set = new List<int>(subsets[i]);//create new set from current sets
                    set.Add(currNumber);//add currNumber to new set
                    subsets.Add(set);//add set to subset
                }
            }
            return subsets;
        }

        public static List<List<int>> Subsets2(int[] nums)
        {
            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>());//new empty set
            foreach (var num in nums)
            {
                int n = subsets.Count();
                for (int i = 0; i < n; i++)
                {
                    List<int> set = new List<int>(subsets[i]);
                    set.Add(num);
                    subsets.Add(set);
                }
            }
            return subsets;
        }

        //Subsets With Duplicates (easy)
        //Input: [1, 3, 3]
        //Output: [], [1], [3], [1,3], [3,3], [1,3,3]
        public static List<List<int>> SubsetsDuplicates(int[] nums)
        {
            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>());//add empty set
            HashSet<List<int>> hs = new HashSet<List<int>>();//for distinct elements
            foreach (var currNumber in nums)
            {
                int n = subsets.Count;//get subset count
                for (int i = 0; i < n; i++)
                {
                    List<int> set = new List<int>(subsets[i]);//create new set from current sets
                    set.Add(currNumber);//add currNumber to new set
                    subsets.Add(set);//add set to subset
                }
            }
            return subsets;
        }

        public static List<List<int>> SubsetsDuplicates2(int[] nums)
        {
            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>());
            foreach (var num in nums)
            {
                int n = subsets.Count();
                for (int i = 0; i < n; i++)
                {
                    List<int> set = new List<int>(subsets[i]);
                    set.Add(num);
                    subsets.Add(set);
                }
            }
            return subsets;
        }

        #endregion

        #region Modified Binary Search
        //Order-agnostic Binary Search (easy)
        //Input: [10, 6, 4], key = 10
        //Output: 0
        public static int Search(int[] arr, int key)
        {
            bool ascending = arr[0] < arr[1] ? true : false;
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (key > arr[mid])
                {
                    if (ascending)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
                else
                {
                    if (ascending)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
            }
            return -1;
        }
        #endregion

        #region Bitwise XOR
        //Single Number (easy)
        //Input: 1, 4, 2, 1, 3, 2, 3
        //Output: 4
        public static int SingleNumber(int[] nums)
        {
            int num = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                num = num ^ nums[i];
            }
            return num;
        }
        #endregion

        #region Two Heaps
        //see java implementation C:\Users\rrand\Desktop\Heap Problems Java
        #endregion

        #region Top K Elements
        //see java implementation C:\Users\rrand\Desktop\Heap Problems Java
        #endregion

        #region K - Way Merge
        //see java implementation C:\Users\rrand\Desktop\Heap Problems Java
        #endregion

        #region Dynamic Programming
        #endregion

        #region Topological Sort(Graph)
        public static List<int> TopologicalSort(int vertices, int[][] edges)
        {
            List<int> sorted = new List<int>();
            //initialize graph
            Dictionary<int, int> inDegree = new Dictionary<int, int>();
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            for (int i = 0; i < vertices; i++)
            {
                inDegree.Add(i, 0);
                graph.Add(i, new List<int>());
            }

            //build graph
            for (int i = 0; i < edges.Length; i++)
            {
                int parent = edges[i][0];
                int child = edges[i][1];
                graph[parent].Add(child);
                inDegree[child]++;
            }

            //find all vertices with 0 indegrees
            Queue<int> sources = new Queue<int>();
            foreach (var item in inDegree)
            {
                if (item.Value == 0)
                {
                    sources.Enqueue(item.Key);
                }
            }

            //foreach source subtract 1 from child, if child = 0 add it to sources
            while (sources.Count != 0)
            {
                int vertex = sources.Dequeue();
                sorted.Add(vertex);
                var children = graph[vertex];
                foreach (var item in children)
                {
                    inDegree[item]--;
                    if (inDegree[item] == 0)
                    {
                        sources.Enqueue(item);
                    }
                }
            }

            //check to see if there are any cycles
            if (sorted.Count != vertices)
            {
                return new List<int>();
            }

            return sorted;
        }

        //207. Course Schedule
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            List<int> sorteOrder = new List<int>();
            //initialize graph
            Dictionary<int, int> indegrees = new Dictionary<int, int>();
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                indegrees.Add(i, 0);
                graph.Add(i, new List<int>());
            }

            //build graph
            for (int i = 0; i < prerequisites.Length; i++)
            {
                var parent = prerequisites[i][0];
                var child = prerequisites[i][1];
                graph[parent].Add(child);
                indegrees[child]++;
            }

            //get sources
            Queue<int> sources = new Queue<int>();
            foreach (var item in indegrees)
            {
                if (item.Value == 0)
                {
                    sources.Enqueue(item.Key);
                }
            }
            //check children
            while (sources.Count != 0)
            {
                var vertex = sources.Dequeue();
                sorteOrder.Add(vertex);
                var children = graph[vertex];
                foreach (var child in children)
                {
                    indegrees[child]--;
                    if (indegrees[child] == 0)
                    {
                        sources.Enqueue(child);
                    }
                }
            }

            return sorteOrder.Count == numCourses;
        }

        //210. Course Schedule II
        public static int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            int[] sortedOrder = new int[numCourses];
            //initialize graph
            Dictionary<int, int> indegrees = new Dictionary<int, int>();
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                indegrees.Add(i, 0);
                graph.Add(i, new List<int>());
            }
            //build graph
            for (int i = 0; i < prerequisites.Length; i++)
            {
                var parent = prerequisites[i][0];
                int child = prerequisites[i][1];
                graph[child].Add(parent);
                indegrees[parent]++;
            }

            //get sources
            Queue<int> sources = new Queue<int>();
            foreach (var item in indegrees)
            {
                if (item.Value == 0)
                {
                    sources.Enqueue(item.Key);
                }
            }

            //check children
            int j = 0;
            while (sources.Count != 0)
            {
                var vertex = sources.Dequeue();
                sortedOrder[j++] = vertex;
                var children = graph[vertex];
                foreach (var child in children)
                {
                    indegrees[child]--;
                    if (indegrees[child] == 0)
                    {
                        sources.Enqueue(child);
                    }
                }
            }

            if (numCourses != j)
            {
                return new int[] { };
            }

            return sortedOrder;
        }
        #endregion

        #region Back Tracking
        #endregion
    }

    public class FindAllTreePaths
    {
        public List<List<int>> FindPaths(TreeNode node, int sum)
        {
            List<List<int>> allPaths = new List<List<int>>();
            List<int> currPath = new List<int>();
            FindPathsRec(node, sum, currPath, allPaths);
            return allPaths;
        }
        private void FindPathsRec(TreeNode node, int sum, List<int> currPath, List<List<int>> allPaths)
        {
            if (node == null)
            {
                return;
            }
            currPath.Add(node.val);
            if (node.val == sum && node.left == null && node.right == null)
            {
                allPaths.Add(new List<int>(currPath));
            }
            else
            {
                FindPathsRec(node.left, sum - node.val, currPath, allPaths);
                FindPathsRec(node.right, sum - node.val, currPath, allPaths);
            }
            currPath.Remove(node.val);
        }
    }

    #region Helper Classes
    public class Interval
    {
        public int start;
        public int end;
        public Interval(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
    }
    public class ListNode
    {
        public int value = 0;
        public ListNode next;

        public ListNode(int value)
        {
            this.value = value;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    };
    #endregion
}
