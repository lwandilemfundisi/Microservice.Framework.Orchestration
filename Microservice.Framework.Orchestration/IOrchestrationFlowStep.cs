using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Framework.Orchestration
{
    public interface IOrchestrationFlowStep<T>
        where T : class
    {
        Func<OrchestrationFlowControl<T>, T, Task<OrchestrationFlowState>> FlowStep { get; }
    }
}
