namespace MinimalAPI.EndpointFilters
{
    public class CustomEndpointFilter : IEndpointFilter
    {
        private readonly ILogger<CustomEndpointFilter> _logger;


        public CustomEndpointFilter(ILogger<CustomEndpointFilter> logger)
        {
            _logger = logger;
        }

        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            //Before logic
            _logger.LogInformation("Endpoint filter _ before logic");



          var result = await next(context); 
          // It invoks the subsequent filter or endpoint's request delegate


            //After logic
            _logger.LogInformation("Endpoint filter _ after logic");
            return result;
        }
    }
}
