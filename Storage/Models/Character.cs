using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace CharacterStorage.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string Faction { get; set; }
        public int Experience { get; set; }
        public string Bio { get; set; }
        [Required]
        [Range(1, 20)]
        public int Level { get; set; }

        [Required]
        public string Name { get; set; }

        // Character attributes
        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Might { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Spryness { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Judgement { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Echo { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Magnetism { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Fortune { get; set; }

        ICollection<CharacterTrait> Traits;

        public Character()
        {
            this.Traits = new HashSet<CharacterTrait>();
        }
    }
}