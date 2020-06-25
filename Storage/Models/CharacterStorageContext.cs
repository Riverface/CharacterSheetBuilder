using Microsoft.EntityFrameworkCore;

namespace CharacterStorage.Models
{
    public class CharacterStorageContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public CharacterStorageContext(DbContextOptions<CharacterStorageContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Character>()
              .HasData(
                new Character{CharacterId = 1, Name = "Garrick", Might = 10, Spryness = 12, Judgement = 6, Echo = 8, Magnetism = 9, Fortune = 15, Level = 2},
                new Character{CharacterId = 2, Name = "Nori", Might = 15, Spryness = 15, Judgement = 1, Echo = 15, Magnetism = 15, Fortune = 1,  Level = 5},
                new Character{CharacterId = 3,   Name = "Ulstyr", Might = 25, Spryness = 10, Judgement = 15, Echo = 15, Magnetism = 8, Fortune = 6, Level = 10}
              );
        }
        
    }
}