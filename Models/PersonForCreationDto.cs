using System.ComponentModel.DataAnnotations;

namespace hngXStageTwo.Models
{
	public class PersonForCreationDto
	{
		[Required(ErrorMessage = "You should provide a first name value")]
		public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "You should provide a last name value")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "You should provide an email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "You should provide a birthdate")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "You should provide an address")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "You should provide a phone number")]
        public long PhoneNumber { get; set; }
    }
}

