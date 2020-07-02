namespace Storage.Models
{
    public class CharacterTrait
    {
        public int CharacterTraitId { get; set; }
        public int TraitId { get; set; }
        public int CharacterId { get; set; }
        public virtual Trait Trait { get; set; }
        public virtual Character Character { get; set; }
    }
}