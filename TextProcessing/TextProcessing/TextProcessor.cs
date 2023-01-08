namespace TextProcessing
{
    public class TextProcessor : IProcessor
    {
        

        public TextAnalysis Analyze(string text)
        {
            return new TextAnalysis()
            {
                NumberOfWords = CountNumberOfWords(text)
            };
        }

        private int CountNumberOfWords(string text)
        {
            int numberOfWords = text.Split(" ").Length;
            return numberOfWords;
        }
    }
}