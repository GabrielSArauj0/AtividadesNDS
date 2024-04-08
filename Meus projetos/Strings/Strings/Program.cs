using System.Text;

namespace Strings;

internal class Program
{
    public static void Main(string[] args)
    {
        var texto = new StringBuilder();
        
        texto.Append("Biruleibe sadsad asdads");
        texto.Append("Birueibe é um leibe");
        texto.Append("Leibe é um biru");
        texto.Append("biru é um leibe");
        
        Console.WriteLine(texto);






        /*
        Console.WriteLine(texto.ToLower());
        Console.WriteLine(texto.Replace("e", "isto"));

        var divisao = texto.Split(" ");
        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        Console.WriteLine(divisao[2]);
        Console.WriteLine(divisao[3]);
        Console.WriteLine(divisao[4]);

        var resultado = texto.Substring(5, 5);
        Console.WriteLine(resultado);

        Console.WriteLine(texto.Trim());

        /*
        Console.WriteLine(texto.ToUpper());
        Console.WriteLine(texto.ToLower());
        Console.WriteLine(texto.Insert(5, " Aqui "));
        Console.WriteLine(texto.Remove(5, 6));
        Console.WriteLine(texto.Length);

        /*
        Console.WriteLine(texto.ToUpper());
        Console.WriteLine(texto.ToLower());
        Console.WriteLine(texto.Insert(5, "aqui"));

        /*
        Console.WriteLine(texto.IndexOf("é"));
        Console.WriteLine(texto.LastIndexOf("é"));

        /*
        Console.WriteLine(texto.Equals("Este texto é um teste"));
        Console.WriteLine(texto.Equals("Abublebuble buble"));
        Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));

        /*
        Console.WriteLine(texto.StartsWith("Este"));
        Console.WriteLine(texto.StartsWith("este"));
        Console.WriteLine(texto.StartsWith("texto"));

        Console.WriteLine(texto.EndsWith("Teste"));
        Console.WriteLine(texto.EndsWith("xp"));
        Console.WriteLine(texto.EndsWith("teste"));

        /*
        Console.WriteLine(texto.Contains("Teste"));
        Console.WriteLine(texto.Contains("teste"));
        Console.WriteLine(texto.Contains("xpro",StringComparison.OrdinalIgnoreCase));

        */
    }
}