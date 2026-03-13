
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
            return "Excelente";
        }
        else if (promediorendimiento() >= 60)
        {
            return "Bueno";
        }
        else
        {
            return "Malo";
        }
    }

}
