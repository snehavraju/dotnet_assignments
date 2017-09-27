using System;


namespace palindrome
{

    
    class Program
    {
        static void Main()
        {  
           Console.WriteLine("Enter the word");
           string word= Console.ReadLine();
           Palind P1 =new Palind();
           bool result = P1.IsPalindrom(word);
           if (result){
               Console.WriteLine("The word is palindrome");
           }
           else{
              Console.WriteLine("The word is not palindrome"); 
           }
        }
    }
}
