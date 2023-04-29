using System.Formats.Tar;
using System.Runtime.InteropServices;

// Para efetuar o download dos icones de arquitetura do Azure acesse:
// https://learn.microsoft.com/en-us/azure/architecture/icons/

Console.WriteLine("***** Testes com .NET 7 | Utilizando a classe TarFile *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

var arquivoAgrupador = $"databases{DateTime.Now:yyyy-MM-dd_HHmmss}.tar";
TarFile.CreateFromDirectory(@"D:\Azure\Icons\databases", arquivoAgrupador, true);

if (File.Exists(arquivoAgrupador))
{
    Console.WriteLine($"Arquivo {arquivoAgrupador} gerado com sucesso!");
    Console.WriteLine(
        $"Para descomprimir extrair o conteudo utilize o comando: tar -xvf {arquivoAgrupador}");
}