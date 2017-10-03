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
            Console.WriteLine("Enter 1 for Displaying Products, 2 for Displaying sorted Products, 3 for searching a Product by name, 4 for deleting a product");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {

                
            case 1: ProductDetailFill P1 = new ProductDetailFill();
                    List<ProductInfo> productP1details =P1.ProductFill();  
                    List<ProductGroup> groupP1details =P1.ProductGroupfill();

                    foreach(ProductGroup q in groupP1details){

                    foreach(ProductInfo p in productP1details){

                    if(p.GroupId==q.GroupId){
                    Console.WriteLine("Product Group Name = {0}",q.GroupName );
                    Console.WriteLine("Product Name = {0}",p.ProductName );
                    Console.WriteLine("Product Description = {0}",p.ProductDescription );
                    Console.WriteLine("Product Rate = {0}",p.ProductRate );
                    Console.WriteLine("  ");
                    }}}
                    break;

            case 2: ProductDetailFill P2 = new ProductDetailFill();
                    List<ProductGroup> groupP2details =P2.ProductGroupfill();
                    List<ProductInfo> tosortlist =P2.ProductFill();
                    List<ProductInfo> productP2details =P2.ProductSort(tosortlist); 
                    

                    foreach(ProductInfo p in productP2details){

                    foreach(ProductGroup q in groupP2details){

                    if(p.GroupId==q.GroupId){
                    Console.WriteLine("Product Group Name = {0}",q.GroupName );
                    Console.WriteLine("Product Name = {0}",p.ProductName );
                    Console.WriteLine("Product Description = {0}",p.ProductDescription );
                    Console.WriteLine("Product Rate = {0}",p.ProductRate );
                    Console.WriteLine("  ");
                   }
                   }}

                   break;

            case 3: Console.WriteLine("Enter the product to be searched");
                    string str = Console.ReadLine();
                    int j=0;
                    ProductDetailFill P3 = new ProductDetailFill();
                    List<ProductGroup> groupP3details = P3.ProductGroupfill();
                    List<ProductInfo> productP3details = P3.ProductFill();

                    foreach(ProductGroup p in groupP3details){
                    foreach(ProductInfo q in productP3details ){
                        if(p.GroupId == q.GroupId){

                            if(q.ProductName.ToUpper().Contains(str.ToUpper())){
                                    
                                j=1;
                                Console.WriteLine("Product Group Name = {0}",p.GroupName );
                                Console.WriteLine("Product Name = {0}",q.ProductName );
                                Console.WriteLine("Product Description = {0}",q.ProductDescription );
                                Console.WriteLine("Product Rate = {0}",q.ProductRate );
                                Console.WriteLine("  ");
                                
                            }

                            
                        }

                    }}
                    if(j==0){
                        Console.WriteLine("No Product Found");
                    }
                    break;

            case 4: 
                    ProductDetailFill P4 = new ProductDetailFill();
                    List<ProductGroup> groupP4details = P4.ProductGroupfill();
                    List<ProductInfo> beforedelete = P4.ProductFill();
                    Console.WriteLine("Enter the option number");
                    int i=1;
                     foreach(ProductInfo p in beforedelete){
                          Console.WriteLine("{0} - {1}",i,p.ProductName);
                          i++;
                           }
                           int entered_choice=int.Parse(Console.ReadLine());
                           List<ProductInfo> productP4details =P4.ProductDelete(beforedelete,entered_choice); 
                           Console.WriteLine("Product list after deleting the item:");
                           foreach(ProductGroup q in groupP4details){
                           foreach(ProductInfo p in productP4details){
                           if(p.GroupId==q.GroupId){
                           Console.WriteLine("Product Group Name = {0}",q.GroupName );
                           Console.WriteLine("Product Name = {0}",p.ProductName );
                           Console.WriteLine("Product Description = {0}",p.ProductDescription );
                           Console.WriteLine("Product Rate = {0}",p.ProductRate );
                           Console.WriteLine("  ");
                           }}}


                                        


                        break;
                            
                    
                    
                    
                    
                    
                    
                    
                    
                    default : Console.WriteLine("Enter the right choice");
                    break;


            } }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }      
        }
    }
}
