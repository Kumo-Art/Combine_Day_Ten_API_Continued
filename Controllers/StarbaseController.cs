using Microsoft.AspNetCore.Mvc;

namespace Combine_Day_Ten_API_Continued.Controllers
{
    //APIController automates 400 responses
    [ApiController]
    //Base route /api this will be the base of our endpoint
    //api/starbase
    [Route("api/[controller]")]
    public class StarbaseController : ControllerBase
    {
        //This will be our fake DB

       List<string> sectors = ["Engineering", "Medical", "Command", "Cargo", "Docking"];

       [HttpGet("sectors")]//Reading / Getting information from our API

       public List <string> GetSectors() //When using controllers we do not use traditional return methods like these
        {
            return sectors;
        }

[HttpGet("sectors/{index}")] //Route with parameter must match parameter in method

public ActionResult<string> GetSectorInformation(int index)
        {
           if (index < 0 || index > sectors.Count -1)
            {
                //They've entered a number out of bounds they will get a 400 not found
                return NotFound($"No Sector found at the index of {index}. Please enter a number between 0 and {sectors.Count}");
            }
           
           //200 ok with the value in response body
            return Ok(sectors[index]);
        }
[HttpGet("Status")]
public ActionResult<object> GetStatus()
        {
            return Ok(new
            {
                Station = "Starbase - 7",
                Online = true,
                CrewCount = 8,
                CheckedAt = DateTime.Now
            });
        }

    }
}