using System;

namespace Code
{
    class Program
    {
        static void Main()
        {
            int s1,s2,s3,l,b,s;
           Console.WriteLine("Enter 1 for triangle perimeter,2 for rectangle perimeter, 3 for square perimeter");
           int x = int.Parse(Console.ReadLine());

           if(x==1){
               Console.WriteLine("Enter the three sides of a triangle");
               s1=int.Parse(Console.ReadLine());
               s2=int.Parse(Console.ReadLine());
               s3=int.Parse(Console.ReadLine());
               math TP1 = new math (s1,s2,s3);
               /*TrianglePerimeter TP = new TrianglePerimeter();*/
               Console.WriteLine("Perimeter = {0}",TP1.triangleperim());
           }

            else  if(x==2){
               Console.WriteLine("Enter the two sides of a rectangle");
               l=int.Parse(Console.ReadLine());
               b=int.Parse(Console.ReadLine());
              
               math RP2 = new math (l,b);
               /*RectanglePerimeter RP = new RectanglePerimeter();*/
               Console.WriteLine("Perimeter = {0}",RP2.rectangleperim());
            }

               else   if(x==3){
            Console.WriteLine("Enter the side of the square");
               s=int.Parse(Console.ReadLine());
              
               math SP3 = new math (s);
               /*SquarePerimeter SP = new SquarePerimeter();*/
               Console.WriteLine("Perimeter = {0}",SP3.squareperim());
              
               }


            else Console.WriteLine("Enter A correct choice");




           }

        }
    }

