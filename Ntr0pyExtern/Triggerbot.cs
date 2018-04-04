using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ntr0pyExtern
{
    class Triggerbot
    {

        public bool running = false;
        private int Base = 0;
        private int forceAttack = 0;

        public Triggerbot(int Base)
        {
            this.Base = Base;
            forceAttack = Base + Oofsettz.dwForceAttack;
        }

        public void Start()
        {
            while (running)
            {
                Thread.Sleep(10);
                int address = Base + Oofsettz.localPlayerOffset;
                int LocalPlayer = MemUtility.mem.ReadInt32((IntPtr)address);

                address = LocalPlayer + Oofsettz.teamNumOffset;
                int MyTeam = MemUtility.mem.ReadInt32((IntPtr)address);

                address = LocalPlayer + Oofsettz.m_iCrosshairId;
                int PlayerInCrosshair = MemUtility.mem.ReadInt32((IntPtr)address);

                if (PlayerInCrosshair > 0 && PlayerInCrosshair < 65)
                {
                    address = Base + Oofsettz.dwEntityList + (PlayerInCrosshair - 1) * Oofsettz.entityLoopDistance;
                    int PtrToPIC = MemUtility.mem.ReadInt32((IntPtr)address);

                    address = PtrToPIC + Oofsettz.m_iHealth;
                    int PICHealth = MemUtility.mem.ReadInt32((IntPtr)address);

                    address = PtrToPIC + Oofsettz.teamNumOffset;
                    int PICTeam = MemUtility.mem.ReadInt32((IntPtr)address);

                    if ((PICTeam != MyTeam) && (PICTeam > 1) && (PICHealth > 0))
                    {
                        // Shoot at Enemy
                        MemUtility.mem.WriteInt32((IntPtr)forceAttack, 1);
                        Thread.Sleep(1);
                        MemUtility.mem.WriteInt32((IntPtr)forceAttack, 4);
                    }
                }
            }
        }

    }
}
