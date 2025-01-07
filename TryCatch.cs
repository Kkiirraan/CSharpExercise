using System;
using System.Collections;
using System.Net.Security;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
          try
          {
             int x=100;
             int div=x/0;
             Console.WriteLine(div);
          }
          catch (Exception ex)
          {
            Console.WriteLine(ex.Message);
          }
        }
    }
}
