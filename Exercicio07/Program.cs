
Console.WriteLine("7- Criar um programa que liste todos os subdiretórios em um determinado diretório usando a classe DirectoryInfo.\r\n");

string caminho = @"C:\dados";
DirectoryInfo diretorio = new DirectoryInfo(caminho);
foreach (var subdiretorio in diretorio.GetDirectories())
{
    Console.WriteLine(subdiretorio.Name);
}
