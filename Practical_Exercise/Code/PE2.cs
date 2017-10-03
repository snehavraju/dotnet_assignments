using System;

namespace Code{
    public class PE2{

        public string TomJerry(int x){
           
            

            if(20<x && x<30){  
            if ((x%2)!=0){
                Console.WriteLine("Tom");
                return "Tom";
            }
            else{ Console.WriteLine("Jerry");
                return "Jerry";
            }
            
            
            }
            return "Not within Range";
            



        }
    }


}