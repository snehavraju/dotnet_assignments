using System;

namespace Code
{
    class Program
    {
        static void Main()
        {  
            try{
            Console.WriteLine("Enter the option");
            Console.WriteLine("1-PracticalExercise 1");
            Console.WriteLine("2-PracticalExercise 2");
            Console.WriteLine("3-PracticalExercise 3");
            Console.WriteLine("4-PracticalExercise 4");
            Console.WriteLine("5-PracticalExercise 5");
            Console.WriteLine("6-PracticalExercise 6");
            int choice = int.Parse(Console.ReadLine());

            switch(choice){
                
            case 1: Console.WriteLine("Enter the number to check for palindrome");
                    long number=Convert.ToInt64(Console.ReadLine());
                    PE1 p = new PE1();
                    p.palin(number);
                    break;
            case 2: Console.WriteLine("Enter The number to display tom or jerry");
                    int x = int.Parse(Console.ReadLine());
                    PE2 q = new PE2();
                    q.TomJerry(x);
                    break;

            case 3: Console.WriteLine("Enter the letters to know vowel or a consonant");
                    string z = Console.ReadLine();
                    PE3 r = new PE3();
                    r.word(z);
                    break;

            case 4: Console.WriteLine("Enter the limit for series");
                    int y=int.Parse(Console.ReadLine());
                    PE4 s = new PE4();
                    s.series(y);
                    break;

            case 5: Console.WriteLine("Enter the number to sort");
                    string a= Console.ReadLine();
                    PE5 t = new PE5();
                    t.sorting(a);
                    break;
            
            case 6: Console.WriteLine("Enter the string");
                    string str = Console.ReadLine();
                    Console.WriteLine("Enter the integer");
                    int num = int.Parse(Console.ReadLine());
                    PE6 u = new PE6();
                    u.repeat(str,num);
                    break;

            default:
                    Console.WriteLine("Enter the correct choice");
                    break;   
            }}
            catch (Exception ex)
            {
                    Console.WriteLine(ex.Message);
            }     
        
    }}
}
