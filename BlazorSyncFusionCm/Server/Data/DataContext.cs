using BlazorSyncFusionCm.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorSyncFusionCm.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;DataBase=KazimAliCrm;trusted_Connection=true;trustservercertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 11,
                    FirstName = "Amir",
                    LastName = "Ahmadi",
                    NickName = "Joe",
                    Place = "Tab",
                    DateOfBirth = new DateTime(2022, 12, 06),
                    DateCreated = DateTime.Now,
                },
                new Contact
                {
                    Id = 12,
                    FirstName = "Amir2",
                    LastName = "Ahmadi",
                    NickName = "Joe",
                    Place = "Tab",
                    DateOfBirth = new DateTime(2022, 12, 06),
                    DateCreated = DateTime.Now,
                },
                new Contact
                {
                    Id = 13,
                    FirstName = "Amir3",
                    LastName = "Ahmadi",
                    NickName = "Joe",
                    Place = "Tab",
                    DateOfBirth = new DateTime(2022, 12, 06),
                    DateCreated = DateTime.Now,
                },
                new Contact
                {
                    Id = 14,
                    FirstName = "Amir4",
                    LastName = "Ahmadi",
                    NickName = "Joe",
                    Place = "Tab",
                    DateOfBirth = new DateTime(2022, 12, 06),
                    DateCreated = DateTime.Now,
                },
                new Contact
                {
                    Id = 15,
                    FirstName = "Amir5",
                    LastName = "Ahmadi",
                    NickName = "Joe",
                    Place = "Tab",
                    DateOfBirth = new DateTime(2022, 12, 06),
                    DateCreated = DateTime.Now,
                },
                new Contact
                {
                    Id = 16,
                    FirstName = "Amir6",
                    LastName = "Ahmadi",
                    NickName = "Joe",
                    Place = "Tab",
                    DateOfBirth = new DateTime(2022, 12, 06),
                    DateCreated = DateTime.Now,
                }
                );
            modelBuilder.Entity<Note>().HasData(

                new Note { Id = 1, ContactId = 1, Text = "Am" },
                new Note { Id = 2, ContactId = 2, Text = "Am" },
                new Note { Id = 3, ContactId = 3, Text = "Am" }
                );
        }
        public DbSet<Contact>contacts { get; set; }
        public DbSet<Note> Nots { get; set; }

    }
}
