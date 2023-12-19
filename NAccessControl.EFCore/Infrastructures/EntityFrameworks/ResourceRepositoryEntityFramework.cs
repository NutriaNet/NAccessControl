using Microsoft.EntityFrameworkCore;
using NAccessControl.Domain.Model;

namespace NAccessControl.EFCore.Infrastructures.EntityFrameworks;

public class ResourceRepositoryEntityFramework : IResourceRepository
{
    protected readonly AccessControlDbContext dbContext;

    public ResourceRepositoryEntityFramework(AccessControlDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Add(Resource resource)
    {
        dbContext.Resources.Add(resource);
    }

    public Task AddAsync(Resource resource)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<Resource> resources) => dbContext.Resources.AddRange(resources);

    public void AddRangeAsync(IEnumerable<Resource> resources)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Resource>> FindAllResourcesAsync() =>
        await dbContext
            .Resources
            .Include(r => r.Permissions)
            .ToListAsync();

    public async Task<IEnumerable<OwnedResource>> FindOwnedResourcesAsync(IUserId user)
    {
        return await this.dbContext
             .OwnedResources
             .Include(r => r.UserId)
             .Include(r => r.Role)
             .Include(r => r.Resource)
             .Include(r => r.Permissions)
             .Where(c => c.UserId == user)
             .ToListAsync();
    }

    public Task<IEnumerable<OwnedResource>> FindAllOwnedResourcesAsync(Role role)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OwnedResource>> FindOwnedResourcesAsync(Role role, string parentKey)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        return dbContext.SaveChangesAsync();
    }

    Task IRepository<Resource>.AddRangeAsync(IEnumerable<Resource> permissions)
    {
        throw new NotImplementedException();
    }
}
