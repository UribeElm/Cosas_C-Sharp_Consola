using System.Security.Cryptography;

float[,] m= new float[5,6];
int c1=0, c2=0;
Random r= new Random();
for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 6; j++)
	{
		m[i, j] = r.Next(-1, 10);
		if (m[i,j]<0)
		{
			c1++;
		}
		if (i==j)
		{
			if (m[i,j]==0)
			{
				c2++;
			}
		}
	}
}
Console.WriteLine("Se muestra la matriz");
for (int i = 0; i<5; i++)
{
	Console.WriteLine(m[i,0]+" "+ m[i, 1] + " " + m[i, 2] + " " + m[i, 3]+" " + m[i,4]);
}
Console.WriteLine("El total de numeros negativos es: "+c1);
Console.WriteLine("El total de ceros en la diagonal es: "+c2);
Console.ReadKey();