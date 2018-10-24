using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Toolkit;
using FormsUI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing.Core.Tools
{
    public sealed class ToolsManager : Component
    {
        private readonly IWritingContext writingContext;
        private readonly List<KryptonRibbonGroupItem> toolStrips = new List<KryptonRibbonGroupItem>();
        private readonly ExtensionManager extensionManager;

        public ToolsManager(ExtensionManager extensionManager, IWritingContext writingContext)
        {
            this.extensionManager = extensionManager;
            this.writingContext = writingContext;
        }

        public void InitializeRibbonTools(KryptonRibbon ribbon)
        {
            ribbon.RibbonTabs.Clear();
            var tools = extensionManager.GetExtensions<Tool>().ToList();
            var toolsGroupedByTabs = from tool in tools
                                     group tool by tool.ToolTab into toolTabGroup
                                     orderby toolTabGroup.Key.OrderingIndex
                                     select toolTabGroup;

            foreach (var toolGroupingTabDefinition in toolsGroupedByTabs)
            {
                var ribbonTab = new KryptonRibbonTab
                {
                    Text = toolGroupingTabDefinition.Key.Name,
                    KeyTip = toolGroupingTabDefinition.Key.KeyTip
                };

                ribbon.RibbonTabs.Add(ribbonTab);

                var toolsGroupedByGroup = from tool in toolGroupingTabDefinition
                                          group tool by tool.ToolGroup into toolGroup
                                          orderby toolGroup.Key.OrderingIndex
                                          select toolGroup;

                foreach (var toolGroupingDefinition in toolsGroupedByGroup)
                {
                    var ribbonGroup = new KryptonRibbonGroup
                    {
                        TextLine1 = toolGroupingDefinition.Key.Name
                    };

                    var toolContainerTriple = new KryptonRibbonGroupTriple();
                    var toolContainerLines = new KryptonRibbonGroupLines { MaximumSize = GroupItemSize.Large };

                    foreach (var tool in toolGroupingDefinition.OrderBy(t => t.OrderingIndex))
                    {
                        switch (tool)
                        {
                            case ButtonTool buttonTool:
                                var button = new KryptonRibbonGroupButton
                                {
                                    TextLine1 = buttonTool.ToolName,
                                    ImageSmall = buttonTool.ToolIconSmall,
                                    ImageLarge = buttonTool.ToolIconLarge,
                                    ToolTipStyle = LabelStyle.ToolTip,
                                    ToolTipTitle = buttonTool.ToolTip,
                                    Tag = buttonTool
                                };

                                button.Click += Button_Click;

                                if (buttonTool.IsFocusedTool)
                                {
                                    var splittedTexts = buttonTool.ToolName.Split(' ', '-');
                                    if (splittedTexts.Length == 2)
                                    {
                                        button.TextLine1 = splittedTexts[0];
                                        button.TextLine2 = splittedTexts[1];
                                    }
                                    else
                                    {
                                        button.TextLine1 = buttonTool.ToolName;
                                    }

                                    toolContainerTriple.Items.Add(button);
                                }
                                else
                                {
                                    toolContainerLines.Items.Add(button);
                                }

                                toolStrips.Add(button);

                                break;
                            case DropdownTool dropDownTool:
                                var dropDown = new KryptonRibbonGroupComboBox();
                                toolContainerLines.Items.Add(dropDown);
                                break;
                        }
                    }

                    if (toolContainerTriple.Items.Any())
                    {
                        ribbonGroup.Items.Add(toolContainerTriple);
                    }

                    if (toolContainerLines.Items.Any())
                    {
                        ribbonGroup.Items.Add(toolContainerLines);
                    }

                    ribbonTab.Groups.Add(ribbonGroup);
                }
            }
        }

        private async void Button_Click(object sender, EventArgs e)
        {
            var target = (KryptonRibbonGroupButton)sender;
            var buttonTool = target.Tag as ButtonTool;
            await buttonTool?.ExecuteAsync(writingContext);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                foreach (var strip in toolStrips)
                {
                    switch(strip)
                    {
                        case KryptonRibbonGroupButton button:
                            button.Click -= Button_Click;
                            break;
                    }
                }
            }

            base.Dispose(disposing);
        }
    }
}
