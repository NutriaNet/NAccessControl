using NAccessControl.Domain.Model;
using NAccessControl.EFCore.Infrastructures.EntityFrameworks;

namespace NAccessControl.Test;

public class AccessControlTest
{
    [Fact]
    public async Task TestInitializeResouceAndAndPromission()
    {
        var read = new Permission("Read", "Read");
        var edit = new Permission("Edit", "Edit");
        var readData = new Permission("ReadData", "Read data");
        var editData = new Permission("EditData", "Edit data");
        var use = new Permission("User", "User");

        var allTablePermissions = new List<Permission>() { read, edit };

        var contract = new Resource("ContractTable", "Contract", allTablePermissions);

        var name = new Resource("NameColumn", "Contract name", allTablePermissions);

        contract.AddChild(name);

        IResourceRepository repository = new ResourceRepositoryEntityFramework(null);

        repository.Add(contract);
        repository.Add(name);
        await repository.SaveChangesAsync();

        var resources = await repository.FindAllResourceAsync();
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
    public void TestGetOwnedResources()
    {

    }
}
