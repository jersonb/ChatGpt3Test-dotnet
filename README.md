# ChatGpt3Test-dotnet

> Aplicação console para servir de documentação para consumo da API do Chat GPT em C#.

> Para testar este projeto é necessário: 
> - Criar uma conta na OpenIa
> - Criar uma API Key
> - Alterar a classe `Envs`

### Defina a a classe `Evns`

``` csharp
public static class Envs
{
    public const string API_KEY = "API_KEY";
    public const string ORG_ID = "ORG_ID";
    public const string URL = "https://api.openai.com/v1/chat/completions";
}
```
