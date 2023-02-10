using System.ComponentModel.DataAnnotations;

namespace ApiProject.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public string? PlatformName { get; set; }
    }
}