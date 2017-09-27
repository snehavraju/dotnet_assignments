using System;

namespace palindrome
{
    public class Palind
    {
        public bool IsPalindrom( string x)
        {
            
            char[] charArray = x.ToCharArray();
            Array.Reverse( charArray );
            string charStr = new string ( charArray );
            bool result = Array.Equals(x,charStr);
            
             /*string revs="";
            
            for (int i = x.Length-1; i >=0; i--)
            {
                revs += x[i].ToString();
            }*/
           
            

            if(result){
                return true;
            }
            else {
                 return false;
                 }
        }
    }
}