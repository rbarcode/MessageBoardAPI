using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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
          new Message { MessageId = 1, Text = "This new Spider-Man game looks awesome!", GroupId = 1, Id = "def456", Date = new DateTime(2022, 12, 08, 8, 15, 0) },
          new Message { MessageId = 2, Text = "What did ya'll get for candy? I got rocks.", GroupId = 3, Id = "abc123", Date = new DateTime(2023, 3, 21, 6, 30, 0) },
          new Message { MessageId = 3, Text = "I hate Ciri!", GroupId = 2, Id = "ghi789", Date = new DateTime(2020, 5, 13, 8, 11, 0) }
        );

      builder.Entity<ApplicationUser>()
        .HasData(
          new ApplicationUser { Id = "abc123", UserName = "Joey", PasswordHash = "IAmGroot" },
          new ApplicationUser { Id = "def456", UserName = "Richard", PasswordHash = "IAmGroot" },
          new ApplicationUser { Id = "ghi789", UserName = "Onur", PasswordHash = "IAmGroot" }
        );

      builder.Entity<GroupUser>()
        .HasData(
          new GroupUser { GroupUserId = 1, Id = "def456", GroupId = 1 },
          new GroupUser { GroupUserId = 2, Id = "abc123", GroupId = 3 },
          new GroupUser { GroupUserId = 3, Id = "ghi789", GroupId = 2 },
          new GroupUser { GroupUserId = 4, Id = "def456", GroupId = 2 },
          new GroupUser { GroupUserId = 5, Id = "abc123", GroupId = 2 }
        );
    }

  }
}