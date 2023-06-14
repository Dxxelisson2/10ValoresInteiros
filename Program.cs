internal class Program
{
    private static void Main(string[] args)
    {
        const int quantidadeValores = 10;

        int[] valores = new int[quantidadeValores];
        double soma = 0;

        Console.WriteLine("Digite os 10 valores:");

        // Digitação dos valores e cálculo da soma
        for (int i = 0; i < quantidadeValores; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            valores[i] = int.Parse(Console.ReadLine());
            soma += valores[i];
        }

        // Cálculo da média aritmética
        double media = soma / quantidadeValores;
        int quantidadeMaiores = 0;

        // Contagem dos valores maiores que a média
        for (int i = 0; i < quantidadeValores; i++)
        {
            if (valores[i] > media)
            {
                quantidadeMaiores++;
            }
        }

        // Exibição da média e quantidade de valores maiores
        Console.WriteLine($"A média aritmética é: {media}");
        Console.WriteLine($"Quantidade de valores maiores do que a média: {quantidadeMaiores}");

        Console.ReadLine();
    }
}
