using System.Diagnostics.CodeAnalysis;

float sum = 0;
float[,] m1= new float[1,10];
float[,] m2= new float[10,1];
float[] r= new float[10];
Random ran=new Random();
for (int i = 0; i < 10; i++)
{
    m1[0, i] = ran.Next(1, 10);
    m2[i, 0] = ran.Next(1, 10);
    r[i] = m1[0, i] * m2[i, 0];
    sum = sum + r[i];
}
Console.WriteLine("El vector 1 es: ");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(m1[0, i]);
}
Console.WriteLine("El vector 2 es: ");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(m2[i, 0]);
}
Console.WriteLine("El producto escalar de estos vectores es: " + sum);
Console.ReadKey();