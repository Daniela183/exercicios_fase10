
Console.WriteLine("3- Escreva um programa que crie um arquivo e escreva algumas informações nele. Em seguida, abra o arquivo novamente e adicione" +
    " mais algumas informações a ele. Em seguida, leia o conteúdo do arquivo e exiba-o na tela.\r\n");

string caminho = @"c:\dados\arqu.txt";

using (StreamWriter streamWriter = File.CreateText(caminho))
{
    streamWriter.WriteLine("Primeira linha de texto");
}

using (StreamWriter streamWriter = File.AppendText(caminho))
{
    streamWriter.WriteLine("Segunda linha de texto");
}

using (StreamReader streamReader = File.OpenText(caminho))
{
    string conteudo = streamReader.ReadToEnd();
    Console.WriteLine(conteudo);
}
