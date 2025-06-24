namespace VideoGame
{
    public partial class frmCharacter : Form
    {
        public frmCharacter()
        {
            InitializeComponent();
        }

        //Note: I was brainstorming with Ozzy for the warrior attributes. If his looks like mine then he's a dirty cheater : ) Just kidding. All code is our own. Great minds think alike.

        private void btnCreateWiz_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int health = (int)nudHealth.Value;
            int attack = (int)nudAttack.Value;
            int defense = (int)nudDefense.Value;
            int mana = (int)nudMana.Value;
            int magic = (int)nudMagic.Value;

            Wizard newWizard = new Wizard(attack, name, health, defense, mana, magic);

            //show the character's info in the list box
            lbCharacters.Items.Add(newWizard.DisplayInfo());
        }

        private void btnCreateWar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int health = (int)nudHealth.Value;
            int attack = (int)nudAttack.Value;
            int defense = (int)nudDefense.Value;
            int armor = (int)nudArmor.Value;
            string weapon = txtWeapon.Text;

            Warrior newWarrior = new Warrior(attack, name, health, defense, weapon, armor);

            //show the character's info in the list box
            lbCharacters.Items.Add(newWarrior.DisplayInfo());
        }
    }
}
