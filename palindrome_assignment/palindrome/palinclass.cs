using System;

namespace palindrome
{
    public class Palind
    {
        public bool IsPalindrom( string x)
        {
            string rev = "";
            for (int i = x.Length-1; i >=0; i--){
                rev += x[i].ToString();
            }

            if(rev==x){
                return true;
            }
            else {
                 return false;
                 }
        }
    }
}