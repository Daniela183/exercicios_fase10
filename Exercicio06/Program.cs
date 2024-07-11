
Console.WriteLine("6- Criar um programa que liste todos os arquivos em um determinado diretório usando a classe Directory e a classe Path.\r\n");

string caminho = @"C:\dados";
string[] arquivos = Directory.GetFiles(caminho);
foreach (string arquivo in arquivos)
{
    Console.WriteLine(Path.GetFileName(arquivo));
}