namespace CodeLearning.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Colors { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Name} - {Price} - {string.Join(", ", Colors)}";
        }
    }
}
