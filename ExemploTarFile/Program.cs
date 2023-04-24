using System.Formats.Tar;
using System.Runtime.InteropServices;

// Para efetuar o download dos icones de arquitetura do Azure acesse:
// https://learn.microsoft.com/en-us/azure/architecture/icons/

Console.WriteLine("***** Testes com .NET 7 | Utilizando a classe TarFile *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

var arquivoCompactado = $"databases{DateTime.Now:yyyy-MM-dd_HHmmss}.tar";
TarFile.CreateFromDirectory(@"D:\Azure\Icons\databases", arquivoCompactado, true);

if (File.Exists(arquivoCompactado))
{
    Console.WriteLine($"Arquivo {arquivoCompactado} gerado com sucesso!");
    Console.WriteLine($"Para descomprimir execute o comando: tar -xvf {arquivoCompactado}");
}