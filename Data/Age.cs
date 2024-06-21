using System.ComponentModel.DataAnnotations;

namespace BlazorApp5.Data
{
    public class Age
    {
        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "Name must be a number")]
        public int Id { get; set; }
        
        public int Name { get; set; }


        public Age()
        {

        }

        public Age(int id, int name)
        {
            Id = id;
            Name = name;
        }
    }
}
