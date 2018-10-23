using FormsUI.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Writing.Core.Tools
{
    public abstract class Tool : Extension
    {
        public abstract string ToolName { get; }

        public virtual string Tooltip => ToolName;

        public abstract Image ToolIcon { get; }

        public virtual ToolTab ToolTab => ToolTab.Home;

        public virtual Keys ShortcutKeys => Keys.None;
    }
}
