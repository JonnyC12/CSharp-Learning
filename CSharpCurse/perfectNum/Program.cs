
List<int> dividers(int numero)
{
    List<int> divisors = new List<int>();
    for (int i = 1; i < Math.Sqrt(numero); i++)
    {
        if (numero % i == 0)
        {
            divisors.Add(i);
            if ((i != numero / i) && (numero / i != numero))
            {
                divisors.Add(numero / i);
            }
        }

    }
    divisors.Sort();
    return divisors;
}
Console.WriteLine("Introduce n num to find all perfect numero 1 to n");
String numero = Console.ReadLine();

List<List<int>> numPerfectList = new List<List<int>>();

for (int i = 1; i <= Convert.ToInt32(numero); i++)
{
    var divisorsofI = dividers(i);

    if (divisorsofI.Sum(x => x) == i)
    {
        Console.WriteLine($"the number {i} is perfect");
        numPerfectList.Add(divisorsofI);
    }
}