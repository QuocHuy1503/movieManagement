using System.ComponentModel.DataAnnotations;
namespace D01K14BlazorServerApp.Data
{
	public class User
	{
		public int UserId { get; set; }
		[Required]
		public required string UserFullName { get; set; }
		[Required]
		public required string UserPassword { get; set; }
		[Required]
		public required string UserEmail { get; set; }
		public required string AvatarUrl { get; set; }
		public int IsDeleted { get; set; }
		public int UserLevel { get; set; }
	}
}
