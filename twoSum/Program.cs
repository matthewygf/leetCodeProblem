using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace twoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Stopwatch watch = new Stopwatch();
                var list = new List<int>() {230,863,916,585,981,404,316,785,88,12,70,435,384,778,887,755,740,337,86,92,325,422,815,650,920,125,277,336,221,847,168,23,677,61,400,136,874,363,394,199,863,997,794,587,124,321,212,957,764,173,314,422,927,783,930,282,306,506,44,926,691,568,68,730,933,737,531,180,414,751,28,546,60,371,493,370,527,387,43,541,13,457,328,227,652,365,430,803,59,858,538,427,583,368,375,173,809,896,370,789};
                int[] nums = list.ToArray();
                int target = 542;
                watch.Start();
                var sln = solution1(nums, target);
                watch.Stop();
                TimeSpan ts = watch.Elapsed;
                Console.WriteLine($"solution with Dict: {sln}  in {ts.TotalMilliseconds}");
                Console.ReadLine();

                watch.Reset();
                watch.Start();
                var sln2 = solution2(nums, target);
                watch.Stop();
                TimeSpan ts2 = watch.Elapsed;
                Console.WriteLine($"solution with List: {sln2}  in {ts2.TotalMilliseconds}");
                Console.ReadLine();
            }
            catch(Exception ex){
                Console.WriteLine(ex);
            }
        }

        private static (int x, int y)solution1(int[]nums, int target) { 
            var dict = new Dictionary<int, int>();
            
            for (var i = 0; i < nums.Length; i++){
                var temp = target - nums[i];
                if(dict.ContainsKey(temp)) {
                    return(dict[temp], i);
                }else {
                    if(!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i], i);
                }
            }
            throw new InvalidOperationException();
        }

        private static (int x, int y) solution2 (int[]nums, int target) {
            List<int> tempArray = new List<int>();
            for (var i = 0; i < nums.Length; i++){
                var temp = target - nums[i];
                var isExist = tempArray.Contains(temp);
                if(isExist) {
                    return(tempArray.IndexOf(temp), i);
                }else {
                    tempArray.Add(nums[i]);
                }
            }
            return (0,0);
        }
    }
}
