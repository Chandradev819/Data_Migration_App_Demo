using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Migration_App.Models
{
    public class Image
    {
        public string url { get; set; }
    }

    public class Attribute
    {
        public int attributeId { get; set; }
        public int attributeValueId { get; set; }
        public string customAttributeValue { get; set; }
    }

    public class Item
    {
        public string barcode { get; set; }
        public string title { get; set; }
        public string productMainId { get; set; }
        public int brandId { get; set; }
        public int categoryId { get; set; }
        public int quantity { get; set; }
        public string stockCode { get; set; }
        public int dimensionalWeight { get; set; }
        public string description { get; set; }
        public string currencyType { get; set; }
        public double listPrice { get; set; }
        public double salePrice { get; set; }
        public int vatRate { get; set; }
        public int cargoCompanyId { get; set; }
        public int shipmentAddressId { get; set; }
        public int returningAddressId { get; set; }
        public List<Image> images { get; set; }
        public List<Attribute> attributes { get; set; }
    }

    public class Root
    {
        public Item items { get; set; }
    }

}
