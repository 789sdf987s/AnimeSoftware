using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace AnimeSoftware
{
    class Memory
    {
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("Kernel32.dll")]
        internal static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, UInt32 nSize, ref UInt32 lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        internal static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, IntPtr nSize, ref UInt32 lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesWritten);

        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;

        public static Process process;
        public static IntPtr pHandle;

        public static Int32 Client;
        public static Int32 ClientSize;
        public static Int32 Engine;
        public static Int32 EngineSize;



        public static bool OpenProcess(string name)
        {
            try
            {
                process = Process.GetProcessesByName(name)[0];
                return true;
            }
            catch
            {
                Console.WriteLine("Process not found.");
                return false;
            }
        }
        public static bool ProcessHandle()
        {
            try
            {
                pHandle = OpenProcess(PROCESS_VM_OPERATION | PROCESS_VM_READ | PROCESS_VM_WRITE, false, process.Id);
                return true;
            }
            catch
            {
                Console.WriteLine("Can't get handle.");
                return false;
            }
        }

        public static bool GetModules()
        {
            try
            {
                foreach (ProcessModule module in process.Modules)
                {
                    if (module.ModuleName == "client_panorama.dll")
                    {
                        Client = (Int32)module.BaseAddress;
                        ClientSize = (Int32)module.ModuleMemorySize;
                    }
                    else if (module.ModuleName == "engine.dll")
                    {
                        Engine = (Int32)module.BaseAddress;
                        EngineSize = (Int32)module.ModuleMemorySize;
                    }
                }
                if ((IntPtr)Client == IntPtr.Zero || (IntPtr)Engine == IntPtr.Zero)
                {
                    Console.WriteLine("Cant get module.");
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static T Read<T>(Int32 address)
        {
            int length = Marshal.SizeOf(typeof(T));

            if (typeof(T) == typeof(bool))
                length = 1;

            byte[] buffer = new byte[length];
            UInt32 nBytesRead = UInt32.MinValue;
            ReadProcessMemory(pHandle, (IntPtr)address, buffer, (UInt32)length, ref nBytesRead);
            return GetStructure<T>(buffer);
        }

        public static void Write<T>(Int32 address, T value)
        {
            int length = Marshal.SizeOf(typeof(T));
            byte[] buffer = new byte[length];

            IntPtr ptr = Marshal.AllocHGlobal(length);
            Marshal.StructureToPtr(value, ptr, true);
            Marshal.Copy(ptr, buffer, 0, length);
            Marshal.FreeHGlobal(ptr);

            UInt32 nBytesRead = UInt32.MinValue;
            WriteProcessMemory(pHandle, (IntPtr)address, buffer, (IntPtr)length, ref nBytesRead);
        }

        public static T GetStructure<T>(byte[] bytes)
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            var structure = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();
            return structure;
        }

        public static int FindPattern(byte[] pattern, string mask, int moduleBase, int moduleSize)
        {
            byte[] moduleBytes = new byte[moduleSize];
            uint numBytes = 0;

            if (ReadProcessMemory(Memory.pHandle, (IntPtr)moduleBase, moduleBytes, (uint)moduleSize, ref numBytes))
            {
                for (int i = 0; i < moduleSize; i++)
                {
                    bool found = true;

                    for (int l = 0; l < mask.Length; l++)
                    {
                        found = mask[l] == '?' || moduleBytes[l + i] == pattern[l];

                        if (!found)
                            break;
                    }

                    if (found)
                        return i;
                }
            }

            return 0;
        }
    }
}
