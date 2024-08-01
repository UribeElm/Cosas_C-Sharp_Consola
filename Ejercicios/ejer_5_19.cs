float sum1 = 0, sum2 = 0;
Console.WriteLine("¿Cuantas filas quiere en su matriz?");
int f = int.Parse(Console.ReadLine());
Console.WriteLine("¿Cuantas columnas quiere en su matriz?");
int c = int.Parse(Console.ReadLine());
float[,] m = new float[f, c];
float[] s1 = new float[f];
float[] s2 = new float[c];
Random r = new Random();
for (int i = 0; i < f; i++)
{
	for (int j = 0; j < c; j++)
	{
		m[i, j] = r.Next(1, 10);
	}
}
Console.WriteLine("Se visualiza la matria inicial:");
for (int i = 0; i < f; i++)
{
    Console.WriteLine("Fila " + i);
    for (int j = 0; j < c; j++)
    {
        Console.WriteLine(m[i, j]);
        sum1 = sum1 + m[i, j];
        sum2 = sum2 + m[j, i];
    }
    s1[i] = sum1;
    sum1 = 0;
    s2[i] = sum2;
    sum2=0;
}
for (int i = 0; i <f; i++)
{
    Console.WriteLine("La suma de los valores en la fila "+i+" es: " + s1[i]);
    Console.WriteLine("La suma de los valores en la columna "+i+" es: " + s2[i]);
}
Console.ReadKey();