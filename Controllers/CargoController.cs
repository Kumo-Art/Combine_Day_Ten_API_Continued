using Combine_Day_Ten_API_Continued.Models;
using Combine_Day_Ten_API_Continued.Services;
using Microsoft.AspNetCore.Mvc;

namespace Combine_Day_Ten_API_Continued.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CargoController : ControllerBase
    {
        

        //Constructor -- runs once when the method is callec
        private readonly ICargoServices _cargo; //Declaring our empty CargoServices
       // readonly means it can never be reassigned
       
        public CargoController(ICargoServices cargo)
        {
            _cargo = cargo;
        }

        //We are injecting our services into our controller to gain access to the methods


        [HttpGet("GetAll")]

        public ActionResult GetAllCargo()
        {
            return Ok(_cargo.GetAll());
        }

        [HttpGet("GetByCatagory/{catagory}")]

        public ActionResult<List<CargoItem>> GetByCatagory(string catagory)
        {
            List<CargoItem> items = _cargo.GetByCatagory(catagory);

            return Ok(items);
        }

        [HttpGet("GetById/{id}")]

        public ActionResult<CargoItem> GetById(int id)
        {
            CargoItem item = _cargo.GetById(id);

            if (item == null)
            {
                return NotFound($"That id is not in our system {id}");
            }

            return Ok(item);
        }

        [HttpPost("Create")]

        public ActionResult<CargoItem> Create([FromBody] CargoItem item)
        {
            CargoItem newItem = _cargo.Create(item);
 

          //nameof points to where we can find our new created id
          //new setting that id inside of our url. /api/getbyid/{new id}

            return CreatedAtAction(
                nameof(GetById),
                new { id = newItem.Id},
                newItem
            );
        }

        [HttpPut("Update/{id}")]

        public ActionResult<bool> UpdateCargo(int id, CargoItem item)
        {
            bool updated = _cargo.Update(id, item);

            if(updated == false)
            {
                return NotFound($"No Cargo was found with Id {id}");
            }

          // return Ok(true);

            return NoContent(); //204 - it worked nothing to send back
        }

        [HttpDelete("delete{id}")]

        public ActionResult<bool> DeleteItem(int id)
        {
            bool deleted = _cargo.Delete(id);

            if (deleted == false)
            {
                return NotFound($"No cargo item with Id {id}");
            }

            return Ok(deleted);
        }



    }
}