using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Toolkit;
using FormsUI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Writing.Core;
using Writing.Core.Tools;

namespace writing
{
    public partial class FrmMain : KryptonForm, IWritingContext
    {
        private readonly ToolsManager toolsManager;
        private readonly ExtensionManager extensionManager;

        public FrmMain(ExtensionManager extensionManager)
            : this()
        {
            this.extensionManager = extensionManager;
            this.toolsManager = new ToolsManager(extensionManager, this);
            this.components.Add(toolsManager);

            this.toolsManager.InitializeRibbonTools(ribbonMenu);
        }

        private FrmMain() => InitializeComponent();

        public HtmlDocument Document => editor.HtmlDocument;
    }
}
