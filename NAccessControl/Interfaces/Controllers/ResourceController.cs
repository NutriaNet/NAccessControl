using Microsoft.AspNetCore.Mvc;
using NAccessControl.Interfaces.Facade;
using NAccessControl.Interfaces.Facade.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Interfaces.Controllers
{
    [Route("api/resource")]
    [ApiController]
    public class ResourceController: BaseController
    {
        protected readonly IAccessControlServiceFacade accessControlServiceFacade;

        public ResourceController(IAccessControlServiceFacade accessControlServiceFacade)
        {
            this.accessControlServiceFacade = accessControlServiceFacade;
        }

        [HttpGet("/list")]
        public async Task<IEnumerable<ResourceDTO>> FindAllResourcesAsync()
        {
            return await accessControlServiceFacade.FindAllResourcesAsync(); 
        }
    }
}
