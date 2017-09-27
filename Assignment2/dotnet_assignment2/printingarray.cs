using System;

namespace dotnet_assignment2
{

public  class Arrayser
    {
     public int PrintNumbers(int n)
        {
        int[] Numbers = new int [n];
            int i ;
            
            for(i=0;i<n;i++){
                if(i==11){
                Console.WriteLine("Array crosses 10");
                }
                
                
                Numbers[i]=i;
                Console.WriteLine(Numbers[i]);
                
                
                
            }
            return Numbers.Length;
        }
       
    }

}

