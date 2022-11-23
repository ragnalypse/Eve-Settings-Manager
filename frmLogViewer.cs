using System.Windows.Forms;

namespace Eve_Settings_Manager
{
    public partial class frmLogViewer : Form
    {
        public frmLogViewer()
        {
            InitializeComponent();

            txtContents.Text = Program.Logger.ToString();
        }
    }
}
