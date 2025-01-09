using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static int[] TwoSum(int[] arr,int target){
        Dictionary<int,int> dict=new Dictionary<int, int>();
        for(int i=0;i<arr.Length;i++){
            int com=target-arr[i];
            if(dict.ContainsKey(com)){
                return new int[]{dict[com],i}; 
            }else{
                dict.Add(arr[i],i);
            }
        }

        return new int[3];
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        bool tnum=int.TryParse(Console.ReadLine(),out int num);
        int[] arr={1,2,3,4,5};
        int[] result=TwoSum(arr,num);
        Console.WriteLine($"{result[0]}  {result[1]}");
    }
    }
