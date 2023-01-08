namespace TextProcessing
{
    public class TextProcessor : IProcessor
    {
        public TextAnalysis Analyze(string text)
        {
            return new TextAnalysis()
            {
                NumberOfWords = CountNumberOfWords(text),
                NumberOfDifferentWords = CountNumberOfDifferentWords(text)
            };
        }

        private int CountNumberOfDifferentWords(string text)
        {
            return GetWords(text).Distinct().Count();
        }

        private int CountNumberOfWords(string text)
        {
            int numberOfWords = GetWords(text).Count;

            return numberOfWords;
        }

        private static List<string> GetWords(string text)
        {
            var words = text.Split(" ").ToList();

            words = words.Select(x => x.ToLower()
                .Replace(".", string.Empty)
                .Replace(",", string.Empty)).ToList();

            return words;
        }
    }
}