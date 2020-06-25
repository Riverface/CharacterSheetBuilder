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
                new Character { CharacterId = 1, Name = "Garrick", Bio = "Driven to drink by mediocrity.", Might = 10, Spryness = 12, Judgement = 6, Echo = 8, Magnetism = 9, Fortune = 15, Level = 2 },
                new Character { CharacterId = 2, Name = "Nori", Bio = "Small business owner.", Might = 15, Spryness = 15, Judgement = 1, Echo = 15, Magnetism = 15, Fortune = 1, Level = 5 },
                new Character { CharacterId = 3, Name = "Ulstyr", Bio = "A small dragon in a big body", Might = 25, Spryness = 10, Judgement = 15, Echo = 1, Magnetism = 8, Fortune = 6, Level = 10 },
                new Character { CharacterId = 4, Name = "Larry", Bio = "Brian made this guy and he is a stupid idiot", Might = 1, Spryness = 6, Judgement = 6, Echo = 8, Magnetism = 9, Fortune = 15, Level = 2 },
                new Character { CharacterId = 5, Name = "Robert Smith", Bio = "Brian made this guy and he is a stupid idiot", Might = 4, Spryness = 44, Judgement = 1, Echo = 44, Magnetism = 44, Fortune = 1, Level = 5 },
                new Character { CharacterId = 6, Name = "Farts", Bio = "Brian made this guy and he is a stupid idiot", Might = 9, Spryness = 9, Judgement = 15, Echo = 1, Magnetism = 8, Fortune = 6, Level = 9 },
                new Character { CharacterId = 7, Name = "Cuck Fucker", Bio = "Brian made this guy and he is a stupid idiot", Might = 6, Spryness = 19, Judgement = 19, Echo = 8, Magnetism = 9, Fortune = 15, Level = 2 },
                new Character { CharacterId = 8, Name = "Wage cuck", Bio = "Brian made this guy and he is a stupid idiot", Might = 400, Spryness = 15, Judgement = 1, Echo = 15, Magnetism = 15, Fortune = 1, Level = 5 },
                new Character { CharacterId = 9, Name = "Orc", Bio = "Brian made this guy and he is a stupid idiot", Might = 55, Spryness = 6, Judgement = 15, Echo = 1, Magnetism = 8, Fortune = 16, Level = 6 },
                new Character { CharacterId = 10, Name = "Elf", Bio = "Brian made this guy and he is a stupid idiot", Might = 16, Spryness = 6, Judgement = 6, Echo = 8, Magnetism = 6, Fortune = 15, Level = 2 },
                new Character { CharacterId = 21, Name = "Boy", Bio = "Brian made this guy and he is a stupid idiot", Might = 90, Spryness = 90, Judgement = 1, Echo = 90, Magnetism = 90, Fortune = 1, Level = 5 },
                new Character { CharacterId = 31, Name = "Gnome", Bio = "Hail Stan", Might = 666, Spryness = 666, Judgement = 666, Echo = 666, Magnetism = 666, Fortune = 666, Level = 666 }
              );
        }
    }
}