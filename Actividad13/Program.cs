
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
