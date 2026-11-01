namespace feladatok
{
    internal class Program
    {
        static int[] tomb= new int[5];
        static Random r = new Random();

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

        static void Feladat14()
        {
            int a;
            int b;
            string valasztas;
            
            Console.Write("Kéram adja meg hány elemű legyen a lista: ");
            int N = Convert.ToInt32 (Console.ReadLine());
            int[] tombok = new int[N];
            do
            {
                Console.WriteLine("Milyen intervallumból töltődjenek fel a számok: ");
                Console.WriteLine("Az intervallum induljon:  ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Az intervall tartson: ");
                b = Convert.ToInt32(Console.ReadLine());
            } while (a > b);
            for (int i = 0; i < N; i++) 
            {
                tombok[i]=r.Next(a, b+1);
            }
            for (int i = 0; i < tombok.Length; i++)
            {
                Console.WriteLine($"{i+1}. szám {tombok[i]}");            
            }
            do
            {
                Console.WriteLine("Mit szertnél csinálni\n \t a, Növelni\n\tb, Csökkenteni\n\tc,Szorozni\n\td, Kilépni");
                valasztas = Console.ReadLine();

                switch (valasztas)
                {
                    case "a":
                        int no;
                        Console.WriteLine("Mennyivel szeretnéd növelni az összes számot? ");
                        no = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < tombok.Length; i++)
                        {
                            tombok[i] += no;
                            Console.WriteLine($"{i + 1}. szám {tombok[i]}");
                        }
                        break;
                    case "b":
                        int cso;
                        Console.WriteLine("Mennyivel szeretnéd csökkenteni az összes számot? ");
                        cso = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < tombok.Length; i++)
                        {
                            tombok[i] -= cso;
                            Console.WriteLine($"{i + 1}. szám {tombok[i]}");
                        }
                        break;
                    case "c":
                        int szo;
                        Console.WriteLine("Mennyivel szeretnéd szorzni az összes számot? ");
                        szo = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < tombok.Length; i++)
                        {
                            tombok[i] *= szo;
                            Console.WriteLine($"{i + 1}. szám {tombok[i]}");
                        }
                        break;

                }
            }
            while (valasztas != "d");


        }
        static void Main(string[] args)
        {
            
            //Feltolt();
            Feladat14();

        }
    }
}
