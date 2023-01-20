using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Framework.Orchestration
{
    public class OrchestrationFlowControl<T> where T : class
    {
        private readonly IOrchestrationFlow<T> _flow;

        #region Constructors

        public OrchestrationFlowControl(IOrchestrationFlow<T> flow)
        {
            _flow = flow;
            FlowState = FlowStates.Of().Continue;
        }

        #endregion

        #region Properties

        public IOrchestrationFlow<T> Flow { get { return _flow; } }

        public OrchestrationFlowState FlowState { get; set; }

        public int FlowStep { get; set; }

        public string StateMessage { get; set; }

        #endregion
    }
}
