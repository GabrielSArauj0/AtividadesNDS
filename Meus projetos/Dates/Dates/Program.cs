namespace Dates;

class Program
{
    static void Main()
    {
        Console.Clear();
/*
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;


            Console.WriteLine(DateTime.Now.ToString("D",de));
            Console.WriteLine(DateTime.Now.ToString("D",br));
            Console.WriteLine(DateTime.Now.ToString("D",pt));
            Console.WriteLine(DateTime.Now.ToString("D",en));
            Console.WriteLine(DateTime.Now.ToString("D",atual));

            Thread.Sleep(2000);

            Console.Clear();

            var dateTime = DateTime.UtcNow;

            Console.WriteLine(dateTime);

            Console.ReadKey();

            Thread.Sleep(3000);
            Console.Clear();


*/


        var timeSpan = new TimeSpan();
        Console.WriteLine(timeSpan);

        Thread.Sleep(2000);

        Console.Clear();


        var timeSpanNanosegundos = new TimeSpan(1);
        Console.WriteLine(timeSpanNanosegundos);

        Thread.Sleep(2000);
        Console.Clear();


        var timeSpanRelogio = new TimeSpan(13, 17, 26);
        Console.Write(timeSpanRelogio);

        Thread.Sleep(2000);

        
        Console.Clear();
        var 
            timeSpanDiaHoraMinutoSegundoMilissegundo 
                = new TimeSpan(15, 12, 55, 8, 100);

        Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

        Thread.Sleep(2000);
        
        Console.Clear();
        
        Console.WriteLine(timeSpanRelogio - timeSpanDiaHoraMinutoSegundoMilissegundo);
        
        Thread.Sleep(2000);
        
        Console.Clear();

        Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo.Days + ("") + ("dias."));
        
        Thread.Sleep(2000);

        Console.Clear();
        Console.WriteLine(timeSpanRelogio.Add(new TimeSpan(12, 0, 0)));

        Console.ReadKey();
        Console.Clear();



        /*Console.WriteLine(dateTime);
        Console.WriteLine(DateTime.Now);

        Console.WriteLine(dateTime.ToLocalTime());
*/
/*
            var timezoneAustralia =
                TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            Console.WriteLine(timezoneAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));*/




    }

}

