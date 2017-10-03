using System;

namespace Code{
    class PE6{
         public void repeat(){
             try{
             Console.WriteLine("Enter the string");
             string str = Console.ReadLine();
             Console.WriteLine("Enter the integer");
             int num = int.Parse(Console.ReadLine());
             char[] charArray= str.ToCharArray();
                    Console.Write(str);
             for(int i =0;i<num;i++)
             {
                 for(int j=(charArray.Length-num);j<charArray.Length;j++){
                     Console.Write(charArray[j]);
                 }
             }
             
             }
             catch(Exception ex){
                Console.WriteLine(ex.Message);
            }

            
            
             
                 
             
         }




    }}