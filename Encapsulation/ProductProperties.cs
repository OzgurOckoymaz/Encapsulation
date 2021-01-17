using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class ProductProperties
    {
        private string _productName;
        private decimal _price;
        private int _quantity;
        private DateTime _expiryDate;

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public DateTime ExpiryDate
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }

        public override string ToString()
        {
            return ProductName;
        }

    }
}
