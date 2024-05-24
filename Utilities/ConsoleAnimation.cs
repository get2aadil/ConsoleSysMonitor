// Provides methods to display a console animation while performing tasks.

using System;
using System.Threading;

namespace MyPlayGround.Utilities
{
    public static class ConsoleAnimation
    {
        private static bool _isRunning;
        private static Thread _animationThread;

        /// <summary>
        /// Starts the console animation with a given message.
        /// </summary>
        /// <param name="message">The message to display alongside the animation.</param>
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

        /// <summary>
        /// Stops the console animation.
        /// </summary>
        public static void StopAnimation()
        {
            _isRunning = false;
            _animationThread.Join();
        }
    }
}
