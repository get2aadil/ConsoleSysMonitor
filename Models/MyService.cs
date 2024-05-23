using MyPlayGround.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlayGround.Models
{
    public class MyService : IPerformanceMetricsDisplay
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public PerformanceMetrics Performance { get; set; }

        public MyService(int serviceId, string serviceName, PerformanceMetrics performance)
        {
            ServiceId = serviceId;
            ServiceName = serviceName;
            Performance = performance;
        }

        public void ShowCpuUsage()
        {
            Console.WriteLine($"Service: {ServiceName} (ID: {ServiceId}), CPU Usage: {Performance.CpuUsage}%");
        }

        public void ShowMemoryUsage()
        {
            Console.WriteLine($"Service: {ServiceName} (ID: {ServiceId}), Memory Usage: {Performance.MemoryUsage} MB");
        }
    }
}
