
namespace MessageBoardApi.Models
{
  public class Group
  {
    public int GroupId { get; set; }
    public string Name { get; set; }

    public List<Message> Messages { get; set; } // One to Many

    public List<GroupUser> JoinEntities { get; } // collection navigation property - Many to Many.
  }
}