namespace feladatok
{
    internal class Program
    {
        static int[] tomb= new int[5];

        static void Feltolt()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i+1}. számot: ");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine();
            for (int i = tomb.Length-1; i >= 0; i--)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine();
            for (int i = 1; i < tomb.Length; i+=2)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.Write("Kérem adjon meg egy számot 1 és 5 között: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A bekért szám: {tomb[szam-1]}");
                
            
        }
        static void Main(string[] args)
        {
            Feltolt();
        }
    }
}
