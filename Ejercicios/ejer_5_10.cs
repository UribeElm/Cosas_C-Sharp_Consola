int cont = 10, cont2=512;
int[] v1= new int[100];
int[] v2 = new int[100];
int[] sum= new int[100];
for (int i = 0; i < 100; i++)
{
    cont2++;
    v1[i] = cont2;
    cont++;
    v2[i] = cont;
}
Console.WriteLine("El vector que almacena la suma se muestra");
for (int i = 0; i < 100; i++)
{
    sum[i] = v1[i] + v2[i];
    Console.WriteLine(v1[i] + " + " + v2[i] + " = " + sum[i]);
}
Console.ReadKey();