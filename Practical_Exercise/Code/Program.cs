using System;

namespace Code
{
    class Program
    {
        static void Main()
        {  
            Console.WriteLine("Enter the option");
            Console.WriteLine("1-PE1");
            Console.WriteLine("2-PE2");
            Console.WriteLine("3-PE3");
            Console.WriteLine("4-PE4");
            Console.WriteLine("5-PE5");
            Console.WriteLine("6-PE6");
            int choice = int.Parse(Console.ReadLine());

            switch(choice){
                
            case 1:
                    PE1 p = new PE1();
                    p.palin();
                    break;
            case 2:
                    PE2 q = new PE2();
                    q.TomJerry();
                    break;

            case 3: 
                    PE3 r = new PE3();
                    r.word();
                    break;

            case 4:
                    PE4 s = new PE4();
                    s.series();
                    break;

            case 5:
                    PE5 t = new PE5();
                    t.sorting();
                    break;
            
            case 6:
                    PE6 u = new PE6();
                    u.repeat();
                    break;

            default:
                    Console.WriteLine("Enter the correct choice");
                    break;        
        }
    }
}
