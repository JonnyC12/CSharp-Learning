namespace EntradaPorTeclado
{
    internal class Ejer
    {
        public static void esPar()
        {
            List<int> nume = new List<int>();
            Console.WriteLine($"Teclea dos número y te diré cual es el par");
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Introduce el {i} numero");
                string? numero = Console.ReadLine();
                nume.Add(Convert.ToInt32(numero));
            }
            var pares = nume.Where(x => x % 2 == 0).ToList();

            if (pares.Count() > 0)
            {
                foreach (var item in pares)
                {
                    Console.WriteLine($"El numero {item} es par");
                }
            }
            else
            {
                Console.WriteLine($"Ninguno numero es par");
            }
        }
        public static bool esNumeroPar(int num)
        {
            return num % 2 == 0;
        }
    }
}