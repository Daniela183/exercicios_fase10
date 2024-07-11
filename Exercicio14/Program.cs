// See https://aka.ms/new-console-template for more information
Console.WriteLine("14- Criar um programa que retorne o tamanho total de um diretório, incluindo todos os arquivos e subdiretórios, usando a classe Directory" +
    " e a classe Path.\r\n");

string diretorio = @"C:\dados";
// Chama o método GetDirectorySize e imprime o resultado
long tamanhoTotal = GetDirectorySize(diretorio);
Console.WriteLine($"Tamanho total do diretório {diretorio}: {tamanhoTotal} bytes");
Console.ReadKey();
static long GetDirectorySize(string diretorio)
{
    // Verifica se o diretório existe
    if (!Directory.Exists(diretorio))
    {
        throw new DirectoryNotFoundException($"Diretório {diretorio} não encontrado.");
    }
    // Recupera o tamanho de todos os arquivos no diretório
    long tamanhoTotal = 0;
    foreach (string arquivo in Directory.GetFiles(diretorio, "*",
     SearchOption.AllDirectories))
    {
        FileInfo info = new FileInfo(arquivo);
        tamanhoTotal += info.Length;
    }
    return tamanhoTotal;
}