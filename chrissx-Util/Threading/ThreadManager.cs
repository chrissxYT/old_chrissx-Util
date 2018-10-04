using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace chrissx_Util.Threading
{
    public class ThreadManager : IEnumerable<Thread>, IDisposable
    {
        /// <summary>
        /// The threads that are running
        /// </summary>
        private volatile List<Thread> threads = new List<Thread>();

        /// <summary>
        /// Get or set the rate at which the dead threads will be removed
        /// </summary>
        public int PollingRate
        {
            get
            {
                return poll_rate;
            }
            set
            {
                poll_rate = value;
            }
        }

        /// <summary>
        /// Private and thread proof version of PollingRate
        /// </summary>
        private volatile int poll_rate;

        /// <summary>
        /// The thread to check for dead threads
        /// </summary>
        private volatile Thread t;

        /// <summary>
        /// chrissx' ThreadManager
        /// </summary>
        /// <param name="max">The maximum count of threads</param>
        /// <param name="polling_rate">The rate at which the dead threads will be removed</param>
        public ThreadManager(int max, int polling_rate)
        {
            threads.Capacity = max;
            PollingRate = polling_rate;
            StartChecker();
        }

        /// <summary>
        /// Just a deconstructor that disposes everything
        /// </summary>
        ~ThreadManager()
        {
            Dispose();
        }

        /// <summary>
        /// Starts the list cleaner
        /// </summary>
        private void StartChecker()
        {
            t = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        Thread.Sleep(PollingRate);
                        if(threads.RemoveAll((th) => !th.IsAlive) > 0)
                            threads.Sort();
                    }
                }
                catch { }
            })
            {
                Name = "chrissx' ThreadManager - ListUpdater",
                Priority = ThreadPriority.Highest
            };
            t.Start();
        }

        /// <summary>
        /// Stops the thread gotten through GetThread(name), with Thread.Abort.
        /// </summary>
        /// <param name="name">The name of the thread</param>
        [Obsolete("Deprecated. Thread.Abort is not safe without try/catch.", false)]
        public void StopThread(string name)
        {
            Thread ttttt = GetThread(name);
            ttttt.Abort();
            threads.Remove(ttttt);
        }

        /// <summary>
        /// Waits until the specified thread is dead.
        /// </summary>
        /// <param name="name">The thread's name</param>
        public void JoinThread(string name)
        {
            GetThread(name).Join();
        }

        /// <summary>
        /// Gets the thread specified by the name
        /// </summary>
        /// <param name="name">The thread's name</param>
        /// <returns>The thread</returns>
        public Thread GetThread(string name)
        {
            return threads.Find((Thread t) =>
            {
                return t.Name == name;
            });
        }

        /// <summary>
        /// Adds a new thread to the threads
        /// </summary>
        /// <param name="start">The code to execute</param>
        /// <param name="name">The name of the thread</param>
        public void StartThread(ThreadStart start, string name)
        {
            threads.Add(new Thread(start)
            {
                Name = name
            });
        }

        /// <summary>
        /// The enumerator of the List<Thread>
        /// </summary>
        /// <returns>The enumerator of the List<Thread></returns>
        public IEnumerator<Thread> GetEnumerator()
        {
            return threads.GetEnumerator();
        }

        /// <summary>
        /// The enumerator of the List<Thread>
        /// </summary>
        /// <returns>The enumerator of the List<Thread></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return threads.GetEnumerator();
        }

        public void Dispose()
        {
            t.Abort();
            foreach (Thread tt in threads)
                tt.Join();
        }
    }
}