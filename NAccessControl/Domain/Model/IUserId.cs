namespace NAccessControl.Domain.Model;

public interface IUserId
{
    int ToInt();

    Guid? ToGuid();
}
