﻿
namespace ANN_LetterRec
{
    public class TrainingData
    {
        public double[][,] trainingDataInputs = new double[5][,] {

            // A
            new double[,] {
                {0,1,1,1,0},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,1,1,1,1},
                {1,0,0,0,1},
                {1,0,0,0,1} },

            // B
            new double[,] {
                {1,1,1,1,0},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,1,1,1,0},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,1,1,1,0} },


            // C
            new double[,] {
                {0,1,1,1,1},
                {1,0,0,0,0},
                {1,0,0,0,0},
                {1,0,0,0,0},
                {1,0,0,0,0},
                {1,0,0,0,0},
                {0,1,1,1,1} },

            // D
            new double[,] {
                {1,1,1,0,0},
                {1,0,0,1,0},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,0,0,1,0},
                {1,1,1,0,0} },

            // E
            new double[,] {
                {1,1,1,1,1},
                {1,0,0,0,0},
                {1,0,0,0,0},
                {1,1,1,1,1},
                {1,0,0,0,0},
                {1,0,0,0,0},
                {1,1,1,1,1} }
        };

        public double[][] trainingDataTargets = new double[][] {
            new double[] {1,0,0,0,0}, // A
            new double[] {0,1,0,0,0}, // B
            new double[] {0,0,1,0,0}, // C
            new double[] {0,0,0,1,0}, // D
            new double[] {0,0,0,0,1}  // E
        };

    }
}
