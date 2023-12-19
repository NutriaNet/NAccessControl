using NAccessControl.Domain.Model;
using NAccessControl.EFCore.Infrastructures.EntityFrameworks;
using NAccessControl.Interfaces.Facade;
using NAccessControl.Interfaces.Facade.Assembler;
using NAccessControl.Interfaces.Facade.Impl;
using NAccessControl.Service;
using NAccessControl.Service.Impl;
using NAccessControl.Test.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Test
{
    public class AccessControlServiceFacadeTest : IClassFixture<DatabaseFixture>
    {
        protected DatabaseFixture fixture;
        protected IAccessControlServiceFacade facade;
        public AccessControlServiceFacadeTest(DatabaseFixture fixture)
        {
            this.fixture = fixture;
            IResourceRepository repository = new ResourceRepositoryEntityFramework(fixture.CreateDbContext());
            IAccessControlService service = new AccessControlService(repository);
            PermissionAssember permissionAssember = new PermissionAssember();
            ResourceAssember resourceAssember = new ResourceAssember(permissionAssember);
            RoleAssembler roleAssembler = new RoleAssembler();
            OwnedResourceAssembler ownedResourceAssembler = new OwnedResourceAssembler(resourceAssember, permissionAssember, roleAssembler);
            UserIdAssembler userIdAssembler = new UserIdAssembler();
            facade = new AccessControlServiceFacade(service, resourceAssember, ownedResourceAssembler, userIdAssembler);
        }

        [Fact]
        public async void TestCreateResources()
        {
            var resources = await facade.FindAllResourcesAsync();
        }

        [Fact]
        public async void TestFindOwnedResourcesAsync()
        {
            var resources = await facade.FindOwnedResourcesAsync(new Interfaces.Facade.Command.FindOwnedResourcesCommand() { UserId = 1 });
            //Assert.True(resources.Any()); 
        }
    }
}
