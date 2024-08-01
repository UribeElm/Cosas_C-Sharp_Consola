int np;
Console.WriteLine("¿Cuantos datos meterás en el vector?");
int n=int.Parse(Console.ReadLine());
float[] vec1 = new float[n];
float[] vec2 = new float[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Introduce el dato de la posicion " + i);
    vec1[i]= float.Parse(Console.ReadLine());
    np = i + 1;
    if (np<=n-1)
    {
        vec2[np] = vec1[i];
    }
    else
    {
        vec2[n-1] = vec1[n-2];
        vec2[0] = vec1[n-1];
    }
    
}
Console.Write("Se muestra el cambio de posicion \n I | F \n");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(vec1[i] + " " + vec2[i]);
    }
Console.ReadKey();