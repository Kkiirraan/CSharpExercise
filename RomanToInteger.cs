using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
            
            Console.WriteLine("Enter a Roman number  : ");
            string str=Console.ReadLine();
            var romMap=new Dictionary<char,int>{
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            int sum=0;
            int last=0;
            for(int i=str.Length-1;i>=0;i--){
                int current=romMap[str[i]];
                if(current<last){
                    sum-=current;
                }else{
                    sum+=current;
                }
                last=current;
            }
            Console.WriteLine(sum);
        }
    }
}
