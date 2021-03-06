using Microsoft.AspNetCore.Mvc;// MVC = MODELO VISTA CONTROLLADOR - ES LA API LO QUE TOCAS ACÁ -
                               // Lo que media entre user y DB
using Challenge1.Contexts;
using Challenge1.Models;

namespace Challenge1.Controllers
{
    [ApiController]
    //Le permite a Net Core que la clase que estas a punto de referenciar, 
    //va a ser tratada como un controlador con FUNCIONALIDADES de API.
    //le permite servir a los tipos derivados las respuestas HTTP (VERBOS)

    [Route("api/[controller]")]
    //describe la ruta por la que accederemos a los recursos o acciones de nuestra API.

    public class GeneroController : ControllerBase //ControllerBase: La class GeneroController usará funcionalidades MVC
    {
        private readonly DisneyContext _context; // inyectas el contexto de la base de datos por dependencia
        public GeneroController(DisneyContext context)
        {
            _context = context;
        }
        // especifica de qué tipo de verbo va a servir nuestro método, HttpGet es el tipo de verbos de nuestro controlador
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_context.Generos.ToList());
        }

        [HttpPost]
        public IActionResult Post(Genero genero)
        {
            return Ok();
        }
    }

}
