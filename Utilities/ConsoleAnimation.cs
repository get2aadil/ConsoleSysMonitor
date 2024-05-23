using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyPlayGround.Utilities
{
    public static class ConsoleAnimation
    {
        private static bool _isRunning;
        private static Thread _animationThread;

        public static void StartAnimation(string message)
        {
            _isRunning = true;
            _animationThread = new Thread(() =>
            {
                int counter = 0;
                string[] sequence = { "|", "/", "-", "\\" };

                while (_isRunning)
                {
                    Console.Write($"\r{message} {sequence[counter]}");
                    counter = (counter + 1) % sequence.Length;
                    Thread.Sleep(100);
                }
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
            });
            _animationThread.Start();
        }

        public static void StopAnimation()
        {
            _isRunning = false;
            _animationThread.Join();
        }
    }
}
