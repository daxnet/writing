using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing.Core.Tools
{
    public abstract class ButtonTool : Tool
    {
        public abstract Image ToolIconSmall { get; }

        public abstract Image ToolIconLarge { get; }

        public virtual bool IsFocusedTool { get; }

        public sealed override ToolType ToolType => ToolType.Button;
    }
}
