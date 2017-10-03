using System;

namespace Code{
    class PE3{
        public void word(){
            try{
            Console.WriteLine("Enter the letters to know vowel or a consonant");
            string z = Console.ReadLine();
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
            }}}
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }


    }}