using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ntr0pyExtern
{
    class CheatBase
    {

        // Initializing Hacks
        private MemUtility MemUtil = new MemUtility();

        private BunnyHop bhop = new BunnyHop(MemUtility.ClientBase);
        private ESPGlow espGlow = new ESPGlow(MemUtility.ClientBase);
        private Triggerbot triggerbot = new Triggerbot(MemUtility.ClientBase);
        

        public CheatBase()
        {
            
        }

        public void SetBhop(bool state)
        {
            bhop.running = state;
            if (state)
            {
                StartBunnyHop();
            }
        }

        public void SetESPGlow(bool state)
        {
            espGlow.running = state;
            if (state)
            {
                StartESPGlow();
            }
        }

        // still in development
        public void SetNoRecoil(bool state)
        {

        }

        public void SetTriggerBot(bool state)
        {
            triggerbot.running = state;
            if (state)
            {
                StartTriggerbot();
            }
        }

        private void StartBunnyHop()
        {
            new Thread(new ThreadStart(bhop.Start)).Start();
        }
        private void StartESPGlow()
        {
            new Thread(new ThreadStart(espGlow.Start)).Start();
        }
        private void StartTriggerbot()
        {
            new Thread(new ThreadStart(triggerbot.Start)).Start();
        }

        // still in development
        private void StartNoRecoil()
        {

        }

        public void SetESPGlowMode(string mode)
        {
            switch (mode)
            {
                case "healthGlow":
                    espGlow.glowHealth = true;
                    espGlow.glowAllPlayers = false;
                    break;
                case "allPlayers":
                    espGlow.glowAllPlayers = true;
                    espGlow.glowHealth = false;
                    break;
                case "healthGlowAllPlayers":
                    espGlow.glowAllPlayers = true;
                    espGlow.glowHealth = true;
                    break;
                case "default":
                    espGlow.glowAllPlayers = false;
                    espGlow.glowHealth = false;
                    break;
                default:
                    espGlow.glowAllPlayers = false;
                    espGlow.glowHealth = false;
                    break;
            }

        }
    }
}
