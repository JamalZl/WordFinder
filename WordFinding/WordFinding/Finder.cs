using System;
using System.Collections.Generic;
using System.Text;

namespace WordFinding
{
    public static class Finder
    {
        public static bool EasyFind(this string str, string word)
        {
            int Find;
            Find = str.ToLower().IndexOf(word.ToLower(), 0, str.Length);
            if (Find==-1)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    } 
}
