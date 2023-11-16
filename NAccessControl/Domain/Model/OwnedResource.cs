namespace NAccessControl.Domain.Model;

public class OwnedResource
{
    public int Id { get; set; }

    public Role Role { get; set; }

    public int RoleId { get; set; }

    public UserId? UserId { get; set; }

    public Resource Resource { get; set; }

    public ICollection<Permission> Permissions { get; set; }
}
