// See https://aka.ms/new-console-template for more information
Console.WriteLine("12- Criar um programa que permita ao usuário excluir um arquivo ou diretório usando a classe Directory, a classe DirectoryInfo e a " +
    "classe Path.\r\n");

string caminhoDiretorio = @"C:\dados\exclusao";
string caminhoArquivo = @"C:\dados\excluir.txt";
try
{
    // Exclui o arquivo
    File.Delete(caminhoArquivo);
    // Exclui o diretório
    Directory.Delete(caminhoDiretorio, true);
    Console.WriteLine($"Diretório {caminhoDiretorio} e {caminhoArquivo} excluidos com sucesso!");
}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex}");
}

