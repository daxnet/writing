using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing.Core.Tools
{
    public sealed class ToolTab
    {
        public static readonly ToolTab Home = new ToolTab(new Guid("{DB641925-A26F-4D80-8B75-0E559400B1EF}"), "Home", 0);
        public static readonly ToolTab View = new ToolTab(new Guid("{18CD3CD9-9C3E-4D9B-A3C7-6A9F97790CFC}"), "View", 1);
        public static readonly ToolTab Help = new ToolTab(new Guid("{8D8AF810-8BE9-43DC-A126-CCDB4A578325}"), "Help", 2);

        public static readonly ToolTab[] PredefinedTabs = new ToolTab[]
        {
            Home, View, Help
        };

        private ToolTab(Guid id, string name, int orderingIndex)
            : this(id, name, name.Substring(0, 1), orderingIndex)
        { }

        private ToolTab(Guid id, string name, string keyTip, int orderingIndex)
        {
            Id = id;
            Name = name;
            KeyTip = keyTip;
            OrderingIndex = orderingIndex;
        }

        public Guid Id { get; }

        public string Name { get; }

        public string KeyTip { get; }

        public int OrderingIndex { get; }

        public override string ToString() => Name;

        public override bool Equals(object obj)
        {
            var tab = obj as ToolTab;
            return tab != null &&
                   Id.Equals(tab.Id) &&
                   Name == tab.Name &&
                   KeyTip == tab.KeyTip &&
                   OrderingIndex == tab.OrderingIndex;
        }

        public override int GetHashCode()
        {
            var hashCode = 339177246;
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(KeyTip);
            hashCode = hashCode * -1521134295 + OrderingIndex.GetHashCode();
            return hashCode;
        }

        public static implicit operator string(ToolTab toolTab) => toolTab.Name;

        public static implicit operator ToolTab(string tabName) => PredefinedTabs.FirstOrDefault(pdt => pdt.Name.Equals(tabName));
    }
}
