using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController, Route ("api/[controller]")]
public class PrestamoController : ApiControllerBase<Prestamo>
{
    public PrestamoController(DataContext context, ILogger<Prestamo> logger) : base(context, logger)
    {
            
    }
}