using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing.Core.Tools
{
    public sealed class ToolGroup
    {
        public ToolGroup(string name, int orderingIndex)
        {
            Name = name;
            OrderingIndex = orderingIndex;
        }

        public string Name { get; }

        public int OrderingIndex { get; }

        public override string ToString() => Name;

        public override bool Equals(object obj)
        {
            var group = obj as ToolGroup;
            return group != null &&
                   Name == group.Name &&
                   OrderingIndex == group.OrderingIndex;
        }

        public override int GetHashCode()
        {
            var hashCode = -1342261939;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + OrderingIndex.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(ToolGroup a, ToolGroup b) => Equals(a, b);

        public static bool operator !=(ToolGroup a, ToolGroup b) => !(a == b);
    }
}
