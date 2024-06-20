namespace BlazorApp5.Data
{
    public class Age
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Age(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
