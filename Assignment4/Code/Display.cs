using System;
using System.Collections.Generic;

namespace Code
{
    public class Display
    { 
        public void displayproduct(List<ProductGroup> groupdetails1, List<ProductInfo> productdetails1 )
        {
            foreach(ProductGroup groupcount1 in groupdetails1)
                    {
                        foreach(ProductInfo productcount1 in productdetails1)
                        {
                            if(productcount1.GroupId==groupcount1.GroupId)
                            {
                                Console.WriteLine("Product Group Name = {0}",groupcount1.GroupName );
                                Console.WriteLine("Product Name = {0}",productcount1.ProductName );
                                Console.WriteLine("Product Description = {0}",productcount1.ProductDescription );
                                Console.WriteLine("Product Rate = {0}",productcount1.ProductRate );
                                Console.WriteLine("  ");
                            }
                        }
                    }


        }

        public void displaysortproducts(List<ProductGroup>groupdetails2,List<ProductInfo>productdetails2){

            foreach(ProductInfo productcount2 in productdetails2)
                    {
                        foreach(ProductGroup groupcount2 in groupdetails2)
                        {
                            if(productcount2.GroupId==groupcount2.GroupId)
                            {
                                Console.WriteLine("Product Group Name = {0}",groupcount2.GroupName );
                                Console.WriteLine("Product Name = {0}",productcount2.ProductName );
                                Console.WriteLine("Product Description = {0}",productcount2.ProductDescription );
                                Console.WriteLine("Product Rate = {0}",productcount2.ProductRate );
                                Console.WriteLine("  ");
                            }
                        }
                    }

        }

        public void displaysearchproducts(List<ProductGroup>groupdetails3,List<ProductInfo>productdetails3,string str)
        {   int j=0;
            foreach(ProductGroup groupcount3 in groupdetails3)
                    {
                        foreach(ProductInfo productcount3 in productdetails3 )
                        {
                            if(groupcount3.GroupId == productcount3.GroupId)
                            {

                                if(productcount3.ProductName.ToUpper().Contains(str.ToUpper()))
                                {
                                    j=1;
                                    Console.WriteLine("Product Group Name = {0}",groupcount3.GroupName );
                                    Console.WriteLine("Product Name = {0}",productcount3.ProductName );
                                    Console.WriteLine("Product Description = {0}",productcount3.ProductDescription );
                                    Console.WriteLine("Product Rate = {0}",productcount3.ProductRate );
                                    Console.WriteLine("  ");
                                
                                }
                            }

                         }
                    }
                    if(j==0)
                    {
                        Console.WriteLine("No Product Found");
                    }


        }

        

    }

}