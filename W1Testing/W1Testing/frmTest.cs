using System.Diagnostics;

namespace W1Testing
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private bool IsValidGamerHandle(string handle)
        {
            //if the handle is 5 characters or longer, this will return true
            return handle.Length >= 5;
        }

        private void btnTest_Click(object sender, EventArgs e) 
        {
            //get the value from teh gamer handle textbox
            string sHandle = txtHandle.Text;

            //this will return true if the handle is five characters or longer
            bool bHandleCheck = IsValidGamerHandle(sHandle);

            //Debug assert - this code will pnly run when in build debug mode
            Debug.Assert(bHandleCheck, "Game character handle must be at least five characters");

            //For testing - remove before release
            MessageBox.Show("Test Complete");
        }
    }
}
