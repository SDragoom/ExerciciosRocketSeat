class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o formato para exibição da data e hora:");
        Console.WriteLine("1 - Formato completo");
        Console.WriteLine("2 - Apenas a data no formato '01/03/2024'");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        DateTime dataAtual = DateTime.Now;
        string? escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Console.WriteLine($"Formato completo: {dataAtual:dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss}");
                break;

            case "2":
                Console.WriteLine($"Apenas a data: {dataAtual:dd/MM/yyyy}");
                break;

            case "3":
                Console.WriteLine($"Apenas a hora: {dataAtual:HH:mm}");
                break;

            case "4":
                Console.WriteLine($"Data com mês por extenso: {dataAtual:dd 'de' MMMM 'de' yyyy}");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
