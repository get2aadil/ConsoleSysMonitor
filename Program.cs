using MyPlayGround.Interfaces;
using MyPlayGround.Models;
using MyPlayGround.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyPlayGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Start animation for gathering processes
                ConsoleAnimation.StartAnimation("Gathering process information...");

                // Display all running processes
                var processes = Process.GetProcesses().Select(p => new MyProcess(
                    p.Id,
                    p.ProcessName,
                    null
                )).ToList();

                ConsoleAnimation.StopAnimation();
                Console.WriteLine("Process information gathered.");

                // Start animation for gathering services
                ConsoleAnimation.StartAnimation("Gathering service information...");

                // Gather all running services
                var services = ServiceController.GetServices().Select(s => new MyService(
                    s.ServiceName.GetHashCode(), // Just for simplicity using hashcode as ID
                    s.ServiceName,
                    null // No performance metrics initially
                )).ToList();

                ConsoleAnimation.StopAnimation();
                Console.WriteLine("Service information gathered.");


                Console.WriteLine("\nRunning Processes:");
                foreach (var proc in processes)
                {
                    Console.WriteLine($"Process: {proc.ProcessName} (ID: {proc.Id})");
                }

                Console.WriteLine("\nRunning Services:");
                foreach (var svc in services)
                {
                    Console.WriteLine($"Service: {svc.ServiceName} (ID: {svc.ServiceId})");
                }
                // User input for specific process details
                Console.Write("\nEnter Process ID to get performance metrics: ");
                if (int.TryParse(Console.ReadLine(), out int processId))
                {
                    var selectedProcess = processes.OfType<MyProcess>().FirstOrDefault(p => p.Id == processId);
                    if (selectedProcess != null)
                    {
                        // Start animation for gathering detailed metrics
                        ConsoleAnimation.StartAnimation("Gathering performance metrics...");

                        selectedProcess.Performance = new PerformanceMetrics(GetCpuUsage(processId), GetMemoryUsage(processId));

                        ConsoleAnimation.StopAnimation();

                        selectedProcess.ShowCpuUsage();
                        selectedProcess.ShowMemoryUsage();
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Process not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets the CPU usage of a process by its ID.
        /// </summary>
        /// <param name="processId">The ID of the process.</param>
        /// <returns>The CPU usage as a float percentage. Returns -1 if an error occurs.</returns>  
        static float GetCpuUsage(int processId)
        {
            try
            {
                using (var process = Process.GetProcessById(processId))
                using (var cpuCounter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName, true))
                {
                    // First call always returns 0, so we need to call it twice
                    cpuCounter.NextValue();
                    System.Threading.Thread.Sleep(500);
                    return cpuCounter.NextValue() / Environment.ProcessorCount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to get CPU usage for process (ID: {processId}). Error: {ex.Message}");
                return -1; // Return a sentinel value indicating failure
            }
        }

        /// <summary>
        /// Gets the memory usage of a process by its ID.
        /// </summary>
        /// <param name="processId">The ID of the process.</param>
        /// <returns>The memory usage in MB. Returns -1 if an error occurs.</returns>
        static float GetMemoryUsage(int processId)
        {
            try
            {
                using (var process = Process.GetProcessById(processId))
                using (var memCounter = new PerformanceCounter("Process", "Working Set - Private", process.ProcessName, true))
                {
                    return memCounter.NextValue() / (1024 * 1024); // Convert bytes to MB
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to get CPU usage for process (ID:  {processId}). Error: {ex.Message}");
                return -1; // Return a sentinel value indicating failure
            }
        }
    }

}
