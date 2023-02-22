namespace OpenAIChat.Models;

public class QuestionAndAnswer
{
    public string Question { get; set; }
    public List<string> Anwsers { get; set; }

    public QuestionAndAnswer(string question, List<string> answers)
    {
        Question = question;
        Anwsers = answers;
    }
}