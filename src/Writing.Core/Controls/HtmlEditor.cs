using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;

namespace Writing.Core.Controls
{
    public partial class HtmlEditor : UserControl
    {
        public HtmlEditor()
        {
            InitializeComponent();
            this.InitializeEditingSurface();
        }

        private void InitializeEditingSurface()
        {
            if (editingSurface.Document != null)
            {
                // Turn on the design mode
                if (editingSurface.Document.DomDocument is IHTMLDocument2 document)
                {
                    document.designMode = "On";
                }

                // Disabling the default context-menu
                editingSurface.IsWebBrowserContextMenuEnabled = false;

            }
        }
    }
}
