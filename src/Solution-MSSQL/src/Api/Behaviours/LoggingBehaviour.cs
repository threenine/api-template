using System.Reflection;
using MediatR;
using ILogger = Serilog.ILogger;

namespace Api.Behaviours
{
    public class LoggingBehaviour<TRequest, TResponse>(ILogger logger) : IPipelineBehavior<TRequest, TResponse>
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