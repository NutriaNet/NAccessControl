using NAccessControl.Domain.Model;
using NAccessControl.EFCore.Infrastructures.EntityFrameworks;
using NAccessControl.Test.Fixtures;
using System.Resources;

namespace NAccessControl.Test;

public class AccessControlTest : IClassFixture<DatabaseFixture>
{
    protected DatabaseFixture fixture;

    public AccessControlTest(DatabaseFixture fixture)
    {
        this.fixture = fixture;
    }

    [Fact]
    public async Task TestInitializeResourceAndAndPermission()
    {
        IResourceRepository repository = new ResourceRepositoryEntityFramework(fixture.CreateDbContext());

        repository.AddRange(fixture.CreateContractTableResource());
        await repository.SaveChangesAsync();

        var resources = await repository.FindAllResourcesAsync();

        Assert.Contains(resources, r => r.Key == "ContractTable");
    }

    [Fact]
    public void TestCreateRole()
    {

    }

    [Fact]
    public void TestChangeRole()
    {

    }

    [Fact]
    public void TestSaveOwnedResources()
    {

    }

    [Fact]
    public void ShouldRemoveUserOwnershipOfResourceIfNotSubmitted()
    {
    }

    [Fact]
    public async void TestGetOwnedResources()
    {
        IResourceRepository repository = new ResourceRepositoryEntityFramework(fixture.CreateDbContext()); 

        var resources = await repository.FindAllResourcesAsync();

        Assert.NotNull(resources);
    }

    [Fact]
    public async void TestCreateResources()
    {
        IResourceRepository repository = new ResourceRepositoryEntityFramework(fixture.CreateDbContext());

        repository.Add(fixture.CreateContractTableResource().First());
        await repository.SaveChangesAsync();

        var resources = await repository.FindAllResourcesAsync();
        Assert.Contains(resources, r => r.Key == "ContractTable");
    }
    
}
