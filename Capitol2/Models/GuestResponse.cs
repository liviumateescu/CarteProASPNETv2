using System.ComponentModel.DataAnnotations;

namespace Capitol2.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please eneter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please eneter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify if you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
