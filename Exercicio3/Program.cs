internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("numero 1");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("numero 2");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double soma = n1 + n2;
        double subtracao= n1 - n2;
        double multiplicacao = n1 * n2;
        double divisao = n1 / n2;
        double media = (n1 + n2)/2;

        Console.WriteLine($"soma = {soma},");
        Console.WriteLine($"subtração = {subtracao},");
        Console.WriteLine($"multiplicacao = {multiplicacao},");
        Console.WriteLine($"divisao = {divisao},");
        Console.WriteLine($"media = {media}.");

    }
}