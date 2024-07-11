
Console.WriteLine("9- Criar um programa que permita ao usuário copiar um arquivo de um diretório para outro usando a classe File e a classe Path.\r\n");

string caminhoOrigem = @"C:\dados\letra.PNG";
string caminhoDestino = @"C:\dados\img";
try
{
    string nomeArquivo = Path.GetFileName(caminhoOrigem);
    string caminhoDestinoCompleto = Path.Combine(caminhoDestino, nomeArquivo);
    File.Copy(caminhoOrigem, caminhoDestinoCompleto);
    Console.WriteLine($"Salvo com sucesso! {caminhoDestino}");
}
catch(Exception ex)
{
    Console.WriteLine($"Arquivo já existe!\n {ex}");
}