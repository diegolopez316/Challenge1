using Microsoft.AspNetCore.Mvc;// MVC = MODELO VISTA CONTROLLADOR - ES LA API LO QUE TOCAS ACÁ -
                               // Lo que media entre user y DB
namespace Challenge1.Controllers

{

    [ApiController]
    //Le permite a Net Core que la clase que estas a punto de referenciar, 
    //va a ser tratada como un controlador con FUNCIONALIDADES de API.
    //le permite servir a los tipos derivados las respuestas HTTP (VERBOS)

    [Route("api/[controller]")]
    //describe la ruta por la que accederemos a los recursos o acciones de nuestra API.

    public class PeliculaController : ControllerBase //ControllerBase: La class GeneroController usará funcionalidades MVC
    {

    }
}
