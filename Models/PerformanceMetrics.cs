using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlayGround.Models
{
    public class PerformanceMetrics
    {
        public float CpuUsage { get; set; }
        public float MemoryUsage { get; set; }

        public PerformanceMetrics(float cpuUsage, float memoryUsage)
        {
            CpuUsage = cpuUsage;
            MemoryUsage = memoryUsage;
        }
    }
}
