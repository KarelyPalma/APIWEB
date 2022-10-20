using WebApi.Models.Base;

namespace WebApi.Models;

public class Prestamo: Model
{

    public int? IdBook {get; set;}

    public int? IdUsuario {get;set;}

    public string? Devuelto {get;set;}

    public DateTime FechadEPrestamo {get; set;}

    public DateTime FechadeDevoluvion {get;set;}

    public virtual Usuario? Usuario { get; set;} = default!;
    public virtual Book? Book { get; set;} = default!;
}