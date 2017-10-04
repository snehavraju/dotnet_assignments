using System;
using System.Collections.Generic;

namespace Code
{
    class Program
    {
        static void Main()
        {
            
                string continueaction="";
            do
            {
             try
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

            case 4: Console.WriteLine("Enter 1 for deleting by option");
                    Console.WriteLine("Enter 2 for deleting by product name");
                    int deletechoice = int.Parse(Console.ReadLine());
                    switch(deletechoice)
                    {
                          case 1:  
                            ProductDetailFill objdeleteproduct = new ProductDetailFill();
                            List<ProductGroup> groupdetails4 = objdeleteproduct.ProductGroupfill();
                            List<ProductInfo> productdetails4 = objdeleteproduct.ProductFill();
                            
                            string deleteoption1="";

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
                            deleteoption1 = Console.ReadLine() ;
                            }
                            while(deleteoption1.ToUpper() == "YES")   ;
                            break;

                            case 2:
                             ProductDetailFill objDeleteProductbyName = new ProductDetailFill();
                             List<ProductGroup> groupdetails5 = objDeleteProductbyName.ProductGroupfill();
                             List<ProductInfo> productdetails5 = objDeleteProductbyName.ProductFill();
                             string deleteoption2="";

                             do{
                                 try{
                                 Console.WriteLine("Enter the product name");
                                 int i=1;
                                 foreach(ProductInfo q in productdetails5)
                                 {
                                     Console.WriteLine("{0}-{1} ",i,q.ProductName);
                                     i++;
                                 }
                                 string deletestring = Console.ReadLine();
                                 Display objdisplaydeleteproductsbyname = new Display();
                                 productdetails5 =objdisplaydeleteproductsbyname.deletebyname(productdetails5,deletestring);
                                 objdisplaydeleteproductsbyname.displayproduct(groupdetails5,productdetails5) ;  
                                 }
                                 catch(Exception){}
                                 Console.WriteLine( "Enter 'yes' to continue deleting or type anything to exit");
                                 deleteoption2 = Console.ReadLine() ;

                             }
                                while(deleteoption2.ToUpper() == "YES");
                            break;

                            default:
                            Console.WriteLine("Enter correct option");
                            break;
                            }    
                    break;                      


                    default : Console.WriteLine("Enter the right choice");
                    break;


            } }

            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Enter 'yes' to continue operations or type anything to exit");
            continueaction = Console.ReadLine();

            
            
            
            }
            while(continueaction.ToUpper() == "YES");
            
            
                  
        }
    }
}
