    using System;
    using Gee.External.Capstone.Arm64;


    namespace ProgramNames
    {
        public class Program 
        { 
            public static void Main(string[] args)
            {
                List<int> numbers=new List<int>(){-5, 236, 120, 70, -5, -5, 698, 280};
                List<int> sort=numbers.Where(x=>x!=-5).OrderBy(x=>x).ToList();

                int count=0;    
                List<int> newOrder=sort.Select(x=>x>=0?sort[count++]:-5).ToList();
                Console.WriteLine($"[{string.Join(",",newOrder)}]");
            }
        }
    }
