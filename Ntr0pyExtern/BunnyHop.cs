using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ntr0pyExtern
{
    class BunnyHop
    {

        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetAsyncKeyState(int vKey);

        private int fJump = 0;
        private int LocalPlayer = 0;
        private int JumpAddress = 0;
        public bool running = false;

        public BunnyHop(int Base)
        {
            fJump = Base + Oofsettz.flagsAddress;
            int LocalPlayerAddress = Base + Oofsettz.localPlayerOffset;
            LocalPlayer = MemUtility.mem.ReadInt32((IntPtr)LocalPlayerAddress);
            JumpAddress = LocalPlayer + Oofsettz.flagsOffset;
        }

        public void Start()
        {
            while (running)
            {
                Thread.Sleep(2);
                if ((GetAsyncKeyState(32) & 0x8000) > 0)
                {
                    Jump();
                }
            }
        }

        private void Jump()
        {
            MemUtility.mem.WriteInt32((IntPtr)fJump, 5);
            Thread.Sleep(2);
            MemUtility.mem.WriteInt32((IntPtr)fJump, 4);
        }

    }
}
