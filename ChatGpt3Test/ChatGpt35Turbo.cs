namespace ChatGpt3Test;

public static class ChatGpt35Turbo
{
    public static async Task<ChatGpt35TurboResponse> GetResponse(string content)
    {
        var chatGpt3Request = new ChatGpt35TurboRequest(content);
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(Env.url),
            Headers =
            {
                { "OpenAI-Organization", Env.orgId },
                { "Authorization", $"Bearer {Env.apiKey}" },
            },
            Content = new StringContent(chatGpt3Request.ToString())
            {
                Headers =
                {
                    ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(System.Net.Mime.MediaTypeNames.Application.Json)
                }
            }
        };
        var client = new HttpClient();
        using var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var body = await response.Content.ReadAsStringAsync();
        var chatGpt35TurboResponse = JsonSerializer.Deserialize<ChatGpt35TurboResponse>(body)!;

        return chatGpt35TurboResponse;
    }
}