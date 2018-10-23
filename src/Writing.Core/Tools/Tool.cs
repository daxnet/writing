using FormsUI.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Writing.Core.Properties;

namespace Writing.Core.Tools
{
    public abstract class Tool : Extension
    {
        public abstract string ToolName { get; }

        public virtual string Tooltip => ToolName;

        public abstract Image ToolIcon { get; }

        public virtual ToolTab ToolTab => ToolTab.Home;

        public abstract ToolGroup ToolGroup { get; }

        public virtual Keys ShortcutKeys => Keys.None;

        public override string Description => ToolName;

        public override string Manufacturer => Resources.Manufacturer;

        public virtual int OrderingIndex => 0;

        public virtual ToolType ToolType => ToolType.Button;

        public abstract Task ExecuteAsync(IWritingContext context);
    }
}
