using System.Windows.Forms;

namespace BlocklyPro.Code
{
    public partial class UcFunction : UserControl
    {
        public UcFunction()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("A function is a unit of code that is often defined by its role within a greater code structure. Specifically, a function contains a unit of code that works on various inputs, many of which are variables, and produces concrete results involving changes to variable values or actual operations based on the inputs.","Function");
        }
    }
}
