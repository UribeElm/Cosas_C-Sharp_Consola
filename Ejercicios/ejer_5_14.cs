double[] v= new double[100];
double[] c= new double[100];
double sum=0;
Random r= new Random();
Console.WriteLine("Se visualiza el vector");
for (int i = 0; i < 100; i++)
{
    v[i] = r.Next(-10, 100);
    c[i] = v[i] * v[i];
    sum = sum + c[i];
    Console.WriteLine(v[i]);
}
double ra=Math.Sqrt(sum);
Console.WriteLine("La magnitud del vector es: " + ra);
Console.ReadKey();