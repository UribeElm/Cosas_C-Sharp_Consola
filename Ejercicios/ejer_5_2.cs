float[,] m1 = new float[3, 3];
float[,] m2 = new float[3, 3];
float[,] res = new float[3, 3];
Console.WriteLine("Programa para multiplicar una Matriz MXN de 3x3 por una matriz PXQ de 3x3");
Console.Clear();
Console.WriteLine("A continuacion ingrese los valores de la primera matriz");
m1=new float[3, 3];
m2=new float[3, 3];
res=new float[3, 3];
for (int i = 0; i <3; i++)
{
	for (int j = 0; j < 3; j++)
	{
		Console.WriteLine("Ingresa el valor de la posición " + i + " " + j + " :");
		m1[i, j] = float.Parse(Console.ReadLine());
    }
}
Console.Clear();
Console.WriteLine("A continuacion ingrese los valores de la segunda matriz");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Ingresa el valor de la posición " + i + " " + j + " :");
        m2[i, j] = float.Parse(Console.ReadLine());
    }
}
Console.Clear();
Console.WriteLine("La primera matriz es: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine(m1[i,0]+" " + m1[i,1]+" " + m1[i,2]);
    }
}
Console.WriteLine("La segunda matriz es: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine(m2[i, 0] + " " + m2[i, 1] + " " + m2[i, 2]);
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        res[i, j] = m1[i, 0] * m2[0, j] + m1[i, 1] * m2[1, j] + m1[i, 2] * m2[2, j];
    }
}
Console.WriteLine("El resultado es la matriz:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine(res[i, 0] + " " + res[i, 1] + " " + res[i, 2]);
    }
}
Console.ReadKey();