using FormsUI.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Writing.Core;
using Writing.Core.Tools;
using Writing.Tools.Properties;

namespace Writing.Tools.Fonts
{
    [Extension("{D21F4871-40D3-471D-8059-C25A4C04AA0E}", "Italic Tool")]
    public sealed class ItalicTool : ButtonTool
    {
        public override Image ToolIconSmall => Resources.Italic_16;

        public override Image ToolIconLarge => Resources.Italic_32;

        public override string ToolName => "Italic";

        public override ToolGroup ToolGroup => ToolGroup.Fonts;

        public override string ToolTip => "Sets the selected text in italic style.";

        public override int OrderingIndex => 10;

        public override bool IsFocusedTool => true;

        public override Task ExecuteAsync(IWritingContext context)
        {
            context.Document.ExecCommand("Italic", false, null);
            return Task.CompletedTask;
        }
    }
}
