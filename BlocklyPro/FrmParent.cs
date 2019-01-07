using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlocklyPro.GameCreator;

namespace BlocklyPro
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        private void cREATEAGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createAGame = new Workbench();
            createAGame.MdiParent = this;
            createAGame.Show();
        }

        private void pLAYAGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameRunner = new GameRunner.GameRunner();
            gameRunner.MdiParent = this;
            gameRunner.Show();
        }
    }
}
