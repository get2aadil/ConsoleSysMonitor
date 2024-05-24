// Represents a generic performance metrics (CPU and memory usage) for a system entity.

namespace MyPlayGround.Models
{
    public class PerformanceMetrics
    {
        public float CpuUsage { get; set; }
        public float MemoryUsage { get; set; }

        /// <summary>
        /// Initializes a new instance of the PerformanceMetrics class.
        /// </summary>
        /// <param name="cpuUsage">The CPU usage as a percentage.</param>
        /// <param name="memoryUsage">The memory usage in MB.</param>
        public PerformanceMetrics(float cpuUsage, float memoryUsage)
        {
            CpuUsage = cpuUsage;
            MemoryUsage = memoryUsage;
        }
    }
}
