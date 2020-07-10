using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Top_Amazon_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[3][];
            grid[0] = new int[] { 2,1,1 };
            grid[1] = new int[] { 1,1,0 };
            grid[2] = new int[] { 0,1,1 };
            Console.WriteLine(OrangesRotting(grid));
        }

        //1. Two Sum
        //input: [2, 7, 11, 15], target = 9
        //output: [0, 1]
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
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

        //937. Reorder Data in Log Files
        //Did not get right
        public static string[] ReorderLogFiles(string[] logs)
        {
            //letter logs have 2nd word as words only
            //digit logs have 2nd word as digits only
            //letter logs must come first
            List<string> letterLogs = new List<string>();
            List<string> digitLogs = new List<string>();
            foreach (var word in logs)
            {
                var wordArray = word.ToCharArray();
                for (int i = 0; i < wordArray.Length; i++)
                {
                    if (wordArray[i] == ' ')
                    {
                        if (Char.IsDigit(wordArray[i + 1]))
                        {
                            digitLogs.Add(word);
                            break;
                        }
                        else
                        {
                            letterLogs.Add(word);
                            break;
                        }
                    }
                }
            }
            var combined = letterLogs.OrderBy(s => s.Length).ToList();
            combined.AddRange(digitLogs);
            string[] results = new string[combined.Count];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = combined[i];
            }
            return results;
        }

        //121. Best Time to Buy and Sell Stock
        //Notes: did not get right
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            
            return maxProfit;
        }

        //819. Most Common Word
        //Notes: did not get right
        public static string MostCommonWord(string paragraph, string[] banned)
        {
            var paragraphArray = paragraph.Split(' ');
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            foreach (var word in paragraphArray)
            {
                var containtsSymbol = !char.IsLetterOrDigit(word.Last());
                if (containtsSymbol)
                {
                    word.Substring(0, word.Length - 1);
                }
                if (!wordFrequency.ContainsKey(word))
                {
                    wordFrequency.Add(word, 1);
                }
                else
                {
                    wordFrequency[word]++;
                }
            }
            for (int i = 0; i < banned.Length; i++)
            {
                if (wordFrequency.ContainsKey(banned[i]))
                {
                    wordFrequency.Remove(banned[i]);
                }
            }

            var mostCommon = string.Empty;
            int mostCommonCount = 0;
            foreach (var item in wordFrequency)
            {
                if (item.Value == mostCommonCount)
                {
                    mostCommon = item.Key;
                }
            }

            return mostCommon;
        }

        //200. Number of Islands
        //Notes: did not get right
        public static int NumIslands(char[][] grid)
        {
            int islands = 0;
            int rowCount = grid.Length;
            int columnCount = grid[0].Length;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        islands++;
                        NumIslandsDFS(i, j, grid);
                    }
                }
            }
            return islands;
        }

        public static void NumIslandsDFS(int i, int j, char[][] grid)
        {
            int rowCount = grid.Length;
            int columnCount = grid[0].Length;

            if (i < 0 || j < 0 || i >= rowCount || j >= columnCount || grid[i][j] == '0')
            {
                return;
            }

            grid[i][j] = '0';
            NumIslandsDFS(i - 1, j, grid);
            NumIslandsDFS(i + 1, j, grid);
            NumIslandsDFS(i, j - 1, grid);
            NumIslandsDFS(i, j + 1, grid);          
        }

        //994. Rotting Oranges
        //Notes: did not get right
        public static int OrangesRotting(int[][] grid)
        {
            int orangesRotting = 0;
           
            return orangesRotting;
        }

        

    }
}
