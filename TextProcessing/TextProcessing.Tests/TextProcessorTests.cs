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
            var analysis = textProcessor.Analyze(_textSample1);

            // Assert
            analysis.NumberOfWords.Should().Be(21);
        }


        [Fact]
        public void number_of_different_words()
        {
            // Arrange
            var textProcessor = new TextProcessor();

            // Act
            var analysis = textProcessor.Analyze(_textSample1);

            // Assert
            analysis.NumberOfDifferentWords.Should().Be(19);
        }


    }

    
}