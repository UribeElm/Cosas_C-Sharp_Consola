float[,] m = new float[12, 19]; int cn = 0;
Random r = new Random();
for (int i = 0; i < 12; i++)
{
	for (int j = 0; j < 19; j++)
	{
		m[i, j] = r.Next(-5, 100);
	}
}
Console.WriteLine("Se visualiza la matriz inicial: ");
for (int i = 0; i < 12; i++)
{
	Console.WriteLine(m[i,0]+" "+ m[i, 1] + " " + m[i, 2] + " " + m[i, 3] + " " + m[i, 4] + " " 
		+ m[i, 5] + " " + m[i, 6] + " " + m[i, 7] + " " + m[i, 8] + " " + m[i, 9] + " " + m[i, 10] + " " 
		+ m[i, 11] + " " + m[i, 12] + " " + m[i, 13] + " " + m[i, 14] + " " + m[i, 15] + " " + m[i, 16] + " " 
		+ m[i, 17] + " " + m[i, 18]);
}
for (int i = 0; i < 12; i++)
{
	for (int j = 0; j < 19; j++)
	{
		if (m[i,j]<0)
		{
			m[i, j] = 0;
			cn++;
		}
    }
}
Console.WriteLine("Se visualiza la matriz cambiada: ");
for (int i = 0; i < 12; i++)
{
    Console.WriteLine(m[i, 0] + " " + m[i, 1] + " " + m[i, 2] + " " + m[i, 3] + " " + m[i, 4] + " "
        + m[i, 5] + " " + m[i, 6] + " " + m[i, 7] + " " + m[i, 8] + " " + m[i, 9] + " " + m[i, 10] + " "
        + m[i, 11] + " " + m[i, 12] + " " + m[i, 13] + " " + m[i, 14] + " " + m[i, 15] + " " + m[i, 16] + " "
        + m[i, 17] + " " + m[i, 18]);
}
Console.WriteLine("Se actualizaron: "+cn+" valores");
Console.ReadKey();