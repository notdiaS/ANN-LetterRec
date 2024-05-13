using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ANN_LetterRec
{
    public partial class MainForm : Form
    {
        private Button[,] buttons;
        private int[,] gridState;


        static int inputSize = 35; // 7x5
        static int hiddenSize = 10;
        static int outputSize = 5; // A, B, C, D, E


        NeuralNetwork neuralNetwork = new NeuralNetwork(inputSize, hiddenSize, outputSize);

        public MainForm()
        {
            InitializeComponent();
        }

        //Form moving code.
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button != null)
            {
                int[] coordinates = (int[])button.Tag;
                int i = coordinates[0];
                int j = coordinates[1];

                gridState[i, j] = gridState[i, j] == 1 ? 0 : 1;

                button.BackColor = gridState[i, j] == 1 ? Color.FromArgb(43, 45, 62) : Color.FromArgb(52, 63, 86);
            }

        }

       
        private void trainButton_Click(object sender, EventArgs e)
        {
            trainButton.Enabled = false;

            TrainingData trainingData = new TrainingData();
            double errorEpsilon = double.Parse(ErrorEpsilontextBox.Text);
            int epochs = 1000;

            try
            {
                for (int epoch = 0; epoch < epochs; epoch++)
                {
                    for (int i = 0; i < trainingData.trainingDataInputs.Length; i++)
                    {
                        double[] flattenedInput = Flatten(trainingData.trainingDataInputs[i]);
                        double[] target = trainingData.trainingDataTargets[i];
                        neuralNetwork.Train(flattenedInput, target, errorEpsilon);
                    }
                }
                MessageBox.Show("Training completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during training: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                trainButton.Enabled = true;
            }

        }


        private void testButton_Click(object sender, EventArgs e)
        {

            char[] letters = { 'A', 'B', 'C', 'D', 'E' };

            double[] input = ConvertGridStateToInput();

            double[] output = neuralNetwork.Predict(input);

            textBoxA.Text = output[0].ToString();
            textBoxB.Text = output[1].ToString();
            textBoxC.Text = output[2].ToString();
            textBoxD.Text = output[3].ToString();
            textBoxE.Text = output[4].ToString();


            int maxIndex = 0;
            double maxValue = output[0];
            for (int i = 1; i < output.Length; i++)
            {
                if (output[i] > maxValue)
                {
                    maxIndex = i;
                    maxValue = output[i];
                }
            }

            char predictedLetter = letters[maxIndex];
            textBoxPrediction.Text = predictedLetter.ToString();


        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    gridState[i, j] = 0;
                    buttons[i, j].BackColor = Color.FromArgb(52, 63, 86);
                }
            }
        }

        static double[] Flatten(double[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            double[] flattened = new double[rows * cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flattened[i * cols + j] = array[i, j];
                }
            }
            return flattened;
        }

        private double[] ConvertGridStateToInput()
        {
            double[] input = new double[35];

            int index = 0;
            for (int i = 6; i >= 0; i--)
            {
                for (int j = 4; j >= 0; j--)
                {
                    Button button = buttons[i, j];
                    if (button.BackColor == Color.FromArgb(43, 45, 62))
                    {
                        input[index] = 1;
                    }
                    else
                    {
                        input[index] = 0;
                    }
                    index++;
                }
            }
            return input;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    neuralNetwork.SaveWeights(saveFileDialog.FileName);
                    MessageBox.Show("Weights saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    neuralNetwork.LoadWeights(openFileDialog.FileName);
                    MessageBox.Show("Weights loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttons = new Button[7, 5];
            gridState = new int[7, 5];

            int index = 0;
            foreach (Button button in panel1.Controls.OfType<Button>())
            {
                button.Tag = new int[] { index / 5, index % 5 };
                gridState[index / 5, index % 5] = 0;
                buttons[index / 5, index % 5] = button;
                index++;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
