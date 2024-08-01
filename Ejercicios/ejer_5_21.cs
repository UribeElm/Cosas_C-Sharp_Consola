float[,] m = new float[5, 5];
int cIm=0, cPa=0;
Random r=new Random();
for (int i = 0; i<5;i++)
{
    for (int j = 0; j < 5; j++)
    {
        m[i, j] = r.Next(1,100);
        if ((m[i,j]%2)!=0)
        {
            cIm++;
        }
        else
        {
            cPa++;
        }
    }
}
Console.WriteLine("Se muestra la matriz");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(m[i, 0] + " " + m[i, 1] + " " + m[i, 2] + " " + m[i, 3] + " " + m[i, 4]);
}
Console.WriteLine("La cantidad de valores pares es: "+cPa);
Console.WriteLine("La cantidad de valores impares es: "+cIm);
Console.ReadKey();