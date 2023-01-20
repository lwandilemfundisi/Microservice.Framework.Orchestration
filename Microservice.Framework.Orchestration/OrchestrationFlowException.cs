using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Framework.Orchestration
{
    public class OrchestrationFlowException : Exception
    {
        #region Constructors

        public OrchestrationFlowException()
            : base()
        {
        }

        public OrchestrationFlowException(string? message)
            : base(message)
        {
        }

        public OrchestrationFlowException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }

        public OrchestrationFlowException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}
