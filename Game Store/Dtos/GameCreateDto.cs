using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Game_Store.Dtos
{
    public class GameCreateDto
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}
