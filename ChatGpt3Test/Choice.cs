namespace ChatGpt3Test;

public class Choice
{
    [JsonPropertyName("message")]
    public Message Message { get; set; } = default!;

    [JsonPropertyName("finish_reason")]
    public string FinishReason { get; set; } = string.Empty!;

    [JsonPropertyName("index")]
    public int Index { get; set; }
}