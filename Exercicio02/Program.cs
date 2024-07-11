
Console.WriteLine("2- Escreva um programa que copie um arquivo de um diretório para outro. O nome e o caminho do arquivo de origem e destino devem" +
    " ser fornecidos pelo usuário.\r\n");

Console.Write("Digite o caminho do arquivo de origem: ");
string caminhoOrigem = Console.ReadLine();

Console.Write("Digite o caminho do diretório de destino: ");
string caminhoDestino = Console.ReadLine();

string nomeArquivo = Path.GetFileName(caminhoOrigem);
string caminhoDestinoCompleto = Path.Combine(caminhoDestino, nomeArquivo);

File.Copy(caminhoOrigem, caminhoDestinoCompleto, true);
Console.WriteLine("Arquivo copiado com sucesso!");

Console.ReadKey();