using System.Text;

namespace Editorhtml.Functions
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Backspace); 
            //Caso use alguma IDE sem ser o Jetbrains Rider, alterar o "Backspace" para "Escape"
            
            Console.WriteLine("------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());


        }
    }
}

