using System;

namespace Code{
    public class PE6{
         public string repeat(string str,int num){
             
             
             string add="";
             
             char[] charArray= str.ToCharArray();
                    Console.Write(str);
             for(int i =0;i<num;i++)
             {
                 for(int j=(charArray.Length-num);j<charArray.Length;j++){
                     Console.Write(charArray[j]);
                     add+=charArray[j];
                 }
             }
             
             return add;
             
             

            
            
             
                 
             
         }




    }}