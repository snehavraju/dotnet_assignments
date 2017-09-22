using System;


namespace palindrome
{

    
    class Program
    {
        static void Main()
        {
           Palind P1 =new Palind();
           bool result = P1.IsPalindrom("salsa");
           if (result){
               Console.WriteLine("palindrome");
           }
           else{
              Console.WriteLine("not palindrome"); 
           }
        }
    }
}
