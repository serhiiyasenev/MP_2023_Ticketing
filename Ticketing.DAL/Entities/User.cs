using Ticketing.DAL.Enums;

namespace Ticketing.DAL.Entities;

public sealed class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? PasswordHash { get; set; }
    public string? Salt { get; set; }
    public UserRole UserRole { get; set; }
    public List<Ticket> Tickets { get; set; }
}