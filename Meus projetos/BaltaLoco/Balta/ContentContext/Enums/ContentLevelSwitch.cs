namespace BaltaLoco.ContentContext.Enums;

public class ContentLevelSwitch

{
    public void Menu()
    {
        Console.Clear();
        
        Console.WriteLine("Qual o nível de aula que deseja assistir?");
        Console.WriteLine("1- Iniciante");
        Console.WriteLine("2- Fundamentado");
        Console.WriteLine("3- Intermediário");
        Console.WriteLine("4- Avançado");
        Console.WriteLine("0- Sair");


        Console.WriteLine("-----------------");
        Console.WriteLine("Selecione uma opção: ");
        short Lvl = short.Parse(Console.ReadLine() ?? string.Empty);

        switch (Lvl)
        {
            case (0): Environment.Exit(0); break;
            case (1): EContentLevel.Beginner.ToString(); break;
            case (2): EContentLevel.Fundamental.ToString(); break;
            case (3): EContentLevel.Intermediary.ToString(); break;
            case (4): EContentLevel.Advanced.ToString(); break;
            
            default: Menu(); break;
        }
    }
}