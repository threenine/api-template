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
            _logger.Information($"Handling {typeof(TRequest).Name}");
            Type myType = request.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                object propValue = prop.GetValue(request, null);
                _logger.Information("{Property} : {@Value}", prop.Name, propValue);
            }
            var response = await next();
            //FilterResponse
            _logger.Information($"Handled {typeof(TResponse).Name}");
            return response;
        }
    }

}