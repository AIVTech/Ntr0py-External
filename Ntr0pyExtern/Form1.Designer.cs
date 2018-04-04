namespace Ntr0pyExtern
{
    partial class CheatWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitBtn = new System.Windows.Forms.Button();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.windowTitle = new System.Windows.Forms.Label();
            this.menuTitle = new System.Windows.Forms.Label();
            this.bunnyhopCbx = new System.Windows.Forms.CheckBox();
            this.espGlowCbx = new System.Windows.Forms.CheckBox();
            this.noRecoilCbx = new System.Windows.Forms.CheckBox();
            this.triggerbotCbx = new System.Windows.Forms.CheckBox();
            this.dragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Gray;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitBtn.Location = new System.Drawing.Point(1250, 1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(57, 47);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dragPanel
            // 
            this.dragPanel.Controls.Add(this.windowTitle);
            this.dragPanel.Location = new System.Drawing.Point(0, 1);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(1111, 65);
            this.dragPanel.TabIndex = 2;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // windowTitle
            // 
            this.windowTitle.AutoSize = true;
            this.windowTitle.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.windowTitle.Location = new System.Drawing.Point(3, 8);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(146, 24);
            this.windowTitle.TabIndex = 0;
            this.windowTitle.Text = "Ntr0py External";
            // 
            // menuTitle
            // 
            this.menuTitle.AutoSize = true;
            this.menuTitle.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuTitle.Location = new System.Drawing.Point(494, 148);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(275, 64);
            this.menuTitle.TabIndex = 3;
            this.menuTitle.Text = "Ntr0py Menu";
            // 
            // bunnyhopCbx
            // 
            this.bunnyhopCbx.AutoSize = true;
            this.bunnyhopCbx.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunnyhopCbx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunnyhopCbx.Location = new System.Drawing.Point(93, 310);
            this.bunnyhopCbx.Name = "bunnyhopCbx";
            this.bunnyhopCbx.Size = new System.Drawing.Size(216, 41);
            this.bunnyhopCbx.TabIndex = 4;
            this.bunnyhopCbx.Text = "Auto B Hoops";
            this.bunnyhopCbx.UseVisualStyleBackColor = true;
            this.bunnyhopCbx.CheckedChanged += new System.EventHandler(this.bunnyhopCbx_CheckedChanged);
            // 
            // espGlowCbx
            // 
            this.espGlowCbx.AutoSize = true;
            this.espGlowCbx.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espGlowCbx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.espGlowCbx.Location = new System.Drawing.Point(93, 405);
            this.espGlowCbx.Name = "espGlowCbx";
            this.espGlowCbx.Size = new System.Drawing.Size(166, 41);
            this.espGlowCbx.TabIndex = 5;
            this.espGlowCbx.Text = "ESP Glow";
            this.espGlowCbx.UseVisualStyleBackColor = true;
            this.espGlowCbx.CheckedChanged += new System.EventHandler(this.espGlowCbx_CheckedChanged);
            // 
            // noRecoilCbx
            // 
            this.noRecoilCbx.AutoSize = true;
            this.noRecoilCbx.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRecoilCbx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.noRecoilCbx.Location = new System.Drawing.Point(93, 497);
            this.noRecoilCbx.Name = "noRecoilCbx";
            this.noRecoilCbx.Size = new System.Drawing.Size(498, 41);
            this.noRecoilCbx.TabIndex = 6;
            this.noRecoilCbx.Text = "Remove Recoil (Still in Development)";
            this.noRecoilCbx.UseVisualStyleBackColor = true;
            this.noRecoilCbx.CheckedChanged += new System.EventHandler(this.noRecoilCbx_CheckedChanged);
            // 
            // triggerbotCbx
            // 
            this.triggerbotCbx.AutoSize = true;
            this.triggerbotCbx.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triggerbotCbx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.triggerbotCbx.Location = new System.Drawing.Point(93, 584);
            this.triggerbotCbx.Name = "triggerbotCbx";
            this.triggerbotCbx.Size = new System.Drawing.Size(173, 41);
            this.triggerbotCbx.TabIndex = 7;
            this.triggerbotCbx.Text = "Triggerbot";
            this.triggerbotCbx.UseVisualStyleBackColor = true;
            this.triggerbotCbx.CheckedChanged += new System.EventHandler(this.triggerbotCbx_CheckedChanged);
            // 
            // CheatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1307, 898);
            this.Controls.Add(this.triggerbotCbx);
            this.Controls.Add(this.noRecoilCbx);
            this.Controls.Add(this.espGlowCbx);
            this.Controls.Add(this.bunnyhopCbx);
            this.Controls.Add(this.menuTitle);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheatWindow";
            this.Text = "Ntr0py External";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.CheckBox bunnyhopCbx;
        private System.Windows.Forms.CheckBox espGlowCbx;
        private System.Windows.Forms.CheckBox noRecoilCbx;
        private System.Windows.Forms.CheckBox triggerbotCbx;
    }
}

