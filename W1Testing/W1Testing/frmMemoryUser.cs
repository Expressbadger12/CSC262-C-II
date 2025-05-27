using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1Testing
{
    public partial class frmMemoryUser : Form
    {
        public frmMemoryUser()
        {
            InitializeComponent();
        }

        private void btnUseMemory_Click(object sender, EventArgs e)
        {
            //remove items from list box
            lsbData.Items.Clear();

            //the watch will let us time how long the code takes to run
            Stopwatch watch = new Stopwatch();

            watch.Start();

            List<string> data = GenerateLotsOfData(100000);
            List<string> results = new List<string>();

            //loop for each lines of data in the the large data
            foreach(string line in data)
            {
                string process = WasteMoreTime(line);
                
                results.Add(process);

                lsbData.Items.Add(process);
            }

            watch.Stop();

            lblTimeTaken.Text = $"Time waste: {watch.ElapsedMilliseconds} ms";


            //fekay si we cba see titns ubt tge kustvjx
            Thread.Sleep(1000);

            lsbData.Items.Clear();

            GC.Collect();

            GC.WaitForPendingFinalizers();

            GC.Collect();

            //make a request ti tge gargvage nab ti ckeab yi iys    dest
        }

        //this function exists just to create large amounts of data
        private List<string> GenerateLotsOfData(int iSize)
        {
            //create a string list with the number of records determined by the integer
            List<string> data = new List<string>(iSize);

            for (int i = 0; i < iSize; i++)

            {
                data.Add(new string('A', 10000) + "this is a lot of characters");
            }
            //return the much data
            return data;
        }

        private string WasteMoreTime(string line) 
        { 
            //create a string buikder ti waste more time
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i<1000; i++)
            {
                builder.Append(line[0] + " " + line[1] + " " + line[2]);
            }
            return builder.ToString().Substring(0, 1);
        }

    }
}
