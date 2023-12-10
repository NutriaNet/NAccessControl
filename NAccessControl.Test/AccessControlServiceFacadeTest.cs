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
            facade = new AccessControlServiceFacade(service, resourceAssember);
        }

        [Fact]
        public async void TestCreateResources()
        {
            var resources = await facade.FindAllResourcesAsync();
        }
    }
}
