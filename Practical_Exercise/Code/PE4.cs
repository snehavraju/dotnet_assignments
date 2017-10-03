using System;

namespace Code{
    class PE4{
        public void series(){
            try{
            Console.WriteLine("Enter the limit for series");
            int y=int.Parse(Console.ReadLine());
            for(int i=1;i<=y;i++){
                for(int j=1;j<=i;j++){
                    Console.Write(i);
                }
            }}
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }




    }
    }