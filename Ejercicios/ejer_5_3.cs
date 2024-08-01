float sum = 0; int m,n;
Console.WriteLine("Ingrese el numero de filas de la primer matriz");
m=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el numero de columnas de la primer matriz");
n = int.Parse(Console.ReadLine());
if (m==n)
{
    float[,] m1 = new float[m, n];
    Console.Clear();
    Console.WriteLine("A continuacion ingrese los valores de la matriz");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine("Ingresa el valor de la posicion "+i+" "+j);
            m1[i,j]=float.Parse(Console.ReadLine());
        }
    }
    Console.Clear();
    for (int i = 0; i < n; i++)
    {
        sum = sum + m1[i, i];
    }
    Console.WriteLine("La suma de los elementos de la diagonal es: " + sum);
}
else
{
    Console.WriteLine("No se puede realizar la operacion ya que no es una matriz cuadrada");
}
Console.ReadKey();