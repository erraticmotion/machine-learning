namespace DigitRecognizerC
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            var training = DataReader.ReadObservations(@"..\..\..\..\Data\training-sample.csv");
            var validation = DataReader.ReadObservations(@"..\..\..\..\Data\validation-sample.csv");

            var classifier = new BasicClassifier(new ManhattanDistance());
            classifier.Train(training);
            var correct = Evaluator.Correct(validation, classifier);

            Console.WriteLine("Correctly classified: {0:P2}", correct);
            Console.ReadLine();
        }
    }
}
