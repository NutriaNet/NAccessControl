
namespace NAccessControl.Domain.Model;

public class Role
{
    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }


    public Role() { }

    public Role(string name)
    {
        Name = name;
    }
}
