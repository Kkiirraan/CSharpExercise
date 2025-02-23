using System;


namespace ProgramNames
{
    public class Program 
    {
        public static string LongestPalindrome(string str)
        {
            if(str.Length==1) return str;
            int i=0;
            string newStr="";
            while(i<str.Length)
            {
                for(int j=str.Length;j>=i;j--)
                {
                    string revStr=new string(str.Substring(i,j-i).ToCharArray().Reverse().ToArray());
                    // Console.WriteLine(revStr);
                    if(revStr==str.Substring(i,j-i))
                    {
                        // Console.WriteLine(revStr+"From ");
                        if(revStr.Length>newStr.Length)
                        {
                            newStr=revStr;
                        }
                    }
                }
                i++;
            }
            return newStr;
        }
        public static void Main(string[] args)
        {
           Console.WriteLine("Enter a string:");
           string str=Console.ReadLine();
            Console.WriteLine(LongestPalindrome(str));
        }
    }
}
