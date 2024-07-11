
Console.WriteLine("13- Criar um programa que renomeie um arquivo usando a classe File e a classe Path.\r\n");

string caminhoArquivo = @"C:\dados\NovoNome.txt";
string novoNome = "Arquivot.txt";
try
{
    string caminhoCompleto = Path.Combine(Path.GetDirectoryName(caminhoArquivo), novoNome);
    File.Move(caminhoArquivo, caminhoCompleto);
    Console.WriteLine($"{caminhoArquivo} Renomeado para {novoNome} com sucesso!");
}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex}");
}