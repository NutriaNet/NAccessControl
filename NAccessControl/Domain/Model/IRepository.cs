namespace NAccessControl.Domain.Model;

public interface IRepository<T>
{
    void Add(T permission);

    Task AddAsync(T permission);

    void AddRange(IEnumerable<T> permissions);

    Task AddRangeAsync(IEnumerable<T> permissions);

    Task<int> SaveChangesAsync();
}
