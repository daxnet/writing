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

namespace Writing.Tools.Paragraphs
{
    [Extension("{0038CB50-38FD-4867-A0B0-BBDF2EE3D9A7}", "Unordered List Tool")]
    public sealed class UnorderedListTool : ButtonTool
    {
        public override Image ToolIconSmall => Resources.UnorderedList_16;

        public override Image ToolIconLarge => Resources.UnorderedList_32;

        public override string ToolName => "Unordered List";

        public override int OrderingIndex => 0;

        public override bool IsFocusedTool => true;

        public override ToolGroup ToolGroup => ToolGroup.Paragraphs;

        public override Task ExecuteAsync(IWritingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
