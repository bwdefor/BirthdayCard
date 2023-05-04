using System.ComponentModel.DataAnnotations;

namespace BirthdayCard.Models
{
    public class CardDetails
    {
        [Required(ErrorMessage = "Please enter who the card is to")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter who the card is from")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter a message for the recipient")]
        public string Message { get; set; }
    }
}
