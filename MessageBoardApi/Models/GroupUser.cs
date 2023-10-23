namespace MessageBoardApi.Models
{
  public class GroupUser // Join Entity
  {
    public int GroupUserId { get; set; }
    public int GroupId { get; set; }
    public int UserId { get; set; }
    public Group Group { get; set; } // reference navigation property
    public User User { get; set; } // reference navigation property
  }
}