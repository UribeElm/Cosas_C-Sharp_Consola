using System.Transactions;

float sum = 0; int cont = 0;
Random r= new Random();
int[] alm= new int[100];
for (int i = 0; i < 100; i++)
{
    alm[i] = r.Next(1, 10);
    sum = sum + alm[i];
    Console.WriteLine("Alumno: "+(i+1)+" calificacion " + alm[i]);
}
float prom = sum / 100;
for (int i = 0; i < 100; i++)
{
    if (alm[i]>prom)
    {
        cont++;
    }
}
Console.Write("El promedio general es de " + prom + " \nEl total de alumnos con calificacion arriba del promedio es "+cont);
Console.ReadKey();