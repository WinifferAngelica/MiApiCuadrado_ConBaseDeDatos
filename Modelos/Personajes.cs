using Microsoft.EntityFrameworkCore;

public class Personajes
{
    public int Id  { get; set; }

    public string? Nombre { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public string? LugarNacimiento { get; set; }

    public string? Casa { get; set; }

    public string? TipoSangreMagica { get; set; }

    public string? VaritaMagica { get; set; }


}