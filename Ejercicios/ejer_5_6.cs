string[] name = new string[10];
int[] edad = new int[10];
int may=0, pos=0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Escribe el nombre del alumno: ");
    name[i] = Console.ReadLine();
    Console.WriteLine("Escribe la edad de " + name[i]);
    edad[i] = int.Parse(Console.ReadLine());
    if (edad[i] > may)
    {
        may = edad[i];
        pos++;
    }
}
Console.WriteLine("El alumno mas viejo es " + name[pos] + " con " + edad[pos] + " años");
Console.ReadKey();