using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZetaResourceEditor.RuntimeBusinessLogic.Projects
{
    public class CsProjectWithFileResult
    {
        public Microsoft.Build.Evaluation.Project Project { get; set; }
        public string DependantUponRootFileName { get; set; }
    }
}
