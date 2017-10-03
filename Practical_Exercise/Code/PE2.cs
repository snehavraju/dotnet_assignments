using System;

namespace Code{
    class PE2{

        public void TomJerry(){
            try{
            Console.WriteLine("Enter The number to display tom or jerry");
            int x = int.Parse(Console.ReadLine());

            if(20<x && x<30){  
            if ((x%2)!=0){
                Console.WriteLine("Tom");
            }
            else{ Console.WriteLine("Jerry");
            }
            
            
            }}
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }




        }
    }


}