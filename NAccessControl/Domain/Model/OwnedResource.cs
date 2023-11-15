namespace NAccessControl.Domain.Model;

public class OwnedResource
{

    public Resource Resource { get; set; }

    public ICollection<Permission> Permissions { get; set; }
}
