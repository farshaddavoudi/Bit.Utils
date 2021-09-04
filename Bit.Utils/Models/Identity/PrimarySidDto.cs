using System.ComponentModel.DataAnnotations.Schema;

namespace Bit.Utils.Models.Identity
{
    [ComplexType]
    public class PrimarySidDto
    {
        public string? UserId { get; set; }

        public CustomPropsDto? CustomProps { get; set; }
    }
}
