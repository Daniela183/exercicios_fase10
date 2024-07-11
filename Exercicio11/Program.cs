
Console.WriteLine("11- Criar um programa que liste todos os arquivos em um determinado diretório e suas subpastas usando a classe DirectoryInfo e a " +
    "classe Path\r\n");

string caminho = @"C:\dados";
DirectoryInfo diretorio = new DirectoryInfo(caminho);
foreach (var arquivo in diretorio.GetFiles("*", SearchOption.AllDirectories))
{
    Console.WriteLine(arquivo.FullName);
}

