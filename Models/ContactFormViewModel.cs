using System.ComponentModel.DataAnnotations;

namespace UmbracoSetup_STMOGROUP.Models
{
    public class ContactFormViewModel
    {
        [Required(ErrorMessage = "Vänligen fyll i ditt namn")]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "Vänligen fyll i din e-post")]
        [EmailAddress(ErrorMessage = "Vänligen ange en giltig e-postadress")]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "Meddelandet får inte vara tomt")]
        [MinLength(10, ErrorMessage = "Meddelandet måste vara minst 10 tecken")]
        public string Message { get; set; } = default!;
    }
}