using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing.Core.Tools
{
    public abstract class DropdownTool : Tool
    {
        public sealed override ToolType ToolType => ToolType.Dropdown;
    }
}
