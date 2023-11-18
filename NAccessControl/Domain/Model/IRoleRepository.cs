namespace NAccessControl.Domain.Model;

public interface IRoleRepository : IRepository<Role>
{
    Task<IEnumerable<Role>> FindAllRolesAsync();
}
