char[] letra = new char[10];


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite uma letra: ");
    letra[i] = char.Parse(Console.ReadLine());

}

Console.WriteLine("\nVogais: ");
for (int i = 0; i < 10; i++)
{

    if (letra[i] == 'A' || letra[i] == 'E' || letra[i] == 'I' || letra[i] == 'O' || letra[i] == 'U')
    {
        Console.WriteLine(letra[i] + "");
    }

}

Console.WriteLine("\nConsoantes: ");
for (int i = 0; i < 10; i++)
{
    if (letra[i] != 'A' && letra[i] != 'E' && letra[i] != 'I' && letra[i] != 'O' && letra[i] != 'U')
    {
        Console.WriteLine(letra[i] + "");
    }
}