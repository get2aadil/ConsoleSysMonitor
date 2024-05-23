using MyPlayGround.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlayGround.Models
{
    public class MyProcess : IPerformanceMetricsDisplay
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public PerformanceMetrics Performance { get; set; }

        public MyProcess(int id, string processName, PerformanceMetrics performance)
        {
            Id = id;
            ProcessName = processName;
            Performance = performance;
            
        }

        public void ShowCpuUsage()
        {
            Console.WriteLine($"Process: {ProcessName} (ID: {Id}), CPU Usage: {Performance.CpuUsage}%");
        }

        public void ShowMemoryUsage()
        {
            Console.WriteLine($"Process: {ProcessName} (ID: {Id}), Memory Usage: {Performance.MemoryUsage} MB");
        }
    }
}
