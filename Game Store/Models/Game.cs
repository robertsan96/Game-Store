using System;
using System.ComponentModel.DataAnnotations;

namespace Game_Store.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; } 

        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}
