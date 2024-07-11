
Console.WriteLine("10- Criar um programa que permita ao usuário mover um arquivo de um diretório para outro usando a classe File e a classe Path.\r\n");

string caminhoOrigem = @"C:\dados\arqu.txt";
string caminhoDestino = @"C:\dados\Img";
try
{
    string nomeArquivo = Path.GetFileName(caminhoOrigem); string caminhoDestinoCompleto =
Path.Combine(caminhoDestino, nomeArquivo);
    File.Move(caminhoOrigem, caminhoDestinoCompleto);
    Console.WriteLine("Movido com sucesso!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex}");
}