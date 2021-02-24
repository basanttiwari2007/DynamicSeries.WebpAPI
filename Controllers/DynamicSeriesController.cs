using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicSeries.WebpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicSeriesController : ControllerBase
    {
        //nned to take 2 parameter
        //process them and send to output

        [HttpGet]
        public IActionResult GetSeriesData(int divisor, int number)
        {
            //error handling to be written
            int result = ExecuteSeries(divisor, number);

            if (result > 0)
                return Ok(result);

            return Ok("Some eror occured");
            
        }

        private int ExecuteSeries(int divisor, int number)
        {
            //logic of generating series
            int result = 0;
            try
            {
                 result = number / divisor;
            }
            catch(Exception ex)
            {
                
            }
            
            return result;
        }
    }
}
