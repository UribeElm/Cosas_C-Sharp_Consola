float men = 0, cn = 0;
Random r = new Random();
float[,] m1 = new float[12, 12];
float[,] m2 = new float[12, 12];
for (int i = 0; i < 12; i++)
{
	for (int j = 0; j < 12; j++)
	{
		m1[i, j] = r.Next(0, 10);
        m2[i, j] = r.Next(0, 10);
    }
}

Console.WriteLine("Se visualiza la matriz 1: ");
    for (int j = 0; j < 12; j++)
    {
        Console.WriteLine(m1[j,0]+" "+ m1[j, 1] + " " + m1[j, 2] + " " + m1[j, 3] + " " + m1[j, 4] + " " + m1[j, 5] + " " + m1[j, 6] + " " + m1[j, 7] + " " + m1[j, 8] + " " + m1[j, 9] + " " + m1[j, 10] + " " + m1[j,11]);
    }
Console.WriteLine("Se visualiza la matriz 2: ");
    for (int j = 0; j < 12; j++)
    {
        Console.WriteLine(m2[j, 0] + " " + m2[j, 1] + " " + m2[j, 2] + " " + m2[j, 3] + " " + m2[j, 4] + " " + m2[j, 5] + " " + m2[j, 6] + " " + m2[j, 7] + " " + m2[j, 8] + " " + m2[j, 9] + " " + m2[j, 10] + " " + m2[j, 11]);
    }

for (int i = 0; i < 12; i++)
{
    if (m1[i, i] == m2[i,i])
    {
        cn++;
    }
}
if (cn==12)
{
    Console.WriteLine("Las diagonales son iguales");
}
else
{
    Console.WriteLine("Las diagonales no son iguales");
}
Console.ReadKey();