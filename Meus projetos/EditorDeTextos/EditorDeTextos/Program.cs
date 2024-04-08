namespace EditorDeTextos;

internal class Program
{
    public static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que desejas fazer?");
        Console.WriteLine("1- Abrir arquivo");
        Console.WriteLine("2- Criar novo arquivo");
        Console.WriteLine("0- Sair");

        short option = short.Parse(Console.ReadLine() ?? string.Empty);

        switch (option)
        {
            case (0): Environment.Exit(0); break;
            case (1): Open(); break;
            case (2): Edit(); break;
            default: Menu(); break;
        }
    }

    static void Open()
    {
        Console.Clear();
        Console.WriteLine("Qual caminho do arquivo?");
        string path = Console.ReadLine();

        using (var file = new StreamReader(path))
        {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }

        Console.WriteLine("");
        Console.ReadLine();
        Menu();
    }

    static void Edit()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
        Console.WriteLine("---------------------------------------");
        string text = "";

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        } while
            (Console.ReadKey().Key != ConsoleKey.Backspace); /* Caso utilize o JetBrains Rider, substituir a tecla.*/

        Console.Write(text);

        Save(text);
    }

    static void Save(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual endereço você deseja salvar o arquivo?");
        var path = Console.ReadLine();

        if (path != null)
        {
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        }

        Console.ReadLine();
        Menu();
    }
}