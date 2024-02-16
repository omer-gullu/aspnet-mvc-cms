using Cms.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.DataContext
{
  public class AppDbContext : DbContext
  {
    private readonly IConfiguration _configuration;
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
    {
      _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        var connectionString = _configuration.GetConnectionString("DBConStr");
        optionsBuilder.UseSqlServer(connectionString);
      }
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryPost> CategoryPosts { get; set; }
    public DbSet<PostImage> PostImages { get; set; }
    public DbSet<PostComment> PostComments { get; set; }
    public DbSet<Page> Pages { get; set; }
    public DbSet<Setting> Settings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<User>()
      .HasData(
      new User()
      {
        Id = 1,
        Name = "Selami",
        Surname = "Şahin",
        Phone = "05554443322",
        EMail = "selami.sahin@gmail.com",
        CitizenId = "11111111111",
        Password = "Selami.123",
        //BirthDate = (28/11/1960,dd/MM/yyyy),
        //SettingId=1
      },

      new User()
      {
        Id = 2,
        Name = "Bülent",
        Surname = "Ersoy",
        Phone = "05443332211",
        EMail = "bulente@gmail.com",
        CitizenId = "22222222222",
        Password = "Bulo.123",
        //BirthDate = (28/11/1960,dd/MM/yyyy),
        //SettingId=2
      },
      new User()
      {
        Id = 3,
        Name = "Ebru",
        Surname = "Gündeş",
        Phone = "5412227778855",
        EMail = "egundes@hotmail.com",
        CitizenId = "44444444443",
        Password = "Egun.123",
        //BirthDate = (28/11/1960,dd/MM/yyyy),
        //SettingId=3
      }
      );

      modelBuilder.Entity<Setting>()
      .HasData(
      new Setting()
      {
        Id=1,
        UserId=1,
        Description="Admin"
      },
      new Setting()
      {
        Id = 2,
        UserId = 2,
        Description = "Doctor"
      },
      new Setting()
      {
        Id = 3,
        UserId = 3,
        Description = "User"
      }
      );
    }
  }
}