
class Dispositivos
{
    public string Nombre;
    public double rendimiento1;
    public double rendimiento2;
    public double rendimiento3;

    public double promediorendimiento ()
    { return (rendimiento1+ rendimiento2 + rendimiento3)/3;  }

    public string resultado()
    {
        if(promediorendimiento() >= 80)
        {
            return "Excelentes condiciones";
        }
        else
        {
            return "Necesita mantenimiento";
        }
    }

    public void mostrarresultado()
    {
        Console.WriteLine($"El dispositivo {Nombre} tiene un rendimiento promedio de {promediorendimiento():F2} y se encuentra en {resultado()}");
    }

}

List<Dispositivos> dispositivos = new List<Dispositivos>();
Console.WriteLine("Ingrese cuantos dispositivos desea evaluar:");
int n=int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Dispositivos e = new Dispositivos();
    Console.WriteLine($"\nDispositivo {i+1}:");
    Console.WriteLine("Nombre"); e.Nombre = Console.ReadLine();
    dispositivos.Add(e);
}
