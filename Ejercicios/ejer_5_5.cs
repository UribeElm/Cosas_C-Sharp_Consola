int cn = 0;
Random n= new Random();
Console.WriteLine("¿Cuantas filas quiere en su matriz?");
int f=int.Parse(Console.ReadLine());
Console.WriteLine("¿Cuantas filas quiere en su matriz?");
int c=int.Parse(Console.ReadLine());
if (c==f)
{
    float[,] m = new float[f,c];
	for (int i = 0; i < f; i++)
	{
		for (int j = 0; j < c; j++)
		{
			m[i, j] = n.Next(0,10);
			if (i != j)
			{
				if (m[i,j]==0)
				{
					cn++;
				}
			}
		}
	}
	Console.Clear();
	Console.WriteLine("Se visualizan valores de la matriz inicial: ");
    for (int i = 0; i < f; i++)
    {
		Console.WriteLine("Fila "+i);
        for (int j = 0; j < c; j++)
        {
			Console.WriteLine(m[i,j]);
        }
    }
	if (cn==((f*c)-c))
	{
		Console.WriteLine("La matriz es de tipo diagonal");
	}
	else
	{
		Console.WriteLine("La matriz no es de tipo diagonal");
	}
}
else
{
	Console.WriteLine("No es una matriz cuadrada, saliendo....");
}
Console.ReadKey();