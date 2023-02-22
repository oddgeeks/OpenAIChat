namespace OpenAIChat.Models;
public class AppSettings
{
    public string? OpenAIApiKey { get; set; }
    public int ContextMaxLength { get; set; } = 500;
}