using Challenge1.Contexts;
using Challenge1.Models;
using Microsoft.AspNetCore.Mvc; // MVC = MODELO VISTA CONTROLLADOR - ES LA API LO QUE TOCAS ACÁ -
                                // Lo que media entre user y DB


namespace Challenge1.Controllers
{

    [ApiController]
    //Le permite a Net Core que la clase que estas a punto de referenciar, 
    //va a ser tratada como un controlador con FUNCIONALIDADES de API.
    //le permite servir a los tipos derivados las respuestas HTTP (VERBOS)


    [Route("api/characters")]
    //describe la ruta por la que accederemos a los recursos o acciones de nuestra API.

    public class PersonajeController : ControllerBase //ControllerBase: La class GeneroController usará funcionalidades MVC
    {
        private readonly DisneyContext _context; // inyectas el contexto de la base de datos por dependencia
        public PersonajeController(DisneyContext context)
        {
            _context = context;
        }

        [HttpGet] // especifica de qué tipo de verbo va a servir nuestro método, HttpGet es el tipo de verbos de nuestro controlador
        public IActionResult Get() // es el GET que aparece en el Swagger - GET /api/continent (es la ruta)
        {                           // IActionResult es una interfac e 
            return Ok(_context.Generos.ToList());
        }

        [HttpPost] //publica nuevo personaje
        public IActionResult Post(Personaje personaje)
        {
            _context.Personajes.Add(personaje);
            _context.SaveChanges();
            //return Ok(_context.Personajes.ToList()); // retorna todos los personajes
            return CreatedAtAction("Get", new { id = personaje.Id }, personaje); // retorna el personaje
        }

        // Borrar personaje
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Personaje personaje = _context.Personajes.Find(id);

            if (personaje == null) // null es que NO existe, o sea, que personaje es null 
            {
                return NotFound(); // retorna no encontrado
            }

            // si lo encontro, sigue..
            _context.Personajes.Remove(personaje); // primero remueve
            _context.SaveChanges(); // despues guardas

            return NoContent(); // podes retornar nada, la lista de personajes
        }

        // buscar personaje por pelicula
        [HttpGet]
        public IActionResult GetCharacterByAge(int edad) // edad 50
        {
            List<Personaje> personajes = _context.Personajes.Where(p => p.Edad == edad).ToList();
            // personaje1 tioene 30 = 50? NO, no lo agrega
            //personaje1 tiene 50 = 50 ? SI, entonces lo agrega

            if (personajes.Count == 0)
            {
                return NotFound();
            }

            return (IActionResult)personajes; // ver con Action Lista, por ahora se castea para que no de error
        }

        // para modificar es similar, pero es con PUT, no con GET
    }
}
