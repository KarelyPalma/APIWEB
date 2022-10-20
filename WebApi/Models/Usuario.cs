using WebApi.Models.Base;

namespace WebApi.Models;

public class Usuario: Model
{
    public string? Nombre {get; set;}

    public string? Apellido {get; set;}
    public string? NumCelular {get; set;}

    public string? Dirreccion {get; set;}
    public string? CorreoElectronico {get; set;}
    public virtual IList<Prestamo>? Prestamos { get; set; } = default!;




}