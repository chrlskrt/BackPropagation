using System.Windows.Forms;
using Backprop;

namespace BackPropagation
{
    public partial class BackPropagation : Form
    {
        NeuralNet? nn;
        int inputSize = 4;
        int outputSize = 1;
        int hiddenNeuron;
        int epochs;
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
            epochs = 4000;
        }

        private void btnCreateNN_Click(object sender, EventArgs e)
        {
            createNN();
        }

        private void btnTrainNN_Click(object sender, EventArgs e)
        {
            createNN();

            for (int i = 0; i < epochs; i++)
            {
                trainNN();
            }
        }

        private void btnTestNN_Click(object sender, EventArgs e)
        {
            if (nn == null)
            {
                tbOutput.Text = "Neural network not found.";
            }

            if (tbInput0.Text == "" || tbInput1.Text == "" || tbInput2.Text == "" || tbInput3.Text == "")
            {
                tbOutput.Text = "Invalid inputs.";
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

        private void trainNN()
        {
            for (int i = 0; i < Math.Pow(2, inputSize); i++)
            {
                for (int j = 0; j < inputSize; j++)
                {
                    nn.setInputs(j, dataSet[i, j]);
                }

                nn.setDesiredOutput(0, dataSet[i, inputSize - 1]);
                nn.learn();
            }
        }

        
    }
}
