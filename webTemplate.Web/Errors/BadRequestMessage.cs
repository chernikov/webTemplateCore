using System.ComponentModel.DataAnnotations;

namespace webTemplate.Web.Errors
{
    public class BadRequestMessage
    {
        [Required]
        public string Message { get; set; }
    }
}
