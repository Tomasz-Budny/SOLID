namespace SRP
{
    public class LineItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public LineItem(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}