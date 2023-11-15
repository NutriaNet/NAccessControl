namespace NAccessControl.Domain.Model;

public class UserId : IUserId
{
    public int Id { get; }

    public bool IsValidated { get; }

    public UserId(int? id)
    {
        Id = id ?? 0;
        IsValidated = Id != 0;
    }

    public int ToInt()
    {
        return Id;
    }

    public Guid ToGUID()
    {
        return Guid.NewGuid();
    }
}
