namespace DigitRecognizerC
{
    public class Observation
    {
        public Observation(string label, int[] pixels)
        {
            this.Label = label;
            this.Pixels = pixels;
        }

        public string Label { get; }
        public int[] Pixels { get; }
    }
}