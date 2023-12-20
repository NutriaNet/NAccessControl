using Microsoft.AspNetCore.Mvc;
using NAccessControl.Interfaces.Facade.Command;
using NAccessControl.Interfaces.Facade.Dto;
using NAccessControl.Interfaces.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAccessControl.Domain.Model;

namespace NAccessControl.Interfaces.Controllers
{
    [ApiController]
    [Route("api/access-controls")]
    public class AccessControlsController : BaseController
    {
        protected readonly IAccessControlServiceFacade accessControlServiceFacade;

        public AccessControlsController(IAccessControlServiceFacade accessControlServiceFacade)
        {
            this.accessControlServiceFacade = accessControlServiceFacade;
        }

        [HttpGet("/list")]
        public async Task<IEnumerable<OwnedResourceDTO>> GetList()
        { 
            return await accessControlServiceFacade.FindOwnedResourcesAsync(new FindOwnedResourcesCommand() { UserId = base.GetUserId() });
        }
    }
}
