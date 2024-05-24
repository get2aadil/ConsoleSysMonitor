// Represents a system service with basic information and performance metrics.

using MyPlayGround.Interfaces;
using System;

namespace MyPlayGround.Models
{
    public class MyService : IPerformanceMetricsDisplay
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public PerformanceMetrics Performance { get; set; }

        /// <summary>
        /// Initializes a new instance of the MyService class.
        /// </summary>
        /// <param name="serviceId">The service ID.</param>
        /// <param name="serviceName">The name of the service.</param>
        /// <param name="performance">The performance metrics of the service.</param>
        public MyService(int serviceId, string serviceName, PerformanceMetrics performance)
        {
            ServiceId = serviceId;
            ServiceName = serviceName;
            Performance = performance;
        }

        /// <summary>
        /// Displays the CPU usage of the service.
        /// </summary>
        public void ShowCpuUsage()
        {
            Console.WriteLine($"Service: {ServiceName} (ID: {ServiceId}), CPU Usage: {Performance.CpuUsage}%");
        }

        /// <summary>
        /// Displays the memory usage of the service.
        /// </summary>
        public void ShowMemoryUsage()
        {
            Console.WriteLine($"Service: {ServiceName} (ID: {ServiceId}), Memory Usage: {Performance.MemoryUsage} MB");
        }
    }
}
