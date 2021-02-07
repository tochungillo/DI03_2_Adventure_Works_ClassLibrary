namespace DI03_2_Adventure_Works_ClassLibrary
{
    public class ProductModel
    {
        public int ProductModelID { get; set; }
        public string ProductModelName { get; set; }
        public double ListPrice { get; set; }
        public byte[] LargePhoto { get; set; }

        public override string ToString()
        {
            return $"Product model id: {ProductModelID}, Product model name: {ProductModelName}, List price: {ListPrice}";
        }
    }
}