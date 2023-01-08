namespace TextProcessing
{
    public class TextProcessor
    {
        public int CountNumberOfWords(string textSample1)
        {
            int numberOfWords = textSample1.Split(" ").Length;
            return numberOfWords;
        }
    }
}