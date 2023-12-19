using NAccessControl.Domain.Model;
using NAccessControl.Interfaces.Facade.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Interfaces.Facade.Assembler
{
    public class UserIdAssembler
    {
        public UserId ToEntity(FindOwnedResourcesCommand command)
        {
            return new UserId(command.UserId);
        }
    }
}
