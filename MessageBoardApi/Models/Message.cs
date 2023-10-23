using System.ComponentModel.DataAnnotations;

namespace MessageBoardApi.Models
{
  public class Message
  {
    public int MessageId { get; set; }

    public string Text { get; set; }

    public int GroupId { get; set; }

    public int UserId { get; set; }

    public Group Group { get; set; } // navigation property - One to Many

    public User User { get; set; } // navigation property - One to Many

  }
}