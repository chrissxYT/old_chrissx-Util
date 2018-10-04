using chrissx_Util.Code;
using chrissx_Util.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace chrissx_Util.Threading
{
    public class ProcessManager : IEnumerable<Process>, IDisposable
    {
        /// <summary>
        /// The running processes
        /// </summary>
        private List<Process> processes = new List<Process>();

        /// <summary>
        /// Saving the names in format Dictionary<name, id>
        /// </summary>
        private Dictionary<string, int> names = new Dictionary<string, int>();

        public int Capacity
        {
            get
            {
                return processes.Capacity;
            }
            set
            {
                processes.Capacity = value;
            }
        }

        /// <summary>
        /// chrissx' ProcessManager
        /// </summary>
        /// <param name="max">The max number of processes</param>
        public ProcessManager(int max)
        {
            processes.Capacity = max;
        }

        /// <summary>
        /// Kompiliert den Code und startet die Executable als neuen Prozess
        /// </summary>
        /// <param name="assemblys">The assemblies that are needed for the compilation of the program</param>
        /// <param name="code">The C#-SourceCode</param>
        /// <param name="version">The compiler-version to use.</param>
        /// <param name="name">The name of the process</param>
        /// <returns>The index of the process</returns>
        public int StartThread(string[] assemblys, string code, string version, string name)
        {
            string temp = FileUtil.TempFile;
            CodeUtil.Compile(assemblys, temp, code, version);
            processes.Add(Process.Start(temp));
            names.Add(name, processes.Count - 1);
            return processes.Count - 1;
        }

        /// <summary>
        /// Stops the process
        /// </summary>
        /// <param name="index">The index of the process</param>
        public void StopThread(int index)
        {
            processes[index].Kill();
            processes[index] = null;
        }

        /// <summary>
        /// Gets the id of the process
        /// </summary>
        /// <param name="name">The name of the process</param>
        /// <returns>The id of the process</returns>
        public int GetId(string name)
        {
            if (names.TryGetValue(name, out int id))
                return id;
            else
                return -1;
        }

        /// <summary>
        /// Stops the process
        /// </summary>
        /// <param name="name">The name of the process</param>
        public void StopThread(string name)
        {
            StopThread(GetId(name));
        }

        public IEnumerator<Process> GetEnumerator()
        {
            return processes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return processes.GetEnumerator();
        }

        public void Dispose()
        {
            processes.Clear();
            names.Clear();
        }
    }
}
