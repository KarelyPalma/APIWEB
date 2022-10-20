using WebApi.Models.Base;

namespace WebApi.Models;

public class Editorial: Model
{
    public string? Nombre {get; set;}

    public string? Ciudad {get; set;}

    public string? ISBN {get; set;}

    public virtual IList<Editorial>? Editorials { get; set; } = default!;

    public virtual IList<Book>? Books { get; set; } = default!;
    
    
}