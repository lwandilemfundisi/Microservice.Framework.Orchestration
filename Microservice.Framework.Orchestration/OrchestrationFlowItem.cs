﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microservice.Framework.Common;

namespace Microservice.Framework.Orchestration
{
    public class OrchestrationFlowItem<T> : IOrchestrationFlowItem<T>
        where T : class
    {
        private readonly IOrchestrationFlowStep<T> _work;

        #region Constructors

        public OrchestrationFlowItem(IOrchestrationFlowStep<T> work)
        {
            _work = work;
        }

        #endregion

        #region IWorkflowItem

        public string StepName => _work.GetType().PrettyPrint();

        public async Task<OrchestrationFlowState> Execute(OrchestrationFlowControl<T> workflowContinuation, T data)
        {
            return await _work.FlowStep(workflowContinuation, data);
        }

        #endregion
    }
}
