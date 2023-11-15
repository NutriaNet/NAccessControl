namespace NAccessControl.Domain.Model;

public class Resource
{
    public int Id { get; set; }

    public IList<Permission> Permissions { get; set; }
}
