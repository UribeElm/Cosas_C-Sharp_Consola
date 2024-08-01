float[,] m = new float[6, 8];
float[,] pos = new float[6, 8];
int c=0;
Random r= new Random();
for (int i = 0; i < 6; i++)
{
	for (int j = 0; j < 8; j++)
	{
		m[i, j] = r.Next(-5,100);
		if (m[i,j]<0)
		{
			pos[i, j] = m[i, j];
		}
	}
}
Console.WriteLine("Se visualiza la matriz");
for (int i = 0; i < 6; i++)
{
	Console.WriteLine(m[i, 0] + " " + m[i, 1] + " " + m[i, 2] + " " + m[i, 3] + " " + m[i, 4] + " " + m[i, 5] + " " 
		+ m[i, 6] + " " + m[i, 7]);
}
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 8; j++)
    {
		if (m[i,j]<0)
		{
			c++;
			pos[i, j] = m[i, j];
			Console.WriteLine("El negativo " + m[i,j]+" se encuentra en la fila: "+i+" columna: "+j);
		}
    }
}
if (c==0)
{
	Console.WriteLine("No hay negativos");
}
Console.ReadKey();