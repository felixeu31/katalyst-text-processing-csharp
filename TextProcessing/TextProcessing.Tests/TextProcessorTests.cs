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

        [Fact]
        public void report_summary()
        {
            // Arrange
            var textProcessor = new TextProcessor();

            // Act
            var analysis = textProcessor.Analyze(_textSample1);
            var expected = @"Those are the top 10 words used:

1. you
2. this
3. your
4. to
5. text
6. test
7. should
8. practice
9. make
10. it

The text has in total 21 words";


            // Assert
            analysis.ReportSummary.Should().Be(expected);
        }


    }

    
}