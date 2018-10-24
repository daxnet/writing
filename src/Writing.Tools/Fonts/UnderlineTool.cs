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
    [Extension("{FAA5CC3D-11AF-4D54-992A-EB3A0A2FEDA3}", "Underline Tool")]
    public sealed class UnderlineTool : ButtonTool
    {
        public override Image ToolIconSmall => Resources.Underline_16;

        public override Image ToolIconLarge => Resources.Underline_32;

        public override string ToolName => "Underline";

        public override ToolGroup ToolGroup => ToolGroup.Fonts;

        public override Task ExecuteAsync(IWritingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
