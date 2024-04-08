namespace Excecao
{
    class Program
    {
        static void Main()
        { 
            var arr = new int[3];

            try
            {

                for (var index = 0; index < 10; index++)
                {
                    Console.WriteLine(arr[index]);
                }

                Save("2");

            }



            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.InnerException?.Message);
                Console.WriteLine("Não pude encontrar o índice na lista.");

            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("E o texto, nada ainda?");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Falha ao cadastrar texto");

            }

            catch (Exception ex)
            {
                Console.WriteLine("Deu errado ai meu chapan!");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Fim da busca!");
            }


            void Save(string texto)
            {
                if (string.IsNullOrEmpty(texto))
                    throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
            
    }
}
