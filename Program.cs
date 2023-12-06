namespace Stopwatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1, 1)); //pega o primeiro dígito contando a posição 012345 e subtrai a letra "s"
            int time = int.Parse(data.Substring(0, data.Length - 1));  //pega somente ó número digitado e subtrai a letra "s" para prosseguir com cálculo
            int multiplicador = 1;

            if (type == 'm')
            {
                multiplicador = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            Inicio(time * multiplicador);

        }

        static void Inicio(int tempo) 
        {
            
            int minutoatual = 0;

            while (minutoatual != tempo)
            {
                Console.Clear();
                minutoatual++;
                Console.WriteLine(minutoatual);
                Thread.Sleep(1000);
            }

            
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(5000);

            Menu();
        }        
    }
}

