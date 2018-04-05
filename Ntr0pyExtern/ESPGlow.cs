using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ntr0pyExtern
{
    class ESPGlow
    {
        private struct Glow_T
        {
            public float r;
            public float g;
            public float b;
            public float a;
            public bool rwo;
            public bool rwuo;
        }

        Glow_T Team = new Glow_T()
        {
            r = 0,
            g = 1,
            b = 0,
            a = 1,
            rwo = true,
            rwuo = true
        };
        Glow_T EnemyTeam = new Glow_T()
        {
            r = 1,
            g = 0,
            b = 0,
            a = 1,
            rwo = true,
            rwuo = true
        };

        private int Base = 0;
        public bool running = false;
        public bool glowHealth = false;
        public bool glowAllPlayers = false;

        public ESPGlow(int Base)
        {
            this.Base = Base;
        }

        public void Start()
        {
            while (running)
            {
                Thread.Sleep(20);
                int i = 1;
                int address;

                do
                {
                    // Initialize Team Colors
                    EnemyTeam.r = 1;
                    EnemyTeam.g = 0;
                    EnemyTeam.b = 0;

                    Team.r = 0;
                    Team.g = 1;
                    Team.b = 0;


                    address = Base + Oofsettz.localPlayerOffset;
                    int Player = MemUtility.mem.ReadInt32((IntPtr)address);

                    address = Player + Oofsettz.teamNumOffset;
                    int MyTeam = MemUtility.mem.ReadInt32((IntPtr)address);

                    address = Base + Oofsettz.dwEntityList + (i - 1) * 0x10;
                    int EntityList = MemUtility.mem.ReadInt32((IntPtr)address);

                    address = EntityList + Oofsettz.teamNumOffset;
                    int OpponentTeam = MemUtility.mem.ReadInt32((IntPtr)address);

                    address = EntityList + Oofsettz.m_Dormant;
                    if (!MemUtility.mem.ReadBoolean((IntPtr)address))
                    {
                        address = EntityList + Oofsettz.m_iGlowIndex;
                        int GlowIndex = MemUtility.mem.ReadInt32((IntPtr)address);

                        if (glowHealth)
                        {
                            // Get Health Value
                            address = EntityList + Oofsettz.m_iHealth;
                            int health = MemUtility.mem.ReadInt32((IntPtr)address);

                            if (MyTeam != OpponentTeam)
                            {
                                // Set color to appropriate values based on health
                                if (health >= 76)
                                {
                                    EnemyTeam.r = 0;
                                    EnemyTeam.g = 1;
                                    EnemyTeam.b = 0;
                                }
                                else if (health >= 30 && health <=75)
                                {
                                    EnemyTeam.r = 1;
                                    EnemyTeam.g = 1;
                                    EnemyTeam.b = 0;
                                }
                                else
                                {
                                    EnemyTeam.r = 1;
                                    EnemyTeam.g = 0;
                                    EnemyTeam.b = 0;
                                }

                                EnableGlow(GlowIndex, EnemyTeam);
                            }
                            else
                            {
                                // If user wants to, render teammates too
                                if (glowAllPlayers)
                                {
                                    Team.r = 1;
                                    Team.g = 1;
                                    Team.b = 0;
                                    EnableGlow(GlowIndex, Team);
                                }
                            }
                        }
                        else
                        {
                            if (MyTeam == OpponentTeam)
                            {
                                if (glowAllPlayers)
                                {
                                    EnableGlow(GlowIndex, Team);
                                }
                            }
                            else
                            {
                                EnableGlow(GlowIndex, EnemyTeam);
                            }
                        }
                    }
                    i++;
                } while (i < 65);
            }
        }

        private void EnableGlow(int GlowIndex, Glow_T team)
        {
            int address = Base + Oofsettz.dwGlowObject;
            int GlowObject = MemUtility.mem.ReadInt32((IntPtr)address);

            int calculation = GlowIndex * 0x38 + 0x4;
            int current = GlowObject + calculation;
            MemUtility.mem.WriteFloat((IntPtr)current, team.r);

            calculation = GlowIndex * 0x38 + 0x8;
            current = GlowObject + calculation;
            MemUtility.mem.WriteFloat((IntPtr)current, team.g);

            calculation = GlowIndex * 0x38 + 0xC;
            current = GlowObject + calculation;
            MemUtility.mem.WriteFloat((IntPtr)current, team.b);

            calculation = GlowIndex * 0x38 + 0x10;
            current = GlowObject + calculation;
            MemUtility.mem.WriteFloat((IntPtr)current, team.a);

            calculation = GlowIndex * 0x38 + 0x24;
            current = GlowObject + calculation;
            MemUtility.mem.WriteBoolean((IntPtr)current, team.rwo);

            calculation = GlowIndex * 0x38 + 0x25;
            current = GlowObject + calculation;
            MemUtility.mem.WriteBoolean((IntPtr)current, team.rwuo);
        }
    }
}
