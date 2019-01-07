using System.Windows.Forms;

namespace BlocklyPro.Code
{
    public partial class UcLoop : UserControl
    {
        public UcLoop()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Loops are used in programming to repeat a block of code until a specific condition is met. There are three loops in C programming:", "Loop");
        }
    }
}
