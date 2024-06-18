using System.ComponentModel.DataAnnotations;
namespace D01K14BlazorServerApp.Data
{
    public class Category
    {
        public int CatId { get; set; }
        [Required (ErrorMessage ="Please provide category name")]
        public string CatName { get; set; }
        [Required]
        [Range(0,1)]
        public int IsDeleted { get; set; }

        public Category()
        {
        }

        public Category (int catId, string catName, int isDeleted)
        {
            CatId = catId;
            CatName = catName;
            IsDeleted = isDeleted;
        }
    }
}
