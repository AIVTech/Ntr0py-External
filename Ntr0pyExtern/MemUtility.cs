using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntr0pyExtern
{
    class MemUtility
    {
        public static VAMemory mem = null;
        public static int ClientBase = 0;
        public static int EngineBase = 0;

        public MemUtility()
        {
            mem = new VAMemory("csgo");
            ClientBase = GetModuleBase("client.dll");
            EngineBase = GetModuleBase("engine.dll");
        }

        private int GetModuleBase(string czModuleName)
        {
            try
            {
                Process[] p = Process.GetProcessesByName("csgo");
                if (p.Length > 0)
                {
                    foreach (ProcessModule m in p[0].Modules)
                    {
                        if (m.ModuleName == "client.dll")
                        {
                            return (int)m.BaseAddress;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return 0;
            }
            return 0;
        }
    }
}
