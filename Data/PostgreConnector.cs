using SwaggerRMQEx.Data;
using Microsoft.EntityFrameworkCore;

namespace SwaggerRMQEx
{
    public class PostgreConnector : DbContext
    {
        private readonly string Host = "localhost";
        private readonly string Port = "5432";
        private readonly string DBname = "dvdrental";
        private readonly string User = "postgres";
        private readonly string Password = "495k14f9";
        public PostgreConnector(DbContextOptions<PostgreConnector> options) : base(options)
        { }

        public PostgreConnector()
        {
            Database.EnsureCreated();
        }

        public DbSet<ActorEntity> ActorList { get; set; }
        public DbSet<AddressEntity> AddressList { get; set; }
        public DbSet<CategoryEntity> CategoryList { get; set; }
        public DbSet<CityEntity> CityList { get; set; }
        public DbSet<CountryEntity> CountryList { get; set; }
        public DbSet<CustomerEntity> CustomerList { get; set; }
        public DbSet<FilmEntity> FilmList { get; set; }
        public DbSet<FilmActorEntity> FilmActorList { get; set; }
        public DbSet<FilmCategoryEntity> FilmCategoryList { get; set; }
        public DbSet<InvestoryEntity> InvestoryList { get; set; }
        public DbSet<LanguageEntity> LanguageList { get; set; }
        public DbSet<PaymentEntity> PaymentList { get; set; }
        public DbSet<RentalEntity> RentalList { get; set; }
        public DbSet<StaffEntity> StaffList { get; set; }
        public DbSet<StoreEntity> StoreList { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ActorEntity>().HasKey(x => x.ActorId);
            builder.Entity<AddressEntity>().HasKey(x => x.AddressId);
            builder.Entity<CategoryEntity>().HasKey(x => x.CategoryId);
            builder.Entity<CityEntity>().HasKey(x => x.CityId);
            builder.Entity<CountryEntity>().HasKey(x => x.CountryId);
            builder.Entity<CustomerEntity>().HasKey(x => x.CustomerId);
            builder.Entity<FilmEntity>().HasKey(x => x.FilmId);
            builder.Entity<FilmActorEntity>().HasKey(x => new { x.ActorId, x.FilmId});
            builder.Entity<FilmCategoryEntity>().HasKey(x => x.CategoryId);
            builder.Entity<InvestoryEntity>().HasKey(x => x.InvestoryId);
            builder.Entity<LanguageEntity>().HasKey(x => x.LanguageId);
            builder.Entity<PaymentEntity>().HasKey(x => x.PaymentId);
            builder.Entity<RentalEntity>().HasKey(x => x.RentalId);
            builder.Entity<StaffEntity>().HasKey(x => x.StaffId);
            builder.Entity<StoreEntity>().HasKey(x => x.StoreId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(
            $"Host={Host};" +
            $"Port={Port};" +
            $"Database={DBname};" +
            $"Username={User};" +
            $"Password={Password}");

    }
}
