namespace BlocklyPro.GameRunner
{
    partial class GameRunner
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbGames = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sTATEMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONDITIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fUNCTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadGame = new System.Windows.Forms.ToolStripButton();
            this.btnPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.codeCore = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lnkRefresh = new System.Windows.Forms.LinkLabel();
            this.toolStrip1.SuspendLayout();
            this.codeCore.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.cmbGames,
            this.toolStripDropDownButton1,
            this.btnLoadGame,
            this.btnPlay,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbGames
            // 
            this.cmbGames.Name = "cmbGames";
            this.cmbGames.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTATEMENTToolStripMenuItem,
            this.cONDITIONToolStripMenuItem,
            this.fUNCTIONToolStripMenuItem,
            this.lOOPToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::BlocklyPro.Properties.Resources.code;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // sTATEMENTToolStripMenuItem
            // 
            this.sTATEMENTToolStripMenuItem.Name = "sTATEMENTToolStripMenuItem";
            this.sTATEMENTToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.sTATEMENTToolStripMenuItem.Text = "STATEMENT";
            this.sTATEMENTToolStripMenuItem.Click += new System.EventHandler(this.sTATEMENTToolStripMenuItem_Click);
            // 
            // cONDITIONToolStripMenuItem
            // 
            this.cONDITIONToolStripMenuItem.Name = "cONDITIONToolStripMenuItem";
            this.cONDITIONToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.cONDITIONToolStripMenuItem.Text = "CONDITION";
            this.cONDITIONToolStripMenuItem.Click += new System.EventHandler(this.cONDITIONToolStripMenuItem_Click);
            // 
            // fUNCTIONToolStripMenuItem
            // 
            this.fUNCTIONToolStripMenuItem.Enabled = false;
            this.fUNCTIONToolStripMenuItem.Name = "fUNCTIONToolStripMenuItem";
            this.fUNCTIONToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.fUNCTIONToolStripMenuItem.Text = "FUNCTION";
            // 
            // lOOPToolStripMenuItem
            // 
            this.lOOPToolStripMenuItem.Enabled = false;
            this.lOOPToolStripMenuItem.Name = "lOOPToolStripMenuItem";
            this.lOOPToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.lOOPToolStripMenuItem.Text = "LOOP";
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadGame.Image = global::BlocklyPro.Properties.Resources.load;
            this.btnLoadGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(23, 22);
            this.btnLoadGame.Text = "toolStripButton1";
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlay.Image = global::BlocklyPro.Properties.Resources.play;
            this.btnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(23, 22);
            this.btnPlay.Text = "toolStripButton1";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::BlocklyPro.Properties.Resources.reset;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // codeCore
            // 
            this.codeCore.Controls.Add(this.lnkRefresh);
            this.codeCore.Dock = System.Windows.Forms.DockStyle.Right;
            this.codeCore.Location = new System.Drawing.Point(698, 25);
            this.codeCore.Name = "codeCore";
            this.codeCore.Size = new System.Drawing.Size(306, 508);
            this.codeCore.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.AutoSize = true;
            this.lnkRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRefresh.Location = new System.Drawing.Point(238, 9);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(65, 13);
            this.lnkRefresh.TabIndex = 0;
            this.lnkRefresh.TabStop = true;
            this.lnkRefresh.Text = "REFRESH";
            this.lnkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefresh_LinkClicked);
            // 
            // GameRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlocklyPro.Properties.Resources.grid;
            this.ClientSize = new System.Drawing.Size(1004, 533);
            this.Controls.Add(this.codeCore);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GameRunner";
            this.Text = "GAME RUNNER";
            this.Load += new System.EventHandler(this.GameRunner_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.codeCore.ResumeLayout(false);
            this.codeCore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cmbGames;
        private System.Windows.Forms.ToolStripButton btnLoadGame;
        private System.Windows.Forms.ToolStripButton btnPlay;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem sTATEMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONDITIONToolStripMenuItem;
        private System.Windows.Forms.Panel codeCore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fUNCTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOOPToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkRefresh;
    }
}