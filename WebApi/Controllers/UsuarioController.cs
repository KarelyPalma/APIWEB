using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController, Route ("api/[controller]")]
public class UsuarioController : ApiControllerBase<Usuario>
{
    public UsuarioController(DataContext context, ILogger<Usuario> logger) : base(context, logger)
    {
            
    }
}