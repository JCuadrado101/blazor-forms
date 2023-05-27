using System.ComponentModel.DataAnnotations;

namespace blazor_forms.Models

{
    public class BasicInfoModel
    {
        [Required(ErrorMessage = "Missing First Name.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Missing Last Name.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Missing SSN.")]
        [RegularExpression(@"^(?!(000|666|9))\d{3}-(?!00)\d{2}-(?!0000)\d{4}$", ErrorMessage = "Invalid SSN")]
        public string? SSN { get; set; }

        [Required(ErrorMessage = "Missing Date of Birth.")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Missing Phone Number")]
        public string? PhoneNumber { get; set; }
        public bool IsCallAccepted { get; set; }
    }
}
