 using System;
 using System.Collections.Generic;

namespace Code{
 
 interface IProduct{
        List<ProductGroup> ProductGroupfill();
        List<ProductInfo> ProductFill();
        List<ProductInfo> ProductSort( List<ProductInfo> forsort);
        List<ProductInfo> ProductDelete();

    }



    public class ProductDetailFill {

       public List<ProductGroup> ProductGroupfill(){

             

            List<ProductGroup> prodgrp = new List<ProductGroup>();

            prodgrp.Add(new ProductGroup(){GroupId=1,GroupName="Dairy"});
            prodgrp.Add(new ProductGroup(){GroupId=2,GroupName="Chocolates"});
            prodgrp.Add(new ProductGroup(){GroupId=3,GroupName="Detergents"});
            prodgrp.Add(new ProductGroup(){GroupId=4,GroupName="Soaps"});

            return prodgrp;

        }

        public List<ProductInfo> ProductFill(){

            ProductInfo product1 = new ProductInfo(){

                GroupId = 1,
                ProductId = 1,
                ProductName = "Go cheese",
                ProductDescription = "Go Cheese 180g",
                ProductRate = 115

            };

            ProductInfo product2 = new ProductInfo(){

                GroupId = 1,
                ProductId = 2,
                ProductName = "Amul cheese",
                ProductDescription = "Amul Cheese 210g",
                ProductRate = 125

            };

            ProductInfo product3 = new ProductInfo(){

                GroupId = 1,
                ProductId = 3,
                ProductName = "Britania cheese",
                ProductDescription = "Britania Cheese 200g",
                ProductRate = 100

            };

            List<ProductInfo> prodinfo = new List<ProductInfo>();
            prodinfo.Add(product1);
            prodinfo.Add(product2);
            prodinfo.Add(product3);
            prodinfo.Add(new ProductInfo(){GroupId=2,ProductId=4,ProductName="Dairy Milk",ProductDescription="Dairy Milk Small",ProductRate=20});
            prodinfo.Add(new ProductInfo(){GroupId=2,ProductId=5,ProductName="Munch",ProductDescription="Munch XL",ProductRate=20});
            prodinfo.Add(new ProductInfo(){GroupId=2,ProductId=6,ProductName="Five Star",ProductDescription="Five star Big",ProductRate=30});
            prodinfo.Add(new ProductInfo(){GroupId=3,ProductId=7,ProductName="Tide",ProductDescription="Tide 500g ",ProductRate=250});
            prodinfo.Add(new ProductInfo(){GroupId=3,ProductId=8,ProductName="Surf Excel",ProductDescription="Surf Excel 250g",ProductRate=300});
            prodinfo.Add(new ProductInfo(){GroupId=4,ProductId=9,ProductName="Pears",ProductDescription="Pears Small",ProductRate=30});
            prodinfo.Add(new ProductInfo(){GroupId=4,ProductId=10,ProductName="Dove",ProductDescription="Dove Small",ProductRate=40});            
            return prodinfo;

        }


        public List<ProductInfo> ProductSort(List<ProductInfo> forsort)
        {           
            forsort.Sort();
            return forsort;
        }

        public List<ProductInfo> ProductDelete(List<ProductInfo> todelete,int position){
            todelete.RemoveAt(position-1);
            return todelete;
        }


    }
}
    
    
