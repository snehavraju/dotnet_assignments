using System;

    class Program
    {
        static void Main( )
        {
            int i,j=0;
            string[] list = new string [5];
            string[] newlist = new string [5];
            
            

            list[0]="one";
            list[1]="two";
            list[2]="three";
            list[3]="four";
            list[4]="five";

            Console.WriteLine("Enter the word to be searched");
            string searchword = Console.ReadLine();

            for ( i=0;i<5;i++){
                 if (searchword == list[i])
                 j=1;
                    
            }
                if (j==1)
               Console.WriteLine("the word is present in the list");
               else
               Console.WriteLine("the word is not present in the list");

               for(i=0;i<5;i++)
               {newlist[i]=list[i];}
            
                Array.Sort(newlist);

            Console.WriteLine("Sorted list :");

            for (i=0;i<5;i++)
            {
                Console.WriteLine(newlist[i]);
            }

            int len = newlist.Length;

            Console.WriteLine("Length Of the array=" + len);            
                  
            
        }
    }

