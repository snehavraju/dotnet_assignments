using System;
using Xunit;
using System.Collections.Generic;
using Code;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            ProductInfo obj1prodinfo = new ProductInfo();
            ProductInfo obj2prodinfo = new ProductInfo();
            ProductInfo obj3prodinfo = new ProductInfo();
            ProductDetailFill objdeletecheck = new ProductDetailFill();
            List<ProductInfo> productsBeforeDeleting = new List<ProductInfo>();
            List<ProductInfo> productsAfterDeleting = new List<ProductInfo>();
            productsBeforeDeleting.Add(obj1prodinfo);
            productsBeforeDeleting.Add(obj2prodinfo);
            productsBeforeDeleting.Add(obj3prodinfo);

            //Act
            int listbeforecount = productsBeforeDeleting.Count;
            productsAfterDeleting = objdeletecheck.ProductDelete(productsBeforeDeleting,1);
            int listaftercount = productsAfterDeleting.Count;

            //Assert
            Assert.IsType<int>(listbeforecount);
            Assert.IsType<int>(listaftercount);
            Assert.Equal(listaftercount,listbeforecount-1);





        }
    }
}
