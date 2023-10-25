using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MessageBoardApi.Models
{
  public class MessageBoardApiContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Message> Messages { get; set; }
    public DbSet<Group> Groups { get; set; }
    // public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<GroupUser> GroupUsers { get; set; }

    public MessageBoardApiContext(DbContextOptions<MessageBoardApiContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Group>()
        .HasData(
          new Group { GroupId = 1, Name = "Spider-Man" },
          new Group { GroupId = 2, Name = "Witcher" },
          new Group { GroupId = 3, Name = "Costumes" }
        );

      builder.Entity<Message>()
        .HasData(
          new Message { MessageId = 1, Text = "This new Spider-Man game looks awesome!", GroupId = 1, UserId = "def456", Date = new DateTime(2022, 12, 08, 8, 15, 0) },
          new Message { MessageId = 2, Text = "What did ya'll get for candy? I got rocks.", GroupId = 3, UserId = "abc123", Date = new DateTime(2023, 3, 21, 6, 30, 0) },
          new Message { MessageId = 3, Text = "I hate Ciri!", GroupId = 2, UserId = "ghi789", Date = new DateTime(2020, 5, 13, 8, 11, 0) }
        );

      var hasher = new PasswordHasher<IdentityUser>();

      builder.Entity<ApplicationUser>()
        .HasData(
          new ApplicationUser { Id = "abc123", UserName = "Joey", NormalizedUserName = "JOEY", PasswordHash = hasher.HashPassword(null, "IAmGroot"), Email = "test1@test.com", NormalizedEmail = "TEST1@TEST.COM" },
          new ApplicationUser { Id = "def456", UserName = "Richard", NormalizedUserName = "RICHARD", PasswordHash = hasher.HashPassword(null, "IAmGroot"), Email = "test2@test.com", NormalizedEmail = "TEST2@TEST.COM" },
          new ApplicationUser { Id = "ghi789", UserName = "Onur", NormalizedUserName = "ONUR", PasswordHash = hasher.HashPassword(null, "IAmGroot"), Email = "test3@test.com", NormalizedEmail = "TEST3@TEST.COM" }
        );

      builder.Entity<GroupUser>()
        .HasData(
          new GroupUser { GroupUserId = 1, UserId = "def456", GroupId = 1 },
          new GroupUser { GroupUserId = 2, UserId = "abc123", GroupId = 3 },
          new GroupUser { GroupUserId = 3, UserId = "ghi789", GroupId = 2 },
          new GroupUser { GroupUserId = 4, UserId = "def456", GroupId = 2 },
          new GroupUser { GroupUserId = 5, UserId = "abc123", GroupId = 2 }
        );

      base.OnModelCreating(builder);
    }

  }
}