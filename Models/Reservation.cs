using System.ComponentModel.DataAnnotations;

namespace DOCs_RSVP_Form.Models
{
    public class Reservation
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        // To do, get regex for phone numbers
        [Required(ErrorMessage = "Please enter a phone number")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        public bool? BringingDrinks { get; set; }
    }
}