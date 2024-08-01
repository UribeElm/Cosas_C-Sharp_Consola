float[,] m = new float[5, 5];
float mul = 1;
Random r=new Random();
for (int i = 0;i<5;i++)
{
	for (int j = 0; j < 5; j++)
	{
		m[i, j] = r.Next(1,4);
	}
}
for (int i = 0; i < 5; i++)
{
	Console.WriteLine(m[i, 0] + " " + m[i, 1] + " " + m[i, 2] + " " + m[i, 3] + " " + m[i, 4]);
	mul = mul * m[i, i];
}
Console.WriteLine("El producto de la diagonal es: " + mul);
Console.ReadKey();