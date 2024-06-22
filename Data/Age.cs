using System.ComponentModel.DataAnnotations;

namespace BlazorApp5.Data
{
    public class Age
    {

        public int Id { get; set; }

		[Required]
        [RegularExpression(@"^[3-9][0-9]$|^1[0-9]$", ErrorMessage = "Age must be a number between 3 and 20 and doesn't contain any letter ")]
		public string Name { get; set; }


        public Age()
        {

        }

        public Age(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
