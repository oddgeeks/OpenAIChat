namespace OpenAIChat.Models;

public class QuestionAndAnswer
{
    public string Question { get; set; }
    public List<string> Answers { get; set; }

    public QuestionAndAnswer(string question, List<string> answers)
    {
        Question = question;
        Answers = answers;
    }
}