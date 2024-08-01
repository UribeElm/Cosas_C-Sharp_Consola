int cn=0;
Random r=new Random();
Console.WriteLine("¿Cuantas filas quiere en su arreglo?");
int f = int.Parse(Console.ReadLine());
Console.WriteLine("¿Cuantas columnas quiere en su arreglo?");
int c = int.Parse(Console.ReadLine());
float[,] m = new float[f, c];
for (int i = 0; i < f; i++)
{
	for (int j = 0; j < c; j++)
	{
		m[i, j] = r.Next(-8,8);
	}
}
Console.Clear();
Console.WriteLine("Se visualizan valores de la matriz inicial");
for (int i = 0; i < f; i++)
{
	Console.WriteLine("Fila " + i);
	for (int j = 0; j < c; j++)
	{
		Console.WriteLine(m[i, j]);
	}
}
for (int i = 0; i < f; i++)
{
    for (int j = 0; j < c; j++)
    {
        if(m[i, j] < 0)
		{
            m[i, j] = 0;
            cn++;
        }
    }
}
Console.WriteLine("Se visualizan valores de la matriz actualizada: ");
for (int i = 0; i < f; i++)
{
    Console.WriteLine("Fila " + i);
    for (int j = 0; j < c; j++)
    {
        Console.WriteLine(m[i, j]);
    }
}
Console.WriteLine("Se realizaron: "+cn+" actualizaciones");
Console.ReadKey();