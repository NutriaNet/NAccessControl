using System.ComponentModel.DataAnnotations.Schema;

namespace NAccessControl.Domain.Model;

public class Resource
{
    public int Id { get; set; }

    public string Key { get; set; }

    public string Name { get; set; }

    public int ParentId { get; set; }

    [NotMapped]
    public ICollection<Resource> Children { get; }

    public ICollection<Permission> Permissions { get; set; }

    public Resource() { }

    public Resource(string key, string name, ICollection<Permission> permissions)
    {
        Key = key;
        Name = name;
        Permissions = permissions;
        Children = new List<Resource>();
    }

    public void AddChild(Resource resource)
    {
        Children.Add(resource);
        resource.ParentId = Id;
    }
}
