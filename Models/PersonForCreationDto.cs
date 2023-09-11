using System.ComponentModel.DataAnnotations;

namespace hngXStageTwo.Models
{
	public class PersonForCreationDto
	{
		[MinLength(3, ErrorMessage = "You should provide a name value of at least 3 characters long")]
		[Required(ErrorMessage = "You should provide a name value")]
		public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}

