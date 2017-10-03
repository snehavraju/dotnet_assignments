using System.Collections.Generic;
using System;

namespace Code{
    public class ProductInfo : IComparable<ProductInfo>
    {
        public int GroupId {get;set;}
        public int ProductId {get;set;}
        public string ProductName {get;set;}
        public string ProductDescription {get;set;}
        public int ProductRate {get;set;}

        public int CompareTo( ProductInfo other)
        {
            return this.ProductName.CompareTo(other.ProductName);

        }

    }
}