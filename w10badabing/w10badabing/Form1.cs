using System.Data.SQLite;

namespace w10badabing
{
    public partial class frmsqllite : Form
    {
        //name of the database
        private string databaseName = "TestDatabase.db";

        public frmsqllite()
        {
            InitializeComponent();
        }

        // function to create database and table if it doesn't already exist
        private void CreateDatabase()
        {
            //check to see if the database file exists; if the file does not exist, create it
            if (!File.Exists(databaseName))
            {
                //create the sqlite database
                SQLiteConnection.CreateFile(databaseName);
                //just for proof of concept -- remove before moving this function to a utility class (ie database helper)
                MessageBox.Show("Database created!");


                //open a connection to the database and create a new table
                using (SQLiteConnection sqliteconn = new SQLiteConnection($"Data Source={databaseName};Version=3;"))
                {
                    //open a connection to the sqlite database that we just created
                    sqliteconn.Open();

                    //sete up the create table query
                    string createTableQuery = "CREATE TABLE tblPerson(ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT NOT NULL, Age INTEGER);";
               
                    using(SQLiteCommand cmd = new SQLiteCommand(createTableQuery, sqliteconn))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Table Created!");
                    }
                }
            }
        }

        private void frmsqllite_Load(object sender, EventArgs e)
        {

        }
    }
}
