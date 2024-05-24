// Represents a system process with basic information and performance metrics.

using MyPlayGround.Interfaces;
using System;

namespace MyPlayGround.Models
{
    public class MyProcess : IPerformanceMetricsDisplay
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public PerformanceMetrics Performance { get; set; }

        /// <summary>
        /// Initializes a new instance of the MyProcess class.
        /// </summary>
        /// <param name="id">The process ID.</param>
        /// <param name="processName">The name of the process.</param>
        /// <param name="performance">The performance metrics of the process.</param>
        public MyProcess(int id, string processName, PerformanceMetrics performance)
        {
            Id = id;
            ProcessName = processName;
            Performance = performance;
            
        }

        /// <summary>
        /// Displays the CPU usage of the process.
        /// </summary>
        public void ShowCpuUsage()
        {
            Console.WriteLine($"Process: {ProcessName} (ID: {Id}), CPU Usage: {Performance.CpuUsage}%");
        }

        /// <summary>
        /// Displays the memory usage of the process.
        /// </summary>
        public void ShowMemoryUsage()
        {
            Console.WriteLine($"Process: {ProcessName} (ID: {Id}), Memory Usage: {Performance.MemoryUsage} MB");
        }
    }
}
