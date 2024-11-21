namespace CodingTestBlazor.Models
{
    public class Person
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
