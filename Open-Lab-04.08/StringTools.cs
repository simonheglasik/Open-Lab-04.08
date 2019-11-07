using System;
using System.Collections.Generic;
namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            List<string> b = new List<string> { };
            foreach(string a in strings)
            {
                if (a.Length == 4)
                {
                    b.Add(a);
                }
            }
            return b.ToArray();
        }
    }
}
