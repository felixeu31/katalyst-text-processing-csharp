using System.Text;

namespace TextProcessing
{
    public class TextProcessor : IProcessor
    {
        public TextAnalysis Analyze(string text)
        {
            return new TextAnalysis()
            {
                NumberOfWords = CountNumberOfWords(text),
                NumberOfDifferentWords = CountNumberOfDifferentWords(text),
                ReportSummary = GetReportSummary(text, 10)
            };
        }

        private string GetReportSummary(string text, int topWords)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Those are the top {topWords} words used:");
            stringBuilder.AppendLine();

            var wordOccurrences = GetWords(text)
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .ThenByDescending(x => x.Key);
            
            for (int i = 0; i < topWords; i++)
            {
                stringBuilder.AppendLine($"{i + 1}. {wordOccurrences.ElementAt(i).Key}");
            }

            stringBuilder.AppendLine();
            stringBuilder.Append($"The text has in total {CountNumberOfWords(text)} words");

            return stringBuilder.ToString();
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