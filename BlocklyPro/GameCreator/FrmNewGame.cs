using System;
using System.Windows.Forms;
using BlocklyPro.Models;
using BlocklyPro.Utility;

namespace BlocklyPro.GameCreator
{
    public partial class FrmNewGame : Form
    {
        private Workbench _parentWorkbench;
        private HttpRequester _xhr;
        public FrmNewGame()
        {
            InitializeComponent();
        }
        public FrmNewGame(Workbench parentWorkbench)
        {
            InitializeComponent();
            _parentWorkbench = parentWorkbench;
            _xhr = new HttpRequester("game/create");
        }
        private async void btnAddGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                Helper.Info(message:"Please provide the game name");
            }
            if (Helper.Confirm())
            {
                var request = new Game()
                {
                    Name = txtName.Text
                };
                var result = await _xhr.Request<Game, Game>(request);
                await _parentWorkbench.LoadGames();
                this.Close();
            }
        }
    }
}
