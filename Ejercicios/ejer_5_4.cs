int f, c, f1, c1;
Console.WriteLine("¿Cuantas filas quiere en su matriz 1?");
f = int.Parse(Console.ReadLine());
Console.WriteLine("¿Cuantas columnas quiere en su matriz 1?");
c = int.Parse(Console.ReadLine());
Console.WriteLine("¿Cuantas filas quiere en su matriz 2?");
f1 = int.Parse(Console.ReadLine());
Console.WriteLine("¿Cuantas columnas quiere en su matriz 2?");
c1 = int.Parse(Console.ReadLine());
if (c==c1 && f==f1)
{
    float[,] m1 = new float[f, c];
    float[,] m2 = new float[f1, c1];
    float[,] r = new float[f, c];
    Random n = new Random();
    for (int i = 0; i <f; i++)
    {
        for (int j = 0; j < c; j++)
        {
            m1[i, j] = n.Next(1, 100);
            m2[i, j] = n.Next(1, 100);
            r[i, j] = m1[i, j] - m2[i,j];
        }
    }
    Console.Clear();
    Console.WriteLine("Se visualizan valores de la primera matriz: ");
    for (int i = 0; i < f; i++)
    {
        Console.WriteLine("Fila "+i);
        for (int j = 0; j < c; j++)
        {
            Console.WriteLine(m1[i,j]);
        }
    }
    Console.WriteLine("Se visualizan valores de la segunda matriz: ");
    for (int i = 0; i < f; i++)
    {
        Console.WriteLine("Fila " + i);
        for (int j = 0; j < c; j++)
        {
            Console.WriteLine(m2[i, j]);
        }
    }
    Console.WriteLine("Se visualizan valores de la matriz resultante: ");
    for (int i = 0; i < f; i++)
    {
        Console.WriteLine("Fila " + i);
        for (int j = 0; j < c; j++)
        {
            Console.WriteLine(r[i, j]);
        }
    }
}
else
{
    Console.WriteLine("No se puede realizar la operacion porque las matrices no son iguales");
}
Console.ReadKey();