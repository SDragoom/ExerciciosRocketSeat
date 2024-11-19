using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite a Placa:");
        string? placa = Console.ReadLine();
        string padraoPlaca = @"^[A-Za-z]{3}[0-9]{4}$";

        bool placaValida = !string.IsNullOrEmpty(placa) && Regex.IsMatch(placa, padraoPlaca);

        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");


    }
}