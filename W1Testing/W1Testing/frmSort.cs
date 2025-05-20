using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1Testing
{
    public partial class frmSort : Form
    {
        public frmSort()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //generate a random array as specified by these inputs
            int[] iarrOriginalArray = GenerateRandomArray(1000, 1, 10000);

            //create 2 coppies of the random array by our sorting algortuthisn
            int[] irrBubble = (int[])iarrOriginalArray.Clone();
            int[] irrSelection = (int[])iarrOriginalArray.Clone();

        }


        // create a function to generate an array with a random number of elements between specified min and max
        private int[] GenerateRandomArray(int iSize, int iMin, int iMax)
        {
            //set up a random object so we can get random numbers
            Random random = new Random();

            //set up an array with the size specified when this function is called
            int[] iarrRandomNumbers = new int[iSize];

            //fill our array with random numbers
            for (int i = 0; i < iSize; i++)
            {
                // generate a random number between the specified min and max and assign that random number to the current elements in the array
                iarrRandomNumbers[i] = random.Next(iMin, iMax);
            }

            //retunr our array with teh random numbers
            return iarrRandomNumbers;
        }
    }
}
