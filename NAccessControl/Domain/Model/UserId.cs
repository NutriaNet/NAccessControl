namespace NAccessControl.Domain.Model;

/// <summary>
/// WARN: 使用 Guid 会导致数据库查询不到
/// </summary>
public class UserId : IUserId
{
    public int Id { get; }

    public string? StringValueId { get; }

    public Guid? GuidValueId { get; }

    public bool IsValidated { get; }

    public UserId() { }

    public UserId(int? id)
    {
        Id = id ?? 0;
        IsValidated = Id != 0;
    }

    public UserId(string? id)
    {
        StringValueId = id;
        IsValidated = !string.IsNullOrEmpty(id);
    }

    public UserId(Guid id)
    {
        GuidValueId = id;
        IsValidated = id != Guid.Empty;
    }

    public int ToInt()
    {
        return Id;
    }

    public Guid? ToGuid()
    {
        return GuidValueId;
    }

    public override string ToString()
    {
        return StringValueId ?? "";
    }
}
