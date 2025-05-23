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
using Accessibility;

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
            int[] iarrOriginalArray = GenerateRandomArray(10000, 1, 100000);

            //create 2 coppies of the random array by our sorting algortuthisn
            int[] irrBubble = (int[])iarrOriginalArray.Clone();
            int[] irrSelection = (int[])iarrOriginalArray.Clone();

            Stopwatch bubbletimer = new Stopwatch();
                 
            bubbletimer.Start();

            BubbleSort(irrBubble);

            bubbletimer.Stop();

            Stopwatch selectionTimer = new Stopwatch();

            selectionTimer.Start();

            SelectionSort(irrSelection);

            selectionTimer.Stop();

            lblBubbleSort.Text = $"Bubble sort took {bubbletimer.ElapsedMilliseconds.ToString()} milliseconds";
            lblSelectionSort.Text = $"Selection sort took {selectionTimer.ElapsedMilliseconds.ToString()} milliseconds";
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

        //bubble sort function to repeaetedly compare items and bubble them to the correct spot
        private void BubbleSort(int[] iarrToSort)
        {
            int iLengthofArray = iarrToSort.Length;

            //set up the outer loop
            for (int i = 0; i < iLengthofArray; i++)
            {
                //set up the inner loop - if the current element igreater than the ret you swap
                for (int j = 0; j < iLengthofArray - i - 1; j++)
                {
                    if (iarrToSort[j] > iarrToSort[j + 1])
                    {
                        int temp = iarrToSort[j];
                        //replace the next value
                        iarrToSort[j] = iarrToSort[j + 1];

                        iarrToSort[j + 1] = temp;
                    }
                }
            }
        }

        private void SelectionSort(int[] iarrToSort)
        {
            int iLengthofArray = iarrToSort.Length;

            for (int i = 0; i <  iLengthofArray - 1; i++)
            {
                //current indexs 
                int iMinIndex = i;

                for (int j = i + 1; j < iLengthofArray; j++)
                {
                    //compare the current element with the smallest element so far
                    if (iarrToSort[j] < iarrToSort[iMinIndex])
                    {
                        //if a smaller elemnt is found, update the minindex
                        iMinIndex = j;
                    }
                }

                if (iMinIndex != 1)
                {
                    //store the current value in a temp variabble
                    int temp = iarrToSort[i];
                    //move the smaller element to the current position
                    iarrToSort[i] = iarrToSort[iMinIndex];
                    iarrToSort[iMinIndex] = temp;
                }

            }
        }
    }
}