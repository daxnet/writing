using FormsUI.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Writing.Core;
using Writing.Core.Tools;
using Writing.Tools.Properties;

namespace Writing.Tools.Fonts
{
    [Extension("{A2AD14BD-2347-4727-80C6-0E49FBF4EE70}", "Bold Tool")]
    public sealed class BoldTool : ButtonTool
    {
        public override string ToolName => "Bold";

        public override Image ToolIconSmall => Resources.Bold_16;

        public override ToolGroup ToolGroup => ToolGroup.Fonts;

        public override Image ToolIconLarge => Resources.Bold_32;

        public override string ToolTip => "Sets the selected text in bold style.";

        public override int OrderingIndex => 0;

        public override bool IsFocusedTool => true;

        public override Task ExecuteAsync(IWritingContext context)
        {
            if (!context.Document.Focused)
            {
                context.Document.Focus();
            }

            context.Document.ExecCommand("Bold", false, null);
            return Task.CompletedTask;
        }
    }
}
