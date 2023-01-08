namespace TextProcessing;

public interface IProcessor
{
    TextAnalysis Analyze(string text);
}