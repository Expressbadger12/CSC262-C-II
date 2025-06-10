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
            int health = int.Parse(txtHealth.Text);
            int attack = int.Parse(txtAttack.Text);
            int defense = int.Parse(txtDefense.Text);

            Character newCharacter = new Character(attack, name, health, defense);

            //show the character's info in the list box
            lbCharacters.Items.Add(newCharacter.DisplayInfo());
        }
    }
}
