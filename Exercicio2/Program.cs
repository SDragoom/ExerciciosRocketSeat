internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual seu nome ?");
        string? nome = Console.ReadLine();
        Console.WriteLine("Qual seu sobrenome ?");
        string? sobrenome = Console.ReadLine();
        string? nomecompleto = nome +" "+ sobrenome;
        Console.WriteLine($"seu nome completo é {nomecompleto}!");

    }
}