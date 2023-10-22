using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DemoCustomHealtCheck;

public class MyHealthCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        var isValid =  Random.Shared.Next(0, 100) % 2 == 0;
        
        if(isValid) 
            return Task.FromResult(HealthCheckResult.Healthy());
        
        return Task.FromResult(HealthCheckResult.Unhealthy());
    }
}
