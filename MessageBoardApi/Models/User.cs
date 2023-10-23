using System.ComponentModel.DataAnnotations;

namespace MessageBoardApi.Models
{
  public class User
  {
    public int UserId { get; set; }

    public string Name { get; set; }

  }
}