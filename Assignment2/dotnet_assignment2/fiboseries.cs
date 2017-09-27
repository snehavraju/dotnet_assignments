using System;

namespace dotnet_assignment2
{

     public class Fibonacci{
        public int Printseries(int y){
            int i;
             int t1=0;
             int t2=1;
             int t3=0;
             int sum=1;
            Console.WriteLine("Fibonacci series :");
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            for(i=0;i<y-2;i++)
            {
                t3=t1+t2;
                sum+=t3;
                Console.WriteLine(t3);
                t1=t2;
                t2=t3;
                
            }
        return sum;
        


        }
    }
    
}