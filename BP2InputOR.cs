using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BackPropagation
{
    public partial class BP2InputOR : Form
    {
        NeuralNet nn;
        int inputSize = 2;
        int outputSize = 1;
        int[,] dataSet;
        public BP2InputOR()
        {
            InitializeComponent();
            dataSet = new int[4, 3] {
                { 0, 0, 0 },
                { 0, 1, 1 },
                { 1, 0, 1 },
                { 1, 1, 1 }
            };

        }

        private void BP2InputOR_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner).Dispose();
        }

        private void btnCreateNN_Click(object sender, EventArgs e)
        {
            CreateNN();
        }

        private void CreateNN()
        {
            nn = new NeuralNet(inputSize, 100, outputSize);
            lblStatus.Text = "Neural Network successfully created.";
        }

        private void btnTrainNN_Click(object sender, EventArgs e)
        {
            if (nn == null)
            {
                CreateNN();
            }

            for (int i = 0; i < 100; i++)
            {
                trainNN();
            }
        }

        private void trainNN()
        {
            for (int i = 0; i < Math.Pow(2, inputSize); i++)
            {
                for (int j = 0; j < inputSize; j++)
                {
                    nn.setInputs(j, dataSet[i, j]);
                }

                nn.setDesiredOutput(0, dataSet[i, inputSize]);
                nn.learn();
            }
        }

        private void btnTestNN_Click(object sender, EventArgs e)
        {
            if (nn == null)
            {
                lblStatus.Text = "Neural Network not found.";
                return;
            }

            if (tbInput0.Text == "" || tbInput1.Text == "")
            {
                lblStatus.Text = "Invalid inputs.";
                return;
            }

            nn.setInputs(0, Convert.ToDouble(tbInput0.Text));
            nn.setInputs(1, Convert.ToDouble(tbInput1.Text));
            nn.run();

            tbOutput.Text = "" + nn.getOuputData(0);
        }

        private void inputANDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (this.Owner).Show();
            this.Hide();
        }
    }
}
