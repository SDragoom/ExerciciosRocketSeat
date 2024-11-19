internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escreva uma frase:");
        string? frase = Console.ReadLine();
        int? contFraseComEspaco = string.IsNullOrEmpty(frase) ? 0 : frase.Length;
        string? fraseSemEspaco = string.IsNullOrEmpty(frase) ? "" : frase.Replace(" ", "");
        int? contFraseSemEspaco = fraseSemEspaco.Length;

        Console.WriteLine($"sua frase possui {contFraseComEspaco} caracteres contando o espaço!");
        Console.WriteLine($"sua frase possui {contFraseSemEspaco} caracteres sem contar o espaço!");


    }
}