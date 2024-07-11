
Console.WriteLine("8- Criar um programa que permita ao usuário criar um novo diretório e, em seguida, criar um arquivo dentro desse diretório usando a" +
    " classe Directory e a classe Path.\r\n");

string caminhoDiretorio = @"C:\dados\MeuNovoDiretorio";
string nomeArquivo = "NovoArquivo.txt";
try
{
// Cria o diretório
Directory.CreateDirectory(caminhoDiretorio);
// Cria o arquivo dentro do diretório
string caminhoCompleto = Path.Combine(caminhoDiretorio, nomeArquivo);
    File.Create(caminhoCompleto);
    Console.WriteLine("Salvo com sucesso!");
}
catch(Exception ex)
{
    Console.WriteLine(ex);
}

