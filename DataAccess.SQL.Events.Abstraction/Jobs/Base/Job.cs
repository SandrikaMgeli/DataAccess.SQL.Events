using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DataAccess.SQL.Events.Abstraction.Jobs.Base;

public abstract class Job : BackgroundService
{
    private readonly ILogger _logger;
    private readonly TimeSpan _jobExecutionDelay;
    private readonly Type _jobType;

    protected Job(
        ILogger logger,
        TimeSpan jobExecutionDelay)
    {
        _logger = logger;
        _jobExecutionDelay = jobExecutionDelay;
        _jobType = this.GetType();
    }

    protected abstract Task InvokeAsync(CancellationToken stoppingToken);

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                await InvokeAsync(CancellationToken.None);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception caught in {job} with message: {message}",  _jobType.Name, ex.Message);
            }
            finally
            {
                await Task.Delay(_jobExecutionDelay, CancellationToken.None);
            }
        }
    }
}