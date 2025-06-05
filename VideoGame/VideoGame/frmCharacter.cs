namespace VideoGame
{
    public partial class frmCharacter : Form
    {
        public frmCharacter()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Character newCharacter = new Character(5, "Boone", 100, 10);


        }
    }
}
