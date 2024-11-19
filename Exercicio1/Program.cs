
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual seu nome ?");
        string? nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");

    }
}