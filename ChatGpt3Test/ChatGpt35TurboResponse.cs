namespace ChatGpt3Test;

public class ChatGpt35TurboResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty!;

    [JsonPropertyName("object")]
    public string Object { get; set; } = string.Empty!;

    [JsonPropertyName("created")]
    public long Created { get; set; }

    [JsonPropertyName("model")]
    public string Model { get; set; } = string.Empty!;

    [JsonPropertyName("usage")]
    public Usage Usage { get; set; } = default!;

    [JsonPropertyName("choices")]
    public Choice[] Choices { get; set; } = default!;

    public override string ToString() => Choices.First().Message.Content;
}