
public class NeuralNetwork
{
    
    private int inputSize;
    private int hiddenSize;
    private int outputSize;

    private double[,] weightsInputHidden;
    private double[,] weightsHiddenOutput;

    private double[] biasHidden;
    private double[] biasOutput;

    private double learningRate = 0.1; 


   
    public NeuralNetwork(int inputSize, int hiddenSize, int outputSize)
    {
        
        this.inputSize = inputSize;
        this.hiddenSize = hiddenSize;
        this.outputSize = outputSize;

        
        var random = new Random();


        weightsInputHidden = new double[inputSize, hiddenSize];
        for (int i = 0; i < inputSize; i++)
        {
            for (int j = 0; j < hiddenSize; j++)
            {
                weightsInputHidden[i, j] = random.NextDouble() * 2 - 1;
            }
        }

        weightsHiddenOutput = new double[hiddenSize, outputSize];
        for (int i = 0; i < hiddenSize; i++)
        {
            for (int j = 0; j < outputSize; j++)
            {
                weightsHiddenOutput[i, j] = random.NextDouble() * 2 - 1;
            }
        }

        biasHidden = new double[hiddenSize];
        for (int i = 0; i < hiddenSize; i++)
        {
            biasHidden[i] = random.NextDouble() * 2 - 1; 
        }

        biasOutput = new double[outputSize];
        for (int i = 0; i < outputSize; i++)
        {
            biasOutput[i] = random.NextDouble() * 2 - 1; 
        }
    }

    
    private double Sigmoid(double x)
    {
        return 1 / (1 + Math.Exp(-x));
    }

    // Forward propagation
    public double[] Predict(double[] input)
    {
        double[] hiddenLayerOutput = new double[hiddenSize];
        double[] outputLayerOutput = new double[outputSize];

        // Hidden layer comp.
        for (int i = 0; i < hiddenSize; i++)
        {
            double sum = 0;
            for (int j = 0; j < inputSize; j++)
            {
                sum += input[j] * weightsInputHidden[j, i];
            }
            hiddenLayerOutput[i] = Sigmoid(sum + biasHidden[i]);
        }

        // Output layer comp.
        for (int i = 0; i < outputSize; i++)
        {
            double sum = 0;
            for (int j = 0; j < hiddenSize; j++)
            {
                sum += hiddenLayerOutput[j] * weightsHiddenOutput[j, i];
            }
            outputLayerOutput[i] = Sigmoid(sum + biasOutput[i]);
        }

        return outputLayerOutput;
    }

    // Backpropagation
    public void Train(double[] input, double[] target, double errorEpsilon)
    {

        double[] hiddenLayerOutput = new double[hiddenSize];
        double[] outputLayerOutput = new double[outputSize];

        // Hidden layer comp.
        for (int i = 0; i < hiddenSize; i++)
        {
            double sum = 0;
            for (int j = 0; j < inputSize; j++)
            {
                sum += input[j] * weightsInputHidden[j, i];
            }
            hiddenLayerOutput[i] = Sigmoid(sum + biasHidden[i]);
        }

        // Output layer comp.
        for (int i = 0; i < outputSize; i++)
        {
            double sum = 0;
            for (int j = 0; j < hiddenSize; j++)
            {
                sum += hiddenLayerOutput[j] * weightsHiddenOutput[j, i];
            }
            outputLayerOutput[i] = Sigmoid(sum + biasOutput[i]);
        }

        // Output layer errors.
        double[] outputErrors = new double[outputSize];
        double totalError = 0.0;
        for (int i = 0; i < outputSize; i++)
        {
            outputErrors[i] = target[i] - outputLayerOutput[i];
            totalError += Math.Abs(outputErrors[i]);
        }

        double averageError = totalError / outputSize;


        // Bias Update
        for (int i = 0; i < outputSize; i++)
        {
            double deltaBiasOutput = learningRate * outputErrors[i] * outputLayerOutput[i] * (1 - outputLayerOutput[i]);
            biasOutput[i] += deltaBiasOutput;
        }

        //Layer weight update between hidden-output
        for (int i = 0; i < hiddenSize; i++)
        {
            for (int j = 0; j < outputSize; j++)
            {
                double deltaWeightHiddenOutput = learningRate * outputErrors[j] * outputLayerOutput[j] * (1 - outputLayerOutput[j]) * hiddenLayerOutput[i];
                weightsHiddenOutput[i, j] += deltaWeightHiddenOutput;
            }
        }

        // Layer weight update between input-hidden 
        for (int i = 0; i < inputSize; i++)
        {
            for (int j = 0; j < hiddenSize; j++)
            {
                double deltaWeightInputHiddenSum = 0;
                for (int k = 0; k < outputSize; k++)
                {
                    deltaWeightInputHiddenSum += outputErrors[k] * outputLayerOutput[k] * (1 - outputLayerOutput[k]) * weightsHiddenOutput[j, k];
                }
                double deltaWeightInputHidden = deltaWeightInputHiddenSum * hiddenLayerOutput[j] * (1 - hiddenLayerOutput[j]) * input[i];
                weightsInputHidden[i, j] += learningRate * deltaWeightInputHidden;
            }
        }


            if (averageError < errorEpsilon)
        {
            return;
        }
    }

 
    public void SaveWeights(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // input-hidden layer weights
            for (int i = 0; i < inputSize; i++)
            {
                for (int j = 0; j < hiddenSize; j++)
                {
                    writer.WriteLine(weightsInputHidden[i, j]);
                }
            }

            // hidden-output layer weights
            for (int i = 0; i < hiddenSize; i++)
            {
                for (int j = 0; j < outputSize; j++)
                {
                    writer.WriteLine(weightsHiddenOutput[i, j]);
                }
            }

            //  hidden layer biases
            for (int i = 0; i < hiddenSize; i++)
            {
                writer.WriteLine(biasHidden[i]);
            }

            // output layer biases
            for (int i = 0; i < outputSize; i++)
            {
                writer.WriteLine(biasOutput[i]);
            }
        }
    }

    public void LoadWeights(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            // input-hidden layer weights
            for (int i = 0; i < inputSize; i++)
            {
                for (int j = 0; j < hiddenSize; j++)
                {
                    weightsInputHidden[i, j] = Convert.ToDouble(reader.ReadLine());
                }
            }

            // hidden-output layer weights
            for (int i = 0; i < hiddenSize; i++)
            {
                for (int j = 0; j < outputSize; j++)
                {
                    weightsHiddenOutput[i, j] = Convert.ToDouble(reader.ReadLine());
                }
            }

            // hidden layer biases
            for (int i = 0; i < hiddenSize; i++)
            {
                biasHidden[i] = Convert.ToDouble(reader.ReadLine());
            }

            // output layer biases
            for (int i = 0; i < outputSize; i++)
            {
                biasOutput[i] = Convert.ToDouble(reader.ReadLine());
            }
        }
    }


}