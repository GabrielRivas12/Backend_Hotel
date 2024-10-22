using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Services;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabitacionController : ControllerBase
    {
        private readonly HabitacionServices _habitacionServices;
        public HabitacionController(HabitacionServices habitacionServices)
        {
            _habitacionServices = habitacionServices;
        }

        [HttpGet]
        [Route("Get/{id}")]
        public async Task<ActionResult<List<Habitacion>>> GetId(int id)
        {
            var habitacion = await _habitacionServices.GetHabitacion(id);
            return Ok(habitacion);
        }

        [HttpPost("Post")]
        public async Task<ActionResult> Post([FromBody] Habitacion Ohabitacion)
        {
            await _habitacionServices.PostHabitacion(Ohabitacion);
            return Ok("Habitacion registrada");
        }


        [HttpPut("Put")]
        public async Task<ActionResult> Put([FromBody] Habitacion Ohabitacion)
        {
            await _habitacionServices.PutHabitacion(Ohabitacion);
            return Ok("Habitacion actualizado");
        }



        [HttpDelete]
        [Route("Delete{id}")]

        public async Task<ActionResult<List<Habitacion>>> DeleteHabitacion(int id)
        {
            var estudiante = await _habitacionServices.DeleteHabitacion(id);

            return Ok("Habitacion eliminado");
        }



    }
}

   
