using Xunit;
using Microsoft.AspNetCore.Http;

public class TransactionObservabilityTests
{
    [Fact]
    public async Task CorrelationIdIsAddedToResponse()
    {
        var context = new DefaultHttpContext();
        var middleware = new CorrelationIdMiddleware((innerContext) =>
        {
            return Task.CompletedTask;
        });

        await middleware.Invoke(context);

        Assert.True(context.Response.Headers.ContainsKey("X-Correlation-ID"));
    }
}
