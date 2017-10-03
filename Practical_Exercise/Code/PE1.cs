using System;

namespace Code
{
    public class PE1{
        public long palin(long number){
            
            
            long numbercopy=number;
            long Reverse=0;
            long sum=0;
           while(numbercopy>0)  
            {  
                long remainder = numbercopy % 10;  
                Reverse = (Reverse * 10) + remainder;  
                numbercopy = numbercopy / 10;  
            }
            

            if (number==Reverse){
                long num = number;
                
                while(num>0){
                long rem = num%10;

                if(rem%2==0){
                    sum+=rem;
                }

                num = num/10;
                }
                if (sum>25)
                {
                Console.WriteLine("{0} is palindrome and the sum of even numbers is greater than 25 and sum={1}",number,sum);
                } 
                else 
                {
                    Console.WriteLine("{0} is palindrome and the sum of even numbers is less than 25 and sum={1}",number,sum);
                }
            }

            else Console.WriteLine("{0} is not palindrome",number);
            return sum;
            
            
            
            }
        }
    }






