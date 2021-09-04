using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bit.Utils.Models.Identity
{
    [ComplexType]
    public class RoleDto
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}