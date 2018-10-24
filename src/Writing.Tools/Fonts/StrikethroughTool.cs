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
    [Extension("{2C867C24-31CC-4CD4-8DE0-0E3DEB970950}", "Strikethrough Tool")]
    public sealed class StrikethroughTool : ButtonTool
    {
        public override Image ToolIconSmall => Resources.Strikethrough_16;

        public override Image ToolIconLarge => Resources.Strikethrough_32;

        public override string ToolName => "Strikethrough";

        public override ToolGroup ToolGroup => ToolGroup.Fonts;

        public override Task ExecuteAsync(IWritingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
