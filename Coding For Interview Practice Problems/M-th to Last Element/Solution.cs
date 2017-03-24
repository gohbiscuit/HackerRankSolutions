using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string mString = Console.ReadLine();
        string lString = Console.ReadLine();

        int m;
        if (Int32.TryParse(mString, out m))
        {
            string[] lArray = lString.Split(' ');

            LinkedList<string> linkedList = new LinkedList<string>(lArray);
            Process(m, linkedList);
        }
        else
        {
            /* no, not able to parse */
            Console.WriteLine("Error, input is not a number, please check again.");
        }
    }
    
     private static void Process(int mElementAway, LinkedList<string> list)
     {
         if(mElementAway > list.Count)
         {
             Console.WriteLine("NIL");
         }
         else
         {
             /* Print out the content of the list */
             int index = list.Count - mElementAway;
             Console.WriteLine(list.ElementAt(index));
         }
     }
}