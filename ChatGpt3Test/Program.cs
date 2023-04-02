using ChatGpt3Test;
using static System.Console;

//var content = "Estou enfrentando problemas de \"Crash de Recravadora\" em uma área produtiva do tipo \"Packaging\" em um equipamento \"Enchedora 01\". Quais tipos de causas-raízes os fabricantes desse tipo de máquina recomendam para solucionar o problema?";

WriteLine("Olá sou o chat GPT no seu PC! me pergunte algo ou escreva fim");
var content = string.Empty;

do
{
    ForegroundColor = (ConsoleColor)new Random().Next(0, 15);
    WriteLine("\nPode Perguntar:\n");
    content = ReadLine();
    content += " responda no contexto de tributos";
    if (!string.IsNullOrEmpty(content) && content!.ToLower() != "fim")
    {
        var response = await ChatGpt35Turbo.GetResponse(content);

        WriteLine();
        WriteLine(response);
    }
} while (content!.ToLower() != "fim");