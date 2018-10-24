using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Writing.Core
{
    public interface IWritingContext
    {
        string Text { get; }

        HtmlDocument Document { get; }
    }
}
