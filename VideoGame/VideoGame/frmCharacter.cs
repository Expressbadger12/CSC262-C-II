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
            string name = txtName.Text;
            int health = (int)nudHealth.Value;
            int attack = (int)nudAttack.Value;
            int defense = (int)nudDefense.Value;

            Character newCharacter = new Character(attack, name, health, defense);

            //show the character's info in the list box
            lbCharacters.Items.Add(newCharacter.DisplayInfo());
        }
    }
}
