using System;
using System.Net.Security;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
          enum Days
           {
            mon,tue,wed,fri=10,thu,sat,sun
           }
        public static void Main(string[] args){
            Days days=Days.mon;
            Console.WriteLine(days);

            int mon=(int)Days.mon;
            Console.WriteLine(mon);

            Console.WriteLine((int)Days.thu);
        }
    }
}
