using System;
using System.ComponentModel.DataAnnotations;
namespace Core.Entitities
{
    public class SharedProperties
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}