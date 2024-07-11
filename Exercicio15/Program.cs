
Console.WriteLine("15- Criar um programa que retorne o nome do arquivo mais recente em um diretório usando a classe DirectoryInfo e a classe Path.\r\n");

// Diretório que você deseja pesquisar
string diretorio = @"C:\dados";

// Cria um objeto DirectoryInfo para o diretório
DirectoryInfo dirInfo = new DirectoryInfo(diretorio);

// Obtém todos os arquivos no diretório
FileInfo[] arquivos = dirInfo.GetFiles();

// Inicializa a data de modificação mais recente e o nome do arquivo correspondente
DateTime ultimaModificacao = DateTime.MinValue;
string nomeArquivoMaisRecente = string.Empty;

// Percorre todos os arquivos para encontrar o mais recente
foreach (FileInfo arquivo in arquivos)
{
    if (arquivo.LastWriteTime > ultimaModificacao)
    {
        ultimaModificacao = arquivo.LastWriteTime;
        nomeArquivoMaisRecente = arquivo.Name;
    }
}

// Verifica se algum arquivo foi encontrado e imprime o nome do arquivo mais recente
if (!string.IsNullOrEmpty(nomeArquivoMaisRecente))
{
    Console.WriteLine($"O arquivo mais recente em {diretorio} é:" +
        $" { Path.Combine(diretorio, nomeArquivoMaisRecente)}" +
        $"");
}
else
{
    Console.WriteLine($"Não foi encontrado nenhum arquivo em {diretorio}");
}
