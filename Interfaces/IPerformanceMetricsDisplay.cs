// Represents a system service with basic information and performance metrics.

namespace MyPlayGround.Interfaces
{
    public interface IPerformanceMetricsDisplay
    {
        void ShowCpuUsage();
        void ShowMemoryUsage();
    }
}
