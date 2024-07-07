namespace MvvmApp.Core.Infrastructure.Application
{
    public record ApplicationExecutionState();
    public static class ApplicationExecutionStates
    {
        public static ApplicationExecutionState NotRunning { get; } = new();
        public static ApplicationExecutionState Running { get; } = new();
    }
}
