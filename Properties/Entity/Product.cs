namespace Exam.Properties.Entity
{
    public class Product
    {
        private string _productId;
        private string _productName;
        private decimal _price;

        public Product(string productId, string productName, decimal price)
        {
            _productId = productId;
            _productName = productName;
            _price = price;
        }

        public string ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

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
    }
}