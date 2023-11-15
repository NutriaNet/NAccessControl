using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Domain.Model;

public class Resource
{
    public IList<Permission> Permissions { get; set; }
}
