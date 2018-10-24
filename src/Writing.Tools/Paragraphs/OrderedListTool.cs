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
    [Extension("{7DDD1C43-D133-44BC-B965-77566942600E}", "Ordered List Tool")]
    public sealed class OrderedListTool : ButtonTool
    {
        public override Image ToolIconSmall => Resources.OrderedList_16;

        public override Image ToolIconLarge => Resources.OrderedList_32;

        public override string ToolName => "Ordered List";

        public override int OrderingIndex => 10;

        public override bool IsFocusedTool => true;

        public override ToolGroup ToolGroup => ToolGroup.Paragraphs;

        public override Task ExecuteAsync(IWritingContext context)
        {
            context.Document.ExecCommand("InsertOrderedList", false, null);
            return Task.CompletedTask;
        }
    }
}
