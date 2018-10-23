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
using Writing.Core.Tools;

namespace writing
{
    public partial class FrmMain : KryptonForm
    {
        private readonly ExtensionManager extensionManager;

        public FrmMain(ExtensionManager extensionManager)
            : this()
        {
            this.extensionManager = extensionManager;
            InitializeTools();
        }

        private FrmMain() => InitializeComponent();

        private void InitializeTools()
        {
            ribbonMenu.RibbonTabs.Clear();
            var tools = extensionManager.GetExtensions<Tool>().ToList();
            var toolsGroupedByTabs = from tool in tools
                                     group tool by tool.ToolTab into toolTabGroup
                                     orderby toolTabGroup.Key.OrderingIndex
                                     select toolTabGroup;
            
            foreach(var toolGroupingTabDefinition in toolsGroupedByTabs)
            {
                var ribbonTab = new KryptonRibbonTab
                {
                    Text = toolGroupingTabDefinition.Key.Name,
                    KeyTip = toolGroupingTabDefinition.Key.KeyTip
                };

                ribbonMenu.RibbonTabs.Add(ribbonTab);

                var toolsGroupedByGroup = from tool in toolGroupingTabDefinition
                                          group tool by tool.ToolGroup into toolGroup
                                          orderby toolGroup.Key.OrderingIndex
                                          select toolGroup;

                foreach(var toolGroupingDefinition in toolsGroupedByGroup)
                {
                    var ribbonGroup = new KryptonRibbonGroup
                    {
                        TextLine1 = toolGroupingDefinition.Key.Name
                    };

                    var toolContainer = new KryptonRibbonGroupLines { MaximumSize = GroupItemSize.Small };

                    foreach (var tool in toolGroupingDefinition.OrderBy(t=>t.OrderingIndex))
                    {
                        switch (tool.ToolType)
                        {
                            case ToolType.Button:
                                toolContainer.Items.Add(new KryptonRibbonGroupButton { TextLine1 = tool.Name, ImageSmall = tool.ToolIcon });
                                break;
                            case ToolType.Dropdown:
                                toolContainer.Items.Add(new KryptonRibbonGroupComboBox());
                                break;
                        }
                    }

                    ribbonGroup.Items.Add(toolContainer);

                    ribbonTab.Groups.Add(ribbonGroup);
                }
            }
        }
    }
}
