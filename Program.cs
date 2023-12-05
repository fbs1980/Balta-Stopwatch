namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1, 1));
            Console.WriteLine(data);
            Console.WriteLine(type);
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

            Console.Clear() ;
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
        }        
    }
}

