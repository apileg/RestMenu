using System.Drawing;

namespace RestMenu
{
    public class Food
    {
        public Bitmap Image { get; }
        public string Description { get; }
        public string Name { get; }
        public double Weight { get; }
        public double Price { get; }

        public int Count { get; set; }

        public Food(Bitmap image,string name ,string description, double weight, double price)
        {
            Image = image;
            Name = name;
            Description = description;

            Weight = weight;
            Price = price;

            Count = 0;
        }
    }
}
