using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Words_from_Strangers.Models
{
    public class Message
    {
        public int MessageId { get; set; }

        [Required(ErrorMessage = "Please enter a Message.")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "The {0} must be between {2} and {1} characters long.")]
        public string MessageText { get; set; } = "";

        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; } = DateTime.Now;

        public string? Location { get; set; }
    }
}
