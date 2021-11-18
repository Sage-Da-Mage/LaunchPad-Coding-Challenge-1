using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CupsController : ControllerBase
    {

        [HttpGet]
        public char Swap([FromRoute] List<String> SwapCommands)
        {
            // The ball starts in the position of 'B'
            char ballLocation = 'B';

            // If there is no passed in list of swap commands return the starting location 'B'
            if(SwapCommands == null)
            {
                return ballLocation;
            }
            // If there is a list of swap commands, begin the process of swapping the balls location
            else
            {

            }
            // Return the final location of the ball
            return ballLocation;
        }
    

    }
}
