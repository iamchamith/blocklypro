using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlocklyPro.Code
{
    public partial class UcMoveForward : UserControl
    {
        private readonly GameRunner.GameRunner _gameRunner;
        public UcMoveForward(GameRunner.GameRunner gameRunner)
        {
            _gameRunner = gameRunner;
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _gameRunner.RemoveItem(this);
        }
        public void HighlightsFontColor()
        {
            label1.ForeColor = Color.Red;
        }

        public void ResetFontColor()
        {
            label1.ForeColor = Color.Black;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In computer programming, a statement is a syntactic unit of an imperative programming language that expresses some action to be carried out. A program written in such a language is formed by a sequence of one or more statements. A statement may have internal components (e.g., expressions).", "Statement");
        }

        public int GetStepCount()
        {
            return Convert.ToInt32(txtSteps.Value);
        }
    }
}
