using System;

namespace Code{
    public class PE5{

        public int sorting(string a){
           
            
            int c=int.Parse(a);
            int sum=0;
            string b=a;
            char[] charArray = b.ToCharArray();
            Array.Sort(charArray);
            Array.Reverse( charArray );
                Console.Write("Sorted number in non-increasing order :");
            for(int i=0;i<charArray.Length;i++){
                Console.Write(charArray[i]);
            }

            while(c>0){
                int rem = c%10;

                if(rem%2==0){
                    sum+=rem;
                }

                c = c/10;
                }
                Console.WriteLine(" ");

                Console.WriteLine("Sum of even numbers={0}",sum);
                if (sum>15){
                Console.WriteLine(" True");
                } else {
                    Console.WriteLine(" False");
                }

                return sum;
            

            
            
            }
        }
    }