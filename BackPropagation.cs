using System.Windows.Forms;
using System.Diagnostics;
using Backprop;
using Microsoft.VisualBasic.Devices;

namespace BackPropagation
{
    public partial class BackPropagation : Form
    {
        NeuralNet nn;
        int inputSize = 4;
        int outputSize = 1;
        int hiddenNeuron;
        int min_epoch;
        int[,] dataSet;

        public BackPropagation()
        {
            InitializeComponent();
            dataSet = new int[16, 5]
            {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0 },
                { 0, 0, 1, 0, 0 },
                { 0, 0, 1, 1, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 0, 1, 0 },
                { 0, 1, 1, 0, 0 },
                { 0, 1, 1, 1, 0 },
                { 1, 0, 0, 0, 0 },
                { 1, 0, 0, 1, 0 },
                { 1, 0, 1, 0, 0 },
                { 1, 0, 1, 1, 0 },
                { 1, 1, 0, 0, 0 },
                { 1, 1, 0, 1, 0 },
                { 1, 1, 1, 0, 0 },
                { 1, 1, 1, 1, 1 }
            };
        }

        private void BackPropagation_Load(object sender, EventArgs e)
        {
            min_epoch = 10000;
        }

        private void btnCreateNN_Click(object sender, EventArgs e)
        {
            createNN();
            lblStatus.Text = "Neural Network successfully created.";
        }

        private void btnTrainNN_Click(object sender, EventArgs e)
        {
            createNN();

            for (int i = 1; i <= min_epoch; i++)
            {
                trainNN();
                double mad = testTrainNN();
                //listBox1.Items.Add("Epoch: " + i + " \nAccuracy: " + mad);

                if (mad <= 0.004)
                {
                    min_epoch = i;
                    lblMinEpoch.Text = "min epoch: " + i;
                    break;
                }
            }


        }

        private void btnTestNN_Click(object sender, EventArgs e)
        {
            if (nn == null)
            {
                lblStatus.Text = "Neural network not found.";
                return;
            }

            if (tbInput0.Text == "" || tbInput1.Text == "" || tbInput2.Text == "" || tbInput3.Text == "")
            {
                lblStatus.Text = "Invalid inputs.";
                return;
            }

            nn.setInputs(0, Convert.ToDouble(tbInput0.Text));
            nn.setInputs(1, Convert.ToDouble(tbInput1.Text));
            nn.setInputs(2, Convert.ToDouble(tbInput2.Text));
            nn.setInputs(3, Convert.ToDouble(tbInput3.Text));
            nn.run();

            tbOutput.Text = "" + nn.getOuputData(0);
        }

        private void createNN()
        {
            // https://www.heatonresearch.com/2017/06/01/hidden-layers.html
            hiddenNeuron = (int)((2 / 3) * inputSize) + outputSize;
            nn = new NeuralNet(inputSize, hiddenNeuron, outputSize);
        }

        // trains 1 epoch
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

        // computes mad error
        private double testTrainNN()
        {
            //double errorThreshold = 0.01; // if the error is less than or equal to 0.01, then it should suffice
            //double accurateNum = 0;
            double errorSum = 0;

            for (int i = 0; i < Math.Pow(2, inputSize); i++)
            {
                for (int j = 0; j < inputSize; j++)
                {
                    nn.setInputs(j, dataSet[i, j]);
                }

                nn.run();

                //if (Math.Abs((double) dataSet[i, inputSize] - nn.getOuputData(0)) <= errorThreshold)
                //{
                //    accurateNum++;
                //}
                errorSum = Math.Abs((double) dataSet[i, inputSize] - nn.getOuputData(0));


            }

            //return accurateNum / Math.Pow(2, inputSize);
            return errorSum / Math.Pow(2, inputSize);
        }
    }
}
