using System;

namespace Code{
    public class PE4{
        public int series(int y){
            
            
            int sum=0;
            for(int i=1;i<=y;i++){
                for(int j=1;j<=i;j++){
                    Console.Write(i);
                    sum=(sum*10)+ i;
                }
            }
            return sum;
        }




    }
    }