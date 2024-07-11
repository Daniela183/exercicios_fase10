using System;
using System.IO;

Console.WriteLine("5- Escreva um programa que leia o conteúdo de um arquivo de imagem e converta-o para um arquivo de texto usando o algoritmo de " +
    "codificação Base64. Em seguida, salve o arquivo de texto em um novo arquivo. O nome do arquivo de origem e destino deve ser fornecido pelo usuário.\r\n");

Console.Write("Digite o caminho do arquivo de imagem: ");
string imagePath = Console.ReadLine();

Console.Write("Digite o caminho do arquivo de destino .txt: ");
string textFilePath = Console.ReadLine();

try
{
    // Lê o conteúdo do arquivo de imagem
    byte[] imageBytes = File.ReadAllBytes(imagePath);

    // Converte o conteúdo para Base64
    string base64String = Convert.ToBase64String(imageBytes);

    // Escreve o conteúdo em um novo arquivo de texto
    File.WriteAllText(textFilePath, base64String);

    Console.WriteLine("Arquivo de texto salvo com sucesso!");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}
