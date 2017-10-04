using System;
using System.Collections.Generic;

namespace Code
{
    class Program
    {
        static void Main()
        {
            try
            {
                string continueaction="";
            do
            {
            Console.WriteLine("Enter 1 for Displaying Products, 2 for Displaying sorted Products, 3 for searching a Product by name, 4 for deleting a product");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {

                
            case 1: ProductDetailFill objproductfill = new ProductDetailFill();
                    List<ProductInfo> productdetails1 = objproductfill.ProductFill();  
                    List<ProductGroup> groupdetails1 = objproductfill.ProductGroupfill();
                    Display objdisplayproducts = new Display();
                    objdisplayproducts.displayproduct(groupdetails1,productdetails1);
                    
                    break;

            case 2: ProductDetailFill objsortproduct = new ProductDetailFill();
                    List<ProductGroup> groupdetails2 = objsortproduct.ProductGroupfill();
                    List<ProductInfo> tosortlist = objsortproduct.ProductFill();
                    List<ProductInfo> productdetails2 = objsortproduct.ProductSort(tosortlist); 
                    Display objdisplaysortproducts = new Display();
                    objdisplaysortproducts.displaysortproducts(groupdetails2,productdetails2);
                    break;

            case 3: Console.WriteLine("Enter the product to be searched");
                    string str = Console.ReadLine();
                    ProductDetailFill objsearchproduct = new ProductDetailFill();
                    List<ProductGroup> groupdetails3 = objsearchproduct.ProductGroupfill();
                    List<ProductInfo> productdetails3 = objsearchproduct.ProductFill();
                    Display objdisplaysearchproducts = new Display();
                    objdisplaysearchproducts.displaysearchproducts(groupdetails3,productdetails3,str);

                    
                    break;

            case 4: 
                    ProductDetailFill objdeleteproduct = new ProductDetailFill();
                    List<ProductGroup> groupdetails4 = objdeleteproduct.ProductGroupfill();
                    List<ProductInfo> productdetails4 = objdeleteproduct.ProductFill();
                    
                    string deleteoption="";

                    do{
                    Console.WriteLine("Enter the option number");
                    int i=1;
                     foreach(ProductInfo p in productdetails4)
                     {
                        Console.WriteLine("{0} - {1}",i,p.ProductName);
                        i++;
                     }
                    int entered_choice=int.Parse(Console.ReadLine());
                    productdetails4 = objdeleteproduct.ProductDelete(productdetails4,entered_choice); 
                    Console.WriteLine("Product list after deleting the item:");
                    Display objdisplaydeleteproducts = new Display();
                    objdisplaydeleteproducts.displayproduct(groupdetails4,productdetails4);
                    Console.WriteLine( "Enter 'yes' to continue deleting or type anything to exit");
                    deleteoption = Console.ReadLine() ;
                    }
                      while(deleteoption.ToUpper() == "YES")   ;    
                    break;                      


                    default : Console.WriteLine("Enter the right choice");
                    break;


            } 
            Console.WriteLine("Enter 'yes' to continue operations or type anything to exit");
            continueaction = Console.ReadLine();

            }
            while(continueaction.ToUpper() == "YES");
            
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }      
        }
    }
}
