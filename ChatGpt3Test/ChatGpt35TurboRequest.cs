namespace ChatGpt3Test;

public class ChatGpt35TurboRequest
{
    public ChatGpt35TurboRequest(string message)
    {
        Messages = new Message[]
        {
            new Message
            {
                Content = message
            }
        };
    }

    public string Model => "gpt-3.5-turbo";
    public float Temperature => 0.1f;
    public Message[] Messages { get; }

    public override string ToString() => JsonSerializer.Serialize(this, new JsonSerializerOptions
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    });
}