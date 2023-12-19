using Microsoft.Extensions.DependencyInjection;
using NAccessControl.Interfaces.Facade;
using NAccessControl.Interfaces.Facade.Assembler;
using NAccessControl.Interfaces.Facade.Impl;
using NAccessControl.Service;
using NAccessControl.Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl
{
    public static class NAccessControlExtensions
    {
        public static IServiceCollection AddNAccessControl(this IServiceCollection services)
        {
            services.AddScoped<IAccessControlService, AccessControlService>(); 
            services.AddScoped<IAccessControlServiceFacade, AccessControlServiceFacade>();
            services.AddScoped<PermissionAssember>();
            services.AddScoped<ResourceAssember>();
            services.AddScoped<OwnedResourceAssembler>();
            services.AddScoped<UserIdAssembler>();
            services.AddScoped<RoleAssembler>(); 
            return services;
        }
    }
}
