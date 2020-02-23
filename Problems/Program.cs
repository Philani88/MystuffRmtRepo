using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Problems
{
    public class Program
    {
        string Prefix(string input )
        {
          if(input==null)
         {
            return null;
         } 
          string[] inputary= input.Split();
          int numwords=inputary.Length;
          int numchars=input.Length;
          return ($"{numchars},{numwords}:input");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
