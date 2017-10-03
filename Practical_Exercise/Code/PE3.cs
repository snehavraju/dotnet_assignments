using System;

namespace Code{
    public class PE3{
        public string word(string z)
        {                        
            int a;
            
             if (Int32.TryParse(z, out a))
             {
                 throw new Exception("string cant be a number ");
             }
             else{
                        z.ToLower();
            char[] charArray = z.ToCharArray();
            for (int i =0;i< charArray.Length;i++){
                
                if ((charArray[i] >= 'a' && charArray[i] <= 'z'))
                {
                if(charArray[i]=='a' || charArray[i]=='e' || charArray[i]=='i' || charArray[i]=='o' || charArray[i]=='u'){
                    Console.WriteLine("{0} - Vowel",charArray[i]);
                    
                }
                else {
                    Console.WriteLine("{0} - Consonant",charArray[i]);
                    
                }}
                else{
                    Console.WriteLine("Please enter a letter");
                }
            }}
            z.ToLower();
            char[] charArraycopy = z.ToCharArray();
            for (int i =0;i< charArraycopy.Length;i++){
                
                if ((charArraycopy[i] >= 'a' && charArraycopy[i] <= 'z'))
                {
                if(charArraycopy[i]=='a' || charArraycopy[i]=='e' || charArraycopy[i]=='i' || charArraycopy[i]=='o' || charArraycopy[i]=='u'){
                   return "vowel";
                    
                }
                else {
                    return "consonant";
                    
                }}
            }
                return "not a letter";
                       
            
            
        }


    }}