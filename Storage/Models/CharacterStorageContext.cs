using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Storage.Models
{
    public class StorageContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Character> Characters { get; set; }
        public virtual DbSet<Trait> Traits { get; set; }
        public virtual DbSet<CharacterTrait> CharacterTraits { get; set; }
        public StorageContext(DbContextOptions<StorageContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Character>()
              .HasData(
                new Character { CharacterId = 1, Name = "Garrick", Bio = "Driven to drink by mediocrity.", Might = 10, Spryness = 12, Judgement = 6, Echo = 8, Magnetism = 9, Fortune = 15, Level = 2 },
                new Character { CharacterId = 2, Name = "Nori", Bio = "Small business owner.", Might = 15, Spryness = 15, Judgement = 1, Echo = 15, Magnetism = 15, Fortune = 1, Level = 5 },
                new Character { CharacterId = 3, Name = "Ulstyr", Bio = "A small dragon in a big body", Might = 25, Spryness = 10, Judgement = 15, Echo = 1, Magnetism = 8, Fortune = 6, Level = 10 }
            );
            builder.Entity<Trait>()
            .HasData(
                new Trait { TraitId = 1, Name = "Hardheaded", Might = 1, Spryness = 1, Judgement = 0, Echo = -3, Magnetism = 0, Fortune = 0 },
                new Trait { TraitId = 2, Name = "Wimpy", Might = -1, Spryness = 2, Judgement = 0, Echo = 0, Magnetism = 0, Fortune = 0 },
                new Trait { TraitId = 3, Name = "Big Booty", Might = 1, Spryness = 0, Judgement = 4, Echo = 0, Magnetism = 0, Fortune = -10 }
            );

        }
    }
}
