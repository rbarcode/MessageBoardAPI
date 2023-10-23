using System.ComponentModel.DataAnnotations;

namespace MessageBoardApi.Models
{
  public class Message
  {
    public int MessageId { get; set; }

    public string Text { get; set; }

  }
}