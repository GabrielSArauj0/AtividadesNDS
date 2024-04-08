using Editorhtml.Functions;

namespace Editorhtml.Setup

{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            DrawScreen();
            WriteOptions();
           
            var option = short.Parse(Console.ReadLine() ?? string.Empty);
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            Console.Write("#");
            for (int i = 0; i <= 31; i++) 
                Console.Write("#");
            Console.WriteLine();

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("#");
                for (int i = 0; i <= 30; i++) 
                    Console.Write(" ");
                Console.Write("#");
                Console.WriteLine();
            }
            Console.Write("#");
            for (int i = 0; i <= 31; i++) 
                Console.Write("#");
            Console.WriteLine("\n");
         
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 5);
            Console.SetCursorPosition(3, 6);
            Console.Write("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.Write("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.Write("0 - Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");
            Console.SetCursorPosition(3, 10);
            
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                default: Show(); break;
            }
        }
    }
}