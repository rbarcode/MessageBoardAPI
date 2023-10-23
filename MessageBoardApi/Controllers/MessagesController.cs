using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;



namespace MessageBoardApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MessagesController : ControllerBase
{
  private readonly MessageBoardApiContext _db;

  public MessagesController(MessageBoardApiContext db)
  {
    _db = db;
  }

  [HttpGet]
  public async Task<List<Message>> Get(int groupId)
  {
    return await _db.Messages
                            .Where(entry => entry.GroupId == groupId)
                            .Include(message => message.Group)
                            .Include(message => message.User)
                            .ToListAsync();
  }
}




