using System.Security.Cryptography;
using System.Text;
using System;
using System.IO;

Console.WriteLine("4- Escreva um programa que leia o conteúdo de um arquivo de texto e o criptografe usando o algoritmo de criptografia AES. Em seguida," +
    " salve o arquivo criptografado em um novo arquivo. O nome do arquivo de origem e destino deve ser fornecido pelo usuário.\r\n");

Console.Write("Digite o caminho do arquivo de origem: ");
string caminhoOrigem = Console.ReadLine();

Console.Write("Digite o caminho do arquivo de destino: ");
string caminhoDestino = Console.ReadLine();

string chave = "minhachave12345678";
// Lê o conteúdo do arquivo
string conteudo = File.ReadAllText(caminhoOrigem);
// Criptografa o conteúdo com o algoritmo AES
byte[] conteudoCriptografado;
using (Aes aes = Aes.Create())
{
    aes.Key = Encoding.UTF8.GetBytes(chave);
    aes.Mode = CipherMode.CBC;
    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
    using (MemoryStream memoryStream = new MemoryStream())
    {
        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor,
       CryptoStreamMode.Write))
        {
            using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
            {
                streamWriter.Write(conteudo);
            }
            conteudoCriptografado = memoryStream.ToArray();
        }
    }
}
// Salva o conteúdo criptografado em um novo arquivo
File.WriteAllBytes(caminhoDestino, conteudoCriptografado);
Console.WriteLine("Arquivo criptografado com sucesso.");


        Console.Write("Digite o nome do arquivo de origem: ");
        string arquivoOrigem = Console.ReadLine();

        Console.Write("Digite o nome do arquivo de destino: ");
        string arquivoDestino = Console.ReadLine();

        // Chave e vetor de inicialização para o AES
        byte[] chaveAES = Encoding.UTF8.GetBytes("SuaChaveDe32BytesDeveEstarAqui!"); // 32 bytes = 256 bits
        byte[] ivAES = Encoding.UTF8.GetBytes("SeuIVDe16Bytes!"); // 16 bytes = 128 bits

        // Ler o conteúdo do arquivo de origem
        string conteudoOriginal;
        using (StreamReader reader = new StreamReader(arquivoOrigem))
        {
            conteudoOriginal = reader.ReadToEnd();
        }

        // Criptografar o conteúdo
        var conteudoCriptografado = CriptografarAES(conteudoOriginal, chaveAES, ivAES);

        // Salvar o conteúdo criptografado no arquivo de destino
        using (FileStream fs = new FileStream(arquivoDestino, FileMode.Create))
        {
            fs.Write(conteudoCriptografado, 0, conteudoCriptografado.Length);
        }

        Console.WriteLine("Arquivo criptografado e salvo com sucesso.");
    
    static byte[] CriptografarAES(string plainText, byte[] chave, byte[] iv)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = chave;
            aesAlg.IV = iv;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return msEncrypt.ToArray();
                }
            }
        }
    }


