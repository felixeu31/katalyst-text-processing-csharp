using FluentAssertions;

namespace TextProcessing.Tests
{
    public class TextProcessorTests
    {
        private readonly string _textSample1;


        public TextProcessorTests()
        {
            _textSample1 = "Hello, this is an example for you to practice. You should grab this text and make it as your test case.";
        }

        [Fact]
        public void text_processor_count_number_of_words()
        {
            // Arrange
            var textProcessor = new TextProcessor();

            // Act
            var numberOfWords = textProcessor.CountNumberOfWords(_textSample1);

            // Assert
            numberOfWords.Should().Be(21);
        }
    }

    public class TextProcessor
    {
        public int CountNumberOfWords(string textSample1)
        {
            int numberOfWords = textSample1.Split(" ").Length;
            return numberOfWords;
        }
    }
}