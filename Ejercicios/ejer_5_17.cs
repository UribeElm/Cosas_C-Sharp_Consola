float sumHor = 0, sumSue = 0, may = 0; int pos=0;
string[] nomb=new string[5];
float[] s_h=new float[5];
string[] dia=new string[6];
float[,] h_d=new float[5,6];
float[] thSem=new float[5];
float[] suel=new float[5];
dia[0] = "Lunes";
dia[1] = "Martes";
dia[2] = "Miercoles";
dia[3] = "Jueves";
dia[4] = "Viernes";
dia[5] = "Sabado";
for (int i = 0; i < 5; i++)
{
    Console.Clear();
    Console.WriteLine("Nombre del chofer");
    nomb[i] = Console.ReadLine();
    Console.WriteLine("¿Cuanto gana por hora?");
    s_h[i] = float.Parse(Console.ReadLine());
    for (int j = 0; j < 6; j++)
    {
        Console.WriteLine("Total de horas del dia " + dia[j]);
        h_d[i, j] = float.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        sumHor = sumHor + h_d[i, j];
    }
    thSem[i] = sumHor;
    sumHor = 0;
    suel[i] = thSem[i] * s_h[i];
    sumSue = sumSue + suel[i];
}
Console.Clear();
Console.WriteLine("La empresa va a pagar en total: "+sumSue);
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("El trabajador " + nomb[i]+" laboró: " + thSem[i]+" horas. Recibirá " + suel[i]+" pesos de sueldo");
}
for (int i = 0; i < 5; i++)
{
    if (h_d[i,0]>may)
    {
        pos++;
        may = h_d[i, 0];
    }
}
Console.WriteLine("El trabajador que hizo mas horas en lunes fue " + nomb[pos-1]+" con " + h_d[pos-1,1]+" horas.");
Console.ReadKey();