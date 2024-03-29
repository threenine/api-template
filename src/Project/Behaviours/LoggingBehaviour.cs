using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Serilog;


namespace ApiProject.Behaviours
{
    public class LoggingBehaviour<TRequest, TResponse>(Serilog.ILogger logger) : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            //Query
            logger.Information($"Handling {typeof(TRequest).Name}");
            Type myType = request.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                object propValue = prop.GetValue(request, null);
                logger.Information("{Property} : {@Value}", prop.Name, propValue);
            }
            var response = await next();
            //FilterResponse
            logger.Information($"Handled {typeof(TResponse).Name}");
            return response;
        }
    }

}