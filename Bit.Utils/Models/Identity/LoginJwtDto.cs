using System.ComponentModel.DataAnnotations.Schema;

namespace Bit.Utils.Models.Identity
{
    [ComplexType]
    public class LoginJwtDto
    {
        public string? AccessToken { get; set; }

        public int ExpiresIn { get; set; }

        public string? TokenType { get; set; }
    }
}
