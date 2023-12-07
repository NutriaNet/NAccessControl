using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Interfaces.Facade.Command
{
    public class CreateResourceCommand
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }

        public string? ParentKey { get; set; }
    }
}
