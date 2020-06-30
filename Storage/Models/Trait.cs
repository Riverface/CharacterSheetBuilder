using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace CharacterStorage.Models
{
    public class Trait
    {
        
        public int TraitId {get;set;}
     
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
        
        //Stretch
        // public List<Delegate> Contextuals;
    }
}