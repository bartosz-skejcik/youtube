namespace Quiz
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] pytania = {
    "Jakie jest największe jezioro na świecie?",
    "Jaki jest wynik 2 + 2?",
    "Jaka jest stolica Francji?"
};
            string[] odpowiedzi = { "Bajkał", "4", "Paryż" };
            int poprawne = 0;



            for (int i = 0; i < pytania.Length; i++)
            {
                Console.Clear();

                Console.WriteLine(pytania[i] + "?");
                Console.Write("Odpowiedz: ");
                string odpowiedz = Console.ReadLine()!;

                if (odpowiedz.Equals(odpowiedzi[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Dobra odpowiedz.");
                    poprawne++;
                }
                else
                {
                    Console.WriteLine("Zla odpowiedz.");
                }
                Thread.Sleep(3600);
            }

            Console.Clear();
            Console.WriteLine($"Uzyskales {poprawne} poprawnych odpowiedzi na {pytania.Length} pytan");
        }
    }
}
