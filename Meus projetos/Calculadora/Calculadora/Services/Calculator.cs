namespace Calculadora.Services;

public class Calculator
{
    public void Menu()
    {
        Console.Clear();

        Console.WriteLine("Qual função deseja que a calculadora empenhe?");
        Console.WriteLine("1- Soma");
        Console.WriteLine("2- Subtração");
        Console.WriteLine("3- Divisão");
        Console.WriteLine("4- Multiplicação");
        Console.WriteLine("5- Fatorial");
        Console.WriteLine("6- Radiciacao");
        Console.WriteLine("7- Inverso de radiciação");
        Console.WriteLine("0- Sair");


        Console.WriteLine("-----------------");
        Console.WriteLine("Selecione uma opção: ");
        short res = short.Parse(Console.ReadLine() ?? string.Empty);

        switch (res)
        {
            case (0): Environment.Exit(0); break;
            case (1): Soma(); break;
            case (2): Subtracao(); break;
            case (3): Divisao(); break;
            case (4): Multiplicacao(); break;
            case (5): Fatorial(); break;
            case (6): Radiciacao(); break;
            case (7): Potenciacao(); break;
            default: Menu(); break;
        }
    }

    public void Soma()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine() ?? string.Empty);
        //var v1 = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("");


        float resultado = v1 + v2;
        Console.WriteLine($"O resultado da soma é {resultado}" + ".");
        Console.ReadKey();
        Menu();
    }

    public void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("");

        float resultado = v1 - v2;
        Console.WriteLine($"O resultado da subtração é: {resultado}.");
        Console.ReadKey();
        Menu();
    }

    public void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("");


        float resultado = v1 / v2;
        //Console.WriteLine($"O resultado da divisão é: {resultado}.");
        Console.WriteLine(resultado.ToString("F2"));

        Console.ReadKey();
        Menu();
    }

    public void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Insira o primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("Insira o segundo valor: ");
        float v2 = float.Parse(Console.ReadLine() ?? string.Empty);

        float resultado = v1 * v2;

        //Console.WriteLine($"O resultado da multiplicação é {resultado}");

        Console.WriteLine(resultado.ToString("F2"));
        Console.ReadKey();
        Menu();
    }

    public void Fatorial()
    {
        Console.Clear();

        Console.WriteLine("Qual valor você deseja saber em fatorial: .");

        long num = long.Parse(Console.ReadLine() ?? string.Empty);
        long i = num - 1;

        while (i > 0)

        {
            num *= i;
            i--;
        }
        
        Console.WriteLine($"O resultado do fatorial é: {num}");
        
        Console.ReadKey();
        Menu();
    }

    public void Radiciacao()
    {
        Console.Clear();

        Console.WriteLine("Qual número você quer descobrir a radiciação: ");
        double num = double.Parse(Console.ReadLine() ?? string.Empty);

        var a = Math.Sqrt(num);
        Console.WriteLine($"O resultado do teu CuaDrado é {a}");

        Console.ReadKey();
        Menu();
    }

    public void Potenciacao()
    {
        Console.Clear();

        Console.WriteLine("De qual número vocẽ gostaria de saber a potência?: ");
        double num = double.Parse(Console.ReadLine() ?? string.Empty);
        double vezes = double.Parse(Console.ReadLine() ?? string.Empty);

        var a = Math.Pow(num, vezes);
        Console.WriteLine($"O resultado da potenciação é: {a}");
        
        Console.ReadKey();
        Menu();
    }
}