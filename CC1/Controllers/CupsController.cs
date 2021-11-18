using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CupsController : ControllerBase
    {

        [HttpGet ("swap")]
        public IEnumerable Swap([FromRoute] List<String> SwapCommands)
        {
            // The ball starts in the position of 'B'
            var ballLocation = "B";

            // If there is no passed in list of swap commands return the starting location 'B'
            if(SwapCommands == null)
            {
                return "The cups were not moved, the ball is in location" + ballLocation;
            }
            // If there is a list of swap commands, begin the process of swapping the balls location
            else
            {
                // Read the list of swap commands

                // Take the first one off the front (loop until all swaps have been read)
            //{

                // Check if it is a valid swap

                // If it is not a valid swap return BadRequest message

                // Otherwise preform the swap
            //}

            }
            // Return the final location of the ball
            return ballLocation;
        }
    

    }
}
