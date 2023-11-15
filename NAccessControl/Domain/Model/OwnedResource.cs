using System.ComponentModel.DataAnnotations;

namespace NAccessControl.Domain.Model;

public class OwnedResource
{

    [Key]
    public int Id { get; set; }

    public UserId UserId { get; set; }

    public Resource Resource { get; set; }

    public ICollection<Permission> Permissions { get; set; }
}
