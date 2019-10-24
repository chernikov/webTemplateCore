using System.ComponentModel.DataAnnotations;

namespace webTemplate.Web.Dto
{
    public class TokenDto
    {
        [Required]
        public string Token { get; set; }
    }
}
