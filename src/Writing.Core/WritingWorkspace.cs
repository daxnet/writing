using FormsUI.Workspaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Writing.Core.Models;

namespace Writing.Core
{
    public sealed class WritingWorkspace : Workspace<WritingModel>
    {
        protected override string WorkspaceFileDescription => throw new NotImplementedException();

        protected override string WorkspaceFileExtension => throw new NotImplementedException();

        protected override WritingModel Create()
        {
            throw new NotImplementedException();
        }

        protected override WritingModel OpenFromFile(string fileName)
        {
            throw new NotImplementedException();
        }

        protected override void SaveToFile(WritingModel model, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
