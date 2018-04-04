using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntr0pyExtern
{
    public partial class CheatWindow : Form
    {

        private CheatBase cheat = null;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public CheatWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cheat = new CheatBase();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void bunnyhopCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (bunnyhopCbx.Checked)
            {
                // Turn Auto-BunnyHop On
                cheat.SetBhop(true);
            }
            else
            {
                // Turn Auto-BunnyHop Off
                cheat.SetBhop(false);
            }
        }

        private void espGlowCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (espGlowCbx.Checked)
            {
                // Turn ESP Glow On
                cheat.SetESPGlow(true);
            }
            else
            {
                // Turn ESP Glow Off
                cheat.SetESPGlow(false);
            }
        }

        private void noRecoilCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (noRecoilCbx.Checked)
            {
                // Turn No Recoil On
            }
            else
            {
                // Turn No Recoil Off
            }
        }

        private void triggerbotCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerbotCbx.Checked)
            {
                // Turn TriggerBot On
                cheat.SetTriggerBot(true);
            }
            else
            {
                // Turn TriggerBot Off
                cheat.SetTriggerBot(false);
            }
        }
    }
}
