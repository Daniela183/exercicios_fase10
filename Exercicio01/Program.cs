using System;
using System.IO;
Console.WriteLine("1- Escreva um programa que leia um caminho de arquivo do usuário e, em seguida, verifique se o arquivo existe. Se o arquivo existir," +
    " mostre a data de criação do arquivo, caso contrário, exiba uma mensagem informando que o arquivo não foi encontrado.\r\n");


Console.Write("Digite o caminho do arquivo: ");
string caminho = Console.ReadLine();
if (File.Exists(caminho))
{
    FileInfo fileInfo = new FileInfo(caminho);
    Console.WriteLine($"O arquivo foi criado em {fileInfo.CreationTime}");
}
else
{
    Console.WriteLine("O arquivo não foi encontrado.");
}

Console.ReadKey();







