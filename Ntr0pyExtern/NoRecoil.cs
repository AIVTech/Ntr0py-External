using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntr0pyExtern
{
    class NoRecoil
    {
        private struct Vector
        {
            public float x;
            public float y;
            public float z;
        }

        public bool running = false;
        private int Base = 0;

        public NoRecoil(int Base)
        {
            this.Base = Base;
        }

        public void Start()
        {
            int pShotsFired;
            Vector CurrentViewAngles;
            Vector vPunch;
            Vector NewViewAngles;
            Vector OldAimPunch;
            OldAimPunch.x = OldAimPunch.y = OldAimPunch.z = 0;

            while (running)
            {
                
            }
        }
    }
}
