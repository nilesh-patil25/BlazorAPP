namespace BlazorFullStackCrud.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<SuperHero>().HasData(
                new SuperHero
                {
                    Id = 1,
                    Name = "Peter",
                    Line1 = "abc",
                    Line2 = "def",
                    Locality = "ghi",
                    Region ="jkl",
                    Country = "mno",
                    Longitude = 12,
                    Latitude = 11,
                    Contact = "123",
                    //ContactId = ,
                    CreatedAtUtc= DateTime.UtcNow,
                    UpdatedAtUtc= DateTime.UtcNow,
                    DeletedAtUtc= DateTime.UtcNow,
                    Email = "pqrs",
                    Salt = "tuvw",
                    Password = "xyz"

                }
               
            );
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }

        public DbSet<Comic> Comics { get; set; }
    }
}
