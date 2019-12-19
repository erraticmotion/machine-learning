namespace DigitRecognizerC
{
    using System.Collections.Generic;
    using System.Linq;

    public class Evaluator
    {
        public static double Correct(
            IEnumerable<Observation> validationSet,
            BasicClassifier classifier)
            =>  validationSet
                .Select(obs => Score(obs, classifier))
                .Average();

        private static double Score(
            Observation obs,
            IClassifier classifier)
            =>  classifier.Predict(obs.Pixels) == obs.Label ? 1.0 : 0.0;
    }
}