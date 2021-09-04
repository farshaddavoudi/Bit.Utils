using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bit.Utils.Models.Identity
{
    [ComplexType]
    public class UserRoleDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "User Domain Name is required")]
        public string? UserId { get; set; }

        [Required(ErrorMessage = "Role name is required")]
        public string? RoleName { get; set; }
    }
}