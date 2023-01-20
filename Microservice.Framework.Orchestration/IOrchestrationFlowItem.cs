using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Framework.Orchestration
{
    public interface IOrchestrationFlowItem<T> where T : class
    {
        string StepName { get; }

        Task<OrchestrationFlowState> Execute(OrchestrationFlowControl<T> flowContinuation, T data);
    }
}
