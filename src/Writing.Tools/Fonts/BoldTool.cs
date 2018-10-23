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
    [Extension("{A2AD14BD-2347-4727-80C6-0E49FBF4EE70}", "Bold Tool")]
    public sealed class BoldTool : Tool
    {
        public override string ToolName => "Bold";

        public override Image ToolIcon => Resources.Bold;

        public override ToolGroup ToolGroup => new ToolGroup("Fonts", 0);

        public override Task ExecuteAsync(IWritingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
