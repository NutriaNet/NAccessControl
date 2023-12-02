namespace NAccessControl.Domain.Model;

public class Permission
{
    public int Id { get; set; }

    public string Key { get; set; }

    public string Name { get; set; }

    public ICollection<Resource> Resources { get; set; }

    public ICollection<OwnedResource> OwnedResources { get; set; }

    public Permission() { }

    public Permission(string key, string name)
    {
        Key = key;
        Name = name;
    }
}
