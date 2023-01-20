using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microservice.Framework.Common;
using Microsoft.Extensions.DependencyInjection;

namespace Microservice.Framework.Orchestration
{
    public static class OrchestrationExtensions
    {
        public static TService GetService<TService, T>(this IOrchestrationFlow<T> orchestrationFlow)
            where T : class
        {
            if (orchestrationFlow.IsNull())
                throw new ArgumentNullException($"{typeof(OrchestrationExtensions).PrettyPrint()} : orchestrationFlow is null");

            return orchestrationFlow.ServiceProvider.GetService<TService>();
        }
    }
}
