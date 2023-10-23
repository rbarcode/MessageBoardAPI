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

  // GET: api/messages?groupId=
  [HttpGet]
  public async Task<List<Message>> Get(int groupId)
  {
    return await _db.Messages
                            .Where(entry => entry.GroupId == groupId)
                            .Include(message => message.Group)
                            .Include(message => message.User)
                            .ToListAsync();
  }

  // GET: api/messages/{id}
  [HttpGet("{id}")]
  public async Task<ActionResult<Message>> GetMessage(int id)
  {
    Message message = await _db.Messages
                                        .Include(message => message.Group)
                                        .Include(message => message.User)
                                        .FirstOrDefaultAsync(message => message.MessageId == id);

    if (message == null)
    {
      return NotFound();
    }

    return message;
  }

  // POST: api/messages
  [HttpPost]
  public async Task<ActionResult<Message>> Post(Message message)
  {
    _db.Messages.Add(message); // our Messages table only has fields for Id's, the User and Group objects are Model properties that define the relationship in our program, but not in our database
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(GetMessage), new { id = message.MessageId }, message);
  }
}









